// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSubDomainRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
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
        /// <para>The DNS resolution line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>For example, if you set SubDomain to a.www\.example.com:</para>
        /// <para>If you do not specify DomainName, the system queries the DNS records for the hostname a.www of the domain name example.com.</para>
        /// <para>If you set DomainName to www\.example.com, the system queries the DNS records for the hostname a of the domain name www\.example.com.</para>
        /// <para>If you set DomainName to &quot;a.www\.example.com&quot;, the system queries the DNS records for the hostname @ of the domain name a.www\.example.com.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.<a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. If you do not specify this parameter, all types of DNS records for the subdomain are returned.</para>
        /// <para>The record types are case-insensitive and include the following: <b>A, MX, CNAME, TXT, REDIRECT_URL, FORWARD_URL, NS, AAAA, and SRV</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MX</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.0</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
