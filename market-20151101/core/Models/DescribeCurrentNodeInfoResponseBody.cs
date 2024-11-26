// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCurrentNodeInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00eb4de1-6cff-4f56-833e-7b1e070e398d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCurrentNodeInfoResponseBodyResult Result { get; set; }
        public class DescribeCurrentNodeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowRollbackNode")]
            [Validation(Required=false)]
            public bool? AllowRollbackNode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoFinishNode")]
            [Validation(Required=false)]
            public bool? AutoFinishNode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1588920725000</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1588920725000</para>
            /// </summary>
            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1588834325000</para>
            /// </summary>
            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedAttachment")]
            [Validation(Required=false)]
            public bool? NeedAttachment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8473</para>
            /// </summary>
            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8472</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Starting</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Provider</para>
            /// </summary>
            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ParentNodeId")]
            [Validation(Required=false)]
            public long? ParentNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8471</para>
            /// </summary>
            [NameInMap("PreviousNodeId")]
            [Validation(Required=false)]
            public long? PreviousNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("StepNo")]
            [Validation(Required=false)]
            public int? StepNo { get; set; }

            [NameInMap("TemplateForm")]
            [Validation(Required=false)]
            public string TemplateForm { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
