// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The edition of WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdnwaf_afterpay</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The status of WAF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// <para>The time when WAF was enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-26T16:00:00Z</para>
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// <para>The metering method for requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_waf_req</para>
        /// </summary>
        [NameInMap("RequestBillingType")]
        [Validation(Required=false)]
        public string RequestBillingType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A95CA90-E0F2-1BF6-99E0-8C1510CAF649</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metering method for rules. You are charged for the number of SeCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_waf_rule</para>
        /// </summary>
        [NameInMap("RuleBillingType")]
        [Validation(Required=false)]
        public string RuleBillingType { get; set; }

        /// <summary>
        /// <para>The status of WAF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal</description></item>
        /// <item><description>WaitForExpire</description></item>
        /// <item><description>Expired</description></item>
        /// <item><description>Released</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
