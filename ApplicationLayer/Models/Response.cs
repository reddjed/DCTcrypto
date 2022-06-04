using System;
using System.Collections.Generic;

namespace ApplicationLayer.Models
{
    public class Response<T>
    {
        public bool IsSuccess { get; }
        public T? Data { get; }
        public string? Message { get; }

        private Response(bool isSuccess, T? data, string? message = null) =>
            (IsSuccess, Data, Message) = (isSuccess, data, message);

        public static Response<T> Success(T? data) =>
            new(true, data);
        public static Response<T> Error(string? message) =>
            new(false, default, message);

    }
}
