// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowTopResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F0E0B9A-B518-5C6D-BEFC-A373DDE4F652</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the top 10 protected objects that receive requests.</para>
        /// </summary>
        [NameInMap("RuleHitsTopResource")]
        [Validation(Required=false)]
        public List<DescribeFlowTopResourceResponseBodyRuleHitsTopResource> RuleHitsTopResource { get; set; }
        public class DescribeFlowTopResourceResponseBodyRuleHitsTopResource : TeaModel {
            /// <summary>
            /// <para>The total number of requests received by the protected object in a specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181174784</para>
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
