// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public CreateSampleResponseBodyResultObject ResultObject { get; set; }
        public class CreateSampleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The number of tainted groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("communityCount")]
            [Validation(Required=false)]
            public int? CommunityCount { get; set; }

            /// <summary>
            /// <para>The number of failed data samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The recall probability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.5%</para>
            /// </summary>
            [NameInMap("recallProbability")]
            [Validation(Required=false)]
            public string RecallProbability { get; set; }

            /// <summary>
            /// <para>The risk density.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5%</para>
            /// </summary>
            [NameInMap("riskDensity")]
            [Validation(Required=false)]
            public string RiskDensity { get; set; }

            /// <summary>
            /// <para>The number of data samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("sampleCount")]
            [Validation(Required=false)]
            public int? SampleCount { get; set; }

            /// <summary>
            /// <para>The number of successful data samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

        }

    }

}
