// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSubDomainRecordsRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The resolution line.
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **500**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The subdomain. For example, assume that the SubDomain parameter is set to a.www.example.com.
        /// 
        /// If the DomainName parameter is empty, the DNS records of the subdomain whose domain name is example.com and hostname is "a.www" are queried.
        /// 
        /// If the DomainName parameter is set to www.example.com, the DNS records of the subdomain whose domain name is www.example.com and hostname is "a" are queried.
        /// 
        /// If the DomainName parameter is set to a.www.example.com, the DNS records of the subdomain whose domain name is a.www.example.com and hostname is "@" are queried.
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// The type of DNS records to query. If you do not specify this parameter, all types of DNS records corresponding to the subdomain are returned.
        /// 
        /// DNS record types include **A, MX, CNAME, TXT, REDIRECT_URL, FORWORD_URL, NS, AAAA, and SRV**. The value is not case-sensitive.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
