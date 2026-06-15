// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CheckModelFeatureFGFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The FG configuration check results.</para>
        /// </summary>
        [NameInMap("FGCheckResults")]
        [Validation(Required=false)]
        public List<CheckModelFeatureFGFeatureResponseBodyFGCheckResults> FGCheckResults { get; set; }
        public class CheckModelFeatureFGFeatureResponseBodyFGCheckResults : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f1[1]: these lookup_features\&quot;s LookupValueFeature(key) not exist in model features</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The rule code for the check.</para>
            /// <list type="bullet">
            /// <item><description><para>SeqSubEx—Are the sub-features of sequence features in the FG present in the model feature?</para>
            /// </description></item>
            /// <item><description><para>LookupKeyEx—Does the lookup key feature of query features exist in the model feature?</para>
            /// </description></item>
            /// <item><description><para>FGSetEx—Are all FG features present in the model feature?</para>
            /// </description></item>
            /// <item><description><para>ModelSetEx—Are all model feature features present in the FG?</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SeqSubEx</para>
            /// </summary>
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// <para>Whether the rule passes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED4DEA2F-F216-57F0-AE28-08D791233280</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
