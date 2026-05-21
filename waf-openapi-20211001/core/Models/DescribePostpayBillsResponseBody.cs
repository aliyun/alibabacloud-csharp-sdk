// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePostpayBillsResponseBody : TeaModel {
        [NameInMap("BillDetail")]
        [Validation(Required=false)]
        public List<DescribePostpayBillsResponseBodyBillDetail> BillDetail { get; set; }
        public class DescribePostpayBillsResponseBodyBillDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;aiWhiteListTemplateCount\&quot;:4,\&quot;apisecResourceCount\&quot;:2,\&quot;botAppTemplateCount\&quot;:1,\&quot;botWebTemplateCount\&quot;:4,\&quot;ccRuleCount\&quot;:1,\&quot;customAclAdvanceRuleCount\&quot;:4,\&quot;customResponseRuleCount\&quot;:5,\&quot;dlpRuleCount\&quot;:1,\&quot;gslb\&quot;:1,\&quot;instanceFee\&quot;:1,\&quot;ipv6\&quot;:1,\&quot;nonPort\&quot;:1,\&quot;qps\&quot;:0,\&quot;regionBlockRuleCount\&quot;:1,\&quot;threatIntelligenceTemplateCount\&quot;:1,\&quot;wafBaseTemplateCount\&quot;:4}</para>
            /// </summary>
            [NameInMap("ChargeData")]
            [Validation(Required=false)]
            public string ChargeData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1779123599</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FunctionCu")]
            [Validation(Required=false)]
            public string FunctionCu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1779120000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("TrafficCu")]
            [Validation(Required=false)]
            public string TrafficCu { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FBBDE11-C35F-531B-96BA-64CA****C875</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
