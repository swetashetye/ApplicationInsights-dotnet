//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Schema Generator
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using Microsoft.ApplicationInsights.DataContracts;
    
    internal static class ExceptionDetailsSerializer
    {
        public static void Serialize(ExceptionDetails item, JsonWriter writer)
        {
            writer.WriteStartObject();
            SerializeFields(item, writer);
            writer.WriteEndObject();
        }
        
        public static void SerializeFields(ExceptionDetails item, JsonWriter writer)
        {
            writer.WriteProperty("id", item.id);
            writer.WriteProperty("outerId", item.outerId);
            writer.WriteRequiredProperty("typeName", item.typeName, 1024);
            writer.WriteRequiredProperty("message", item.message, 32768);
            writer.WriteProperty("hasFullStack", item.hasFullStack);
            writer.WriteProperty("stack", item.stack, 32768);
            writer.WritePropertyName("parsedStack");
            writer.WriteStartArray();
            {
                int count = 0;
                foreach (var i in item.parsedStack)
                {
                    if (count++ != 0)
                    {
                        writer.WriteComma();
                    }
                    StackFrameSerializer.Serialize(i, writer);
                }
            }
            writer.WriteEndArray();
        }
    }
}