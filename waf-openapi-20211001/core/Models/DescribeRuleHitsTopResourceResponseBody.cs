// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADA11BC7-AA95-5C31-9095-5802C02ED1DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the top 10 protected objects that trigger protection rules.</para>
        /// </summary>
        [NameInMap("RuleHitsTopResource")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopResourceResponseBodyRuleHitsTopResource> RuleHitsTopResource { get; set; }
        public class DescribeRuleHitsTopResourceResponseBodyRuleHitsTopResource : TeaModel {
            /// <summary>
            /// <para>The number of requests that match protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14219</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

    }

}
