// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// <item><description>It cannot start with http:// or https://.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first vswitch</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6 for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables IPv6. The VPC to which the vSwitch belongs must have IPv6 enabled, and you must also specify Ipv6CidrBlock to assign an IPv6 CIDR block to the vSwitch.</description></item>
        /// <item><description>false (default): disables IPv6. Before you disable IPv6 for the vSwitch, make sure that no IPv6 addresses are in use, and do not specify Ipv6CidrBlock at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the vSwitch.</para>
        /// <remarks>
        /// <para>You can specify this parameter to assign an IPv6 CIDR block to the vSwitch only when IPv6 is enabled for the VPC to which the vSwitch belongs. After the IPv6 CIDR block is assigned, it cannot be changed. Make sure that the IPv6 CIDR block does not overlap with the CIDR blocks of other vSwitches in the same VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/110</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The vSwitch name.</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>It must start with a letter or a Chinese character and cannot start with http:// or https://.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test-switch</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
