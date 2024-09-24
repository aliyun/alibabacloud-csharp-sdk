// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBruteForceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of IP address blocking policies.</para>
        /// </summary>
        [NameInMap("BruteForceSummary")]
        [Validation(Required=false)]
        public DescribeBruteForceSummaryResponseBodyBruteForceSummary BruteForceSummary { get; set; }
        public class DescribeBruteForceSummaryResponseBodyBruteForceSummary : TeaModel {
            /// <summary>
            /// <para>The number of anti-brute force IP blocking policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("AllStrategyCount")]
            [Validation(Required=false)]
            public int? AllStrategyCount { get; set; }

            /// <summary>
            /// <para>The number of defense policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AntiBruteForceRuleCount")]
            [Validation(Required=false)]
            public string AntiBruteForceRuleCount { get; set; }

            /// <summary>
            /// <para>The number of custom blocking rules that are in effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CustomEffectiveCount")]
            [Validation(Required=false)]
            public string CustomEffectiveCount { get; set; }

            /// <summary>
            /// <para>The number of custom blocking rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19730</para>
            /// </summary>
            [NameInMap("CustomRecordCount")]
            [Validation(Required=false)]
            public string CustomRecordCount { get; set; }

            /// <summary>
            /// <para>The number of anti-brute force IP blocking policies enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public int? EffectiveCount { get; set; }

            /// <summary>
            /// <para>The number of system blocking rules that are in effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SystemEffectiveCount")]
            [Validation(Required=false)]
            public string SystemEffectiveCount { get; set; }

            /// <summary>
            /// <para>The number of system blocking rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SystemRecordCount")]
            [Validation(Required=false)]
            public string SystemRecordCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE60EAE3-ABD0-897C-B0F16CAC6C7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
