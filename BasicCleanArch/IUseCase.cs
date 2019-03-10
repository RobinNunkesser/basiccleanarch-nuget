﻿namespace BasicCleanArch
{
    public interface IUseCase<Request, Response>
    {
        void Execute(Request request, IDisplayer<Response> outputBoundary);
    }
}