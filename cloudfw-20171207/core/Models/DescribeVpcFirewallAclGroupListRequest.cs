// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page returned for a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The configuration status of the VPC firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>configured</b>: The virtual private cloud (VPC) firewalls at the border are configured (that is, the firewalls are created).</description></item>
        /// <item><description>Empty: queries the access control policy of all virtual private cloud (VPC) firewalls at the border.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>configured</para>
        /// </summary>
        [NameInMap("FirewallConfigureStatus")]
        [Validation(Required=false)]
        public string FirewallConfigureStatus { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls at the border.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-5b202e7f0be64611****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
