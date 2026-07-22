// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2DetailRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>FirewallId is required. If this parameter is not specified, ErrorParameters(400) is returned. You can call DescribeTrFirewallsV2List to query existing FirewallId values. If no VPC firewall exists, create a CEN instance and a transit router first, and then call CreateTrFirewallV2 to obtain a FirewallId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-a5a6b89f46764928****</para>
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

    }

}
