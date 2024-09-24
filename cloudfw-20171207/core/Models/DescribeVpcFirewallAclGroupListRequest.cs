// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether VPC firewalls are configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>notconfigured</b>: VPC firewalls are not configured.</description></item>
        /// <item><description><b>configured</b>: VPC firewalls are configured.</description></item>
        /// <item><description>If you do not specify this parameter, the access control policies of all VPC firewalls are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>configured</para>
        /// </summary>
        [NameInMap("FirewallConfigureStatus")]
        [Validation(Required=false)]
        public string FirewallConfigureStatus { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
