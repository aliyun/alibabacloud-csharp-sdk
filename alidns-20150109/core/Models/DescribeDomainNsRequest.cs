// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainNsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt; You can call the <a href="https://help.aliyun.com/document_detail/29751.html">DescribeDomains</a> operation to obtain this value.
        /// &lt;props=&quot;intl&quot;&gt;You can call the <a href="https://www.alibabacloud.com/help/en/dns/latest/api-alidns-2015-01-09-describedomains">DescribeDomains</a> operation to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
        /// <para>zh: Chinese<br>
        /// en: English<br></para>
        /// <para>Default value: <b>zh</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
