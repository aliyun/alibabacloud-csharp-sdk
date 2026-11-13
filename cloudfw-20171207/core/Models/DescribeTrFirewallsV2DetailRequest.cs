// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2DetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the VPC firewall instance. This parameter is required. If this parameter is not specified, the ErrorMissingFirewallId (-360444, firewall id is required) error is returned.</para>
        /// <remarks>
        /// <para>You can call DescribeTrFirewallsV2List to query existing FirewallIds (in the format of vfw-tr-*). If the firewall has not been created, you must first create an Enterprise Edition transit router in CEN and then call CreateTrFirewallV2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-a5a6b89f46764928****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
