// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPolicyValidDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the Web Application Firewall (WAF) protection policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waf_group: basic web protection</description></item>
        /// <item><description>custom_acl: custom protection</description></item>
        /// <item><description>whitelist: IP address whitelist</description></item>
        /// <item><description>ip_blacklist: IP address blacklist</description></item>
        /// <item><description>region_block: region blacklist</description></item>
        /// <item><description>bot: bot management</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_acl</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The protected domain name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainNameLike")]
        [Validation(Required=false)]
        public string DomainNameLike { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Valid values: <b>1</b> to <b>100000</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of domain names to return on each page. Valid values: an integer from <b>1</b> to <b>500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
