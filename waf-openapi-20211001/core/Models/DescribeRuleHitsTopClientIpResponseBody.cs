// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopClientIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F0F9AD6-62E2-50BB-A3E5-30FFB9410262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the top 10 IP addresses from which attacks are initiated.</para>
        /// </summary>
        [NameInMap("RuleHitsTopClientIp")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp> RuleHitsTopClientIp { get; set; }
        public class DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp : TeaModel {
            /// <summary>
            /// <para>The IP address of the service client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.3.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The number of attacks that are initiated from the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>531</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
