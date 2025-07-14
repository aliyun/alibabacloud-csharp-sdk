// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudClusterRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hdbc-clusterrule-*******m0w</para>
        /// </summary>
        [NameInMap("ClusterRuleResourceId")]
        [Validation(Required=false)]
        public string ClusterRuleResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-*****-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
