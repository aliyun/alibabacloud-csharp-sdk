// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ManualModerationResultResponseBodyData Data { get; set; }
        public class ManualModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value of dataId passed in the API request. This field is not returned if dataId was not specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The detailed label results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ManualModerationResultResponseBodyDataResult> Result { get; set; }
            public class ManualModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未检测出风险</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The risk label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The number of reviews.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReviewCount")]
            [Validation(Required=false)]
            public string ReviewCount { get; set; }

            /// <summary>
            /// <para>The risk level, returned based on the configured high and low risk scores. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>high: High risk.</para>
            /// </description></item>
            /// <item><description><para>low: Low risk.</para>
            /// </description></item>
            /// <item><description><para>none: No risk detected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
