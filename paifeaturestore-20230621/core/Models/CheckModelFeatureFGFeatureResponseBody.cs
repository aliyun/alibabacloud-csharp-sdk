// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CheckModelFeatureFGFeatureResponseBody : TeaModel {
        [NameInMap("FGCheckResults")]
        [Validation(Required=false)]
        public List<CheckModelFeatureFGFeatureResponseBodyFGCheckResults> FGCheckResults { get; set; }
        public class CheckModelFeatureFGFeatureResponseBodyFGCheckResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>f1[1]: these lookup_features\&quot;s LookupValueFeature(key) not exist in model features</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SeqSubEx</para>
            /// </summary>
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ED4DEA2F-F216-57F0-AE28-08D791233280</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
