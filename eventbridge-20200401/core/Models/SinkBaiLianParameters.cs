// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkBaiLianParameters : TeaModel {
        /// <summary>
        /// <para>The post-processing logic executed after the main operation is completed.</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public SinkBaiLianParametersAfter After { get; set; }
        public class SinkBaiLianParametersAfter : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from the event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. It is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to JSONPATH, this value must be a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the Model Studio application to be invoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KnowledgeBase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The pre-processing logic executed before the event is sent to the target.</para>
        /// </summary>
        [NameInMap("Before")]
        [Validation(Required=false)]
        public SinkBaiLianParametersBefore Before { get; set; }
        public class SinkBaiLianParametersBefore : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from the event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. It is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to JSONPATH, this value must be a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The context information of the application, which must be a JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public object Context { get; set; }

        /// <summary>
        /// <para>The additional key-value pairs passed to the event target, which must be a valid JSON object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public object Extend { get; set; }

        /// <summary>
        /// <para>The offset for reading the event from a stream or queue, which is used for stateful processing.</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOffset Offset { get; set; }
        public class SinkBaiLianParametersOffset : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from the event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. It is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to JSONPATH, this value must be a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The operation to be performed by the Model Studio application.</para>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOp Op { get; set; }
        public class SinkBaiLianParametersOp : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from the event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. It is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to JSONPATH, this value must be a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The partition key of the event, which is used to route the event to a specific partition of the target service to ensure ordered processing.</para>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public SinkBaiLianParametersPartition Partition { get; set; }
        public class SinkBaiLianParametersPartition : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from the event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. It is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>${partition}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to JSONPATH, this value must be a JSONPath expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the Model Studio workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-a1b2c3d4e5f6g7h8</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
