// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDNSRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cnameMatched</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>vipMatched</b>: A record.</para>
        /// </description></item>
        /// <item><description><para><b>wafVip</b>: The VIP of another WAF is used.</para>
        /// </description></item>
        /// <item><description><para><b>unRecord</b>: No DNS resolution is configured.</para>
        /// </description></item>
        /// <item><description><para><b>unUsed</b>: Traffic does not pass through WAF.</para>
        /// </description></item>
        /// <item><description><para><b>checkTimeout</b>: The detection timed out.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cnameMatched</para>
        /// </summary>
        [NameInMap("DNSStatus")]
        [Validation(Required=false)]
        public string DNSStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
