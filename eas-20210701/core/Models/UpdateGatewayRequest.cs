// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable public network access. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableInternet")]
        [Validation(Required=false)]
        public bool? EnableInternet { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable intranet access. The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntranet")]
        [Validation(Required=false)]
        public bool? EnableIntranet { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable HTTP to HTTPS redirection. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSLRedirection")]
        [Validation(Required=false)]
        public bool? EnableSSLRedirection { get; set; }

        /// <summary>
        /// <para>The instance type of the private gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2c4g</para>
        /// </description></item>
        /// <item><description><para>4c8g</para>
        /// </description></item>
        /// <item><description><para>8c16g</para>
        /// </description></item>
        /// <item><description><para>16c32g</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2c4g</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the gateway is the default private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The alias of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygateway1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of private gateway nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The list of vSwitches. This parameter applies only to application-type dedicated gateways.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The VPC where the gateway resides. This parameter applies only to application-type dedicated gateways.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1jkde2******3mew</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
