using SEx;

Executor executor = new();
Tracer tracer = new();
executor.StateChanged += tracer;

executor.Step();
executor.Step();
executor.Step();
executor.Step();
