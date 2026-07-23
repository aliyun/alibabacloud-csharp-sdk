// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkBaiLianParameters : TeaModel {
        /// <summary>
        /// <para>The post-processing logic that runs after the main operation completes.</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public SinkBaiLianParametersAfter After { get; set; }
        public class SinkBaiLianParametersAfter : TeaModel {
            /// <summary>
            /// <para>The method for generating the value. The <c>JSONPATH</c> option extracts data from the event payload. Valid values: <c>CONSTANT</c>, <c>JSONPATH</c>, and <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string for formatting the value. This parameter is used only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content for the value, as specified by the <c>Form</c> parameter. For example, if <c>Form</c> is <c>JSONPATH</c>, this value must be a JSONPath expression.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the Model Studio application to invoke.</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The pre-processing logic to apply to an event before it is sent to the target.</para>
        /// </summary>
        [NameInMap("Before")]
        [Validation(Required=false)]
        public SinkBaiLianParametersBefore Before { get; set; }
        public class SinkBaiLianParametersBefore : TeaModel {
            /// <summary>
            /// <para>The method for generating the value. The <c>JSONPATH</c> option extracts data from the event payload. Valid values: <c>CONSTANT</c>, <c>JSONPATH</c>, and <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string for formatting the value. This parameter is used only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content for the value, as specified by the <c>Form</c> parameter. For example, if <c>Form</c> is <c>JSONPATH</c>, this value must be a JSONPath expression.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Context information for the application. The value must be a JSON object.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public object Context { get; set; }

        /// <summary>
        /// <para>Additional key-value pairs to pass to the target. The value must be a valid JSON object.</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public object Extend { get; set; }

        /// <summary>
        /// <para>The offset for reading events from a stream or queue, used for stateful processing.</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOffset Offset { get; set; }
        public class SinkBaiLianParametersOffset : TeaModel {
            /// <summary>
            /// <para>The method for generating the value. The <c>JSONPATH</c> option extracts data from the event payload. Valid values: <c>CONSTANT</c>, <c>JSONPATH</c>, and <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string for formatting the value. This parameter is used only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content for the value, as specified by the <c>Form</c> parameter. For example, if <c>Form</c> is <c>JSONPATH</c>, this value must be a JSONPath expression.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The operation that the Model Studio application will perform.</para>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOp Op { get; set; }
        public class SinkBaiLianParametersOp : TeaModel {
            /// <summary>
            /// <para>The method for generating the value. The <c>JSONPATH</c> option extracts data from the event payload. Valid values: <c>CONSTANT</c>, <c>JSONPATH</c>, and <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string for formatting the value. This parameter is used only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content for the value, as specified by the <c>Form</c> parameter. For example, if <c>Form</c> is <c>JSONPATH</c>, this value must be a JSONPath expression.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The partition key for the event. This key routes events to a specific partition in the target service, ensuring ordered processing.</para>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public SinkBaiLianParametersPartition Partition { get; set; }
        public class SinkBaiLianParametersPartition : TeaModel {
            /// <summary>
            /// <para>The method for generating the value. The <c>JSONPATH</c> option extracts data from the event payload. Valid values: <c>CONSTANT</c>, <c>JSONPATH</c>, and <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string for formatting the value. This parameter is used only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content for the value, as specified by the <c>Form</c> parameter. For example, if <c>Form</c> is <c>JSONPATH</c>, this value must be a JSONPath expression.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the Model Studio workspace.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
