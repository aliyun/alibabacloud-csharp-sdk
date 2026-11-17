// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of analyzed requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("AnalyzedRequestCount")]
        [Validation(Required=false)]
        public long? AnalyzedRequestCount { get; set; }

        /// <summary>
        /// <para>The number of events within the specified time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventCount")]
        [Validation(Required=false)]
        public long? EventCount { get; set; }

        /// <summary>
        /// <para>The number of events categorized by handling status within the specified time range.</para>
        /// </summary>
        [NameInMap("HandleStatusCounts")]
        [Validation(Required=false)]
        public DescribeAiEngineOverviewResponseBodyHandleStatusCounts HandleStatusCounts { get; set; }
        public class DescribeAiEngineOverviewResponseBodyHandleStatusCounts : TeaModel {
            /// <summary>
            /// <para>The number of handled events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Handled")]
            [Validation(Required=false)]
            public long? Handled { get; set; }

            /// <summary>
            /// <para>The number of events that are being handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Handling")]
            [Validation(Required=false)]
            public long? Handling { get; set; }

            /// <summary>
            /// <para>The number of unhandled events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Unhandled")]
            [Validation(Required=false)]
            public long? Unhandled { get; set; }

        }

        /// <summary>
        /// <para>The number of protection groups for which AI Engine is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProtectedGroupCount")]
        [Validation(Required=false)]
        public int? ProtectedGroupCount { get; set; }

        /// <summary>
        /// <para>The number of protected resources for which AI Engine is enabled. This number does not include protected resources in protection groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("ProtectedResourceCount")]
        [Validation(Required=false)]
        public int? ProtectedResourceCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1CEE****-019A-8B44-255****F9C2C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of events categorized by risk level within the specified time range.</para>
        /// </summary>
        [NameInMap("RiskCounts")]
        [Validation(Required=false)]
        public DescribeAiEngineOverviewResponseBodyRiskCounts RiskCounts { get; set; }
        public class DescribeAiEngineOverviewResponseBodyRiskCounts : TeaModel {
            /// <summary>
            /// <para>The number of critical events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public long? Critical { get; set; }

            /// <summary>
            /// <para>The number of high-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            /// <summary>
            /// <para>The number of low-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            /// <summary>
            /// <para>The number of medium-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

        }

    }

}
