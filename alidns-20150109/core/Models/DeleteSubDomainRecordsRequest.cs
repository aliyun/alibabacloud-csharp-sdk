// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteSubDomainRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt;You can call <a href="https://help.aliyun.com/en/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a> to obtain the domain name.
        /// &lt;props=&quot;intl&quot;&gt;You can call <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a> to obtain the domain name.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The host record.</para>
        /// <para>To resolve @.example.com, set the host record to \&quot;@\&quot; instead of leaving it empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. If you do not specify this parameter, all types of DNS records for the subdomain are deleted.</para>
        /// <para>Valid values (case-insensitive): A, MX, CNAME, TXT, REDIRECT_URL, FORWARD_URL, NS, AAAA, and <b>SRV</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
