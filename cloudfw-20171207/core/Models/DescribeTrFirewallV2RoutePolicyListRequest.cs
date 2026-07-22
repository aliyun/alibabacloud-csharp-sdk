// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallV2RoutePolicyListRequest : TeaModel {
        /// <summary>
        /// <para>The page number in a paged query. Default value: 1. For more information about paging, see the corresponding parameter descriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>FirewallId is required. If this parameter is not specified, the ErrorParameters (400) error is returned. You can call DescribeTrFirewallsV2List to obtain the FirewallId. Prerequisites: CEN Enterprise Edition with a transit router and VPC mount are configured, and the FirewallId is obtained by calling DescribeTrFirewallsV2List.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-d5ba592ac6c84aff****</para>
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
        /// <para>The maximum number of entries per page in a paged query. Default value: 10. For more information about paging, see the corresponding parameter descriptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the firewall routing policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-7b66257c14e141fb****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
