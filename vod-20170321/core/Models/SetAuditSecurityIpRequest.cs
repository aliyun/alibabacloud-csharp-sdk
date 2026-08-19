// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetAuditSecurityIpRequest : TeaModel {
        /// <summary>
        /// <para>The list of security IP addresses for review. Each group supports a maximum of 100 IP addresses. Separate multiple IP addresses with commas (,). The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>Exact IP address: 192.168.0.1</description></item>
        /// <item><description>CIDR block: 192.168.0.1/24 (Classless Inter-Domain Routing. /24 specifies the length of the prefix in the address. Valid values: <c>[1,32]</c>.)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

        /// <summary>
        /// <para>The operation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Append</b>: default value. Appends IP addresses to the IP address whitelist.</description></item>
        /// <item><description><b>Cover</b>: overwrites the existing IP address whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes IP addresses from the IP address whitelist.<remarks>
        /// <para>If the specified value is not within the valid values, the default value (Append) is used.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("OperateMode")]
        [Validation(Required=false)]
        public string OperateMode { get; set; }

        /// <summary>
        /// <para>The name of the security group for review. Default value: <b>Default</b>. A maximum of 10 security groups are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
