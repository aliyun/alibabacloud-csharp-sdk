// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetAuditSecurityIpRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses that you want to add to the review security group. You can add a maximum of 100 IP addresses to a review security group. Separate multiple IP addresses with commas (,). You can add IP addresses in the following formats to review security groups:</para>
        /// <list type="bullet">
        /// <item><description>IP address: 192.168.0.1</description></item>
        /// <item><description>CIDR block: 192.168.0.1/24. /24 indicates that the prefix of the CIDR block is 24 bits in length. You can replace 24 with a value that ranges <c>from 1 to 32</c>.</description></item>
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
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Append</b> (default): adds the IP addresses to the original whitelist.</description></item>
        /// <item><description><b>Cover</b>: overwrites the original whitelist.</description></item>
        /// <item><description><b>Delete</b>: removes the IP addresses from the original whitelist.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the value that you specify is invalid, the default value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("OperateMode")]
        [Validation(Required=false)]
        public string OperateMode { get; set; }

        /// <summary>
        /// <para>The name of the review security group. Default value: <b>Default</b>. You can specify a maximum of 10 review security groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
