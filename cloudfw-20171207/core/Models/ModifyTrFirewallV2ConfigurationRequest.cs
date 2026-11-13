// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2ConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the VPC firewall instance. You can obtain the ID by calling DescribeTrFirewallsV2List.</para>
        /// <remarks>
        /// <para>Note: FirewallId and FirewallName are jointly required. You must specify both parameters. If either parameter is missing, the API operation returns a 400 error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-bcdf89d405ce4bd2****</para>
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// <para>The name of the VPC firewall instance.</para>
        /// <remarks>
        /// <para>Note: FirewallId and FirewallName are jointly required. You must specify both parameters. If either parameter is missing, the API operation returns a 400 error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall</para>
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

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
