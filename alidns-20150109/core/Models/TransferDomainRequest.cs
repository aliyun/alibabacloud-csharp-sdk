// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class TransferDomainRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to transfer. Separate multiple domain names with commas. Only domain names registered with Alibaba Cloud are supported. &lt;props=&quot;china&quot;&gt;To get your domain names, call <a href="https://help.aliyun.com/en/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a>.
        /// &lt;props=&quot;intl&quot;&gt;To get your domain names, call <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.net</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The remarks for the transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test domain transfer</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the target user account. The specified domain names and their DNS records are transferred to this account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12*******</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

    }

}
