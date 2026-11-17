// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkBaiLianParameters : TeaModel {
        [NameInMap("After")]
        [Validation(Required=false)]
        public SinkBaiLianParametersAfter After { get; set; }
        public class SinkBaiLianParametersAfter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KnowledgeBase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("Before")]
        [Validation(Required=false)]
        public SinkBaiLianParametersBefore Before { get; set; }
        public class SinkBaiLianParametersBefore : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public object Context { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public object Extend { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOffset Offset { get; set; }
        public class SinkBaiLianParametersOffset : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Op")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOp Op { get; set; }
        public class SinkBaiLianParametersOp : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Partition")]
        [Validation(Required=false)]
        public SinkBaiLianParametersPartition Partition { get; set; }
        public class SinkBaiLianParametersPartition : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>${partition}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-a1b2c3d4e5f6g7h8</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
