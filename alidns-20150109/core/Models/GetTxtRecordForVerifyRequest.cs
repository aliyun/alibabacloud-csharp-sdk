// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetTxtRecordForVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The domain name. The <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a> operation returns a list of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The purpose of the TXT record verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ADD_SUB_DOMAIN: Add a subdomain for verification.</para>
        /// </description></item>
        /// <item><description><para>RETRIEVAL: Other verifications.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD_SUB_DOMAIN</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
