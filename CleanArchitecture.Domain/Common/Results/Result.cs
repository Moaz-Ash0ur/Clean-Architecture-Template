using CleanArchTemp.Domain.Common.Results.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchTemp.Domain.Common.Results
{
    public static class Result
    {
        public static Success Success => default;
        public static Created Created => default;
        public static Deleted Deleted => default;
        public static Updated Updated => default;
    }

    public readonly record struct Success;
    public readonly record struct Created;
    public readonly record struct Deleted;
    public readonly record struct Updated;



    public sealed class Result<TValue> : IResult<TValue>
    {
        private readonly TValue? _value = default;

        private readonly List<Error>? _errors = null;

        public bool IsSuccess { get; }

        [JsonConstructor]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("For serializer only.", true)]
        public Result(TValue? value, List<Error>? errors, bool isSuccess)
        {
            if (isSuccess)
            {
                _value = value ?? throw new ArgumentNullException(nameof(value));
                _errors = [];
                IsSuccess = true;
            }
            else
            {
                if (errors == null || errors.Count == 0)
                {
                    throw new ArgumentException("Provide at least one error.", nameof(errors));
                }

                _errors = errors;
                _value = default!;
                IsSuccess = false;
            }
        }

        private Result(Error error)
        {
            _errors = [error];
        }

        private Result(List<Error> errors)
        {
            if (errors is null || errors.Count == 0)
            {
                throw new ArgumentException("Cannot create an ErrorOr<TValue> from an empty collection of errors. Provide at least one error.", nameof(errors));
            }

            _errors = errors;

            IsSuccess = false;
        }

        private Result(TValue value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _value = value;

            IsSuccess = true;
        }





        public bool IsError => !IsSuccess;

        public List<Error> Errors => IsError ? _errors! : [];

        public TValue Value => IsSuccess ? _value! : default!;

        public Error TopError => (_errors?.Count > 0) ? _errors[0] : default;

        //instead of use if\else just send the func depand state ||  Discriminated Union
        public TNextValue Match<TNextValue>(Func<TValue, TNextValue> onValue, Func<List<Error>, TNextValue> onError)
            => IsSuccess ? onValue(Value!) : onError(Errors);

        public static implicit operator Result<TValue>(TValue value)
            => new(value);

        public static implicit operator Result<TValue>(Error error)
            => new(error);

        public static implicit operator Result<TValue>(List<Error> errors)
            => new(errors);
    }





}
