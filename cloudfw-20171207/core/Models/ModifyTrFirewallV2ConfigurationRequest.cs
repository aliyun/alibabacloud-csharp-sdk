// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2ConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>FirewallId and FirewallName are jointly required. If both are not provided, an ErrorParameters(400) error is returned. You can call DescribeTrFirewallsV2List to obtain the FirewallId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-bcdf89d405ce4bd2****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The instance name of the virtual private cloud (VPC) firewall.</para>
        /// <remarks>
        /// <para>FirewallId and FirewallName are jointly required. If both are not provided, an ErrorParameters(400) error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
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
