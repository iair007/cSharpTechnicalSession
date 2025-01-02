
using BenchmarkDotNet.Running;
using cSharpPresentation;

////Nullable Reference Types
//string message = null;
//Console.WriteLine(message.Length);

// Asynchronous Streams
await AsynchronousStreams.Run();
await AsynchronousStreams.RunAsync();

//Indices and Ranges
RangesAndIndices.Run();
SwitchExpression.Run();

RecordExample.Run();

MinimalAPI.Run();

ArgumentValidationDemo.Run();

SpanExample.Run();

YieldReturnExample.Run();
BenchmarkRunner.Run<YieldReturnExampleBenchmark>();

LinQExample.Run();
LinQExample.RunCountBy();


