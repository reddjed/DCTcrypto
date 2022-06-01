using System;
using System.Collections.Generic;

namespace ApplicationLayer.Models
{
    public class ResponseModel<T>
    {
        public bool IsSuccess { get; }
        public T? Data { get; }
        public string? Message { get; }

        private ResponseModel(bool isSuccess, T? data, string? message = null) =>
            (IsSuccess, Data, Message) = (isSuccess, data, message);

        public static ResponseModel<T> Success(T? data) =>
            new(true, data);
        public static ResponseModel<T> Error(string? message) =>
            new(false, default, message);

    }
}
