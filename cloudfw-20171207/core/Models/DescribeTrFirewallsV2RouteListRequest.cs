// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2RouteListRequest : TeaModel {
        /// <summary>
        /// <para>The page number in a paging query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewalls.</para>
        /// <remarks>
        /// <para>FirewallId is required. If it is not specified, ErrorParameters(400) is returned. TrFirewallRoutePolicyId must be used together with FirewallId. If TrFirewallRoutePolicyId is specified without FirewallId, ErrorParameters(400) is returned. If the value is invalid or does not exist, ErrorTrFirewallPolicyNotFound is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-8bcfa0f2f12d411e****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
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
        /// <para>The maximum number of entries per page in a paging query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the firewall routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-7d5c672e37ee4175****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
