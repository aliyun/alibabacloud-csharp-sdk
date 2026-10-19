// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The modification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): overwrites the original whitelist.</description></item>
        /// <item><description><b>Append</b>: appends IP addresses to the whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Append</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The attribute of the IP whitelist group. This parameter is empty by default. The console does not display the whitelist group if the value is set to <b>hidden</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("SecurityIpGroupAttribute")]
        [Validation(Required=false)]
        public string SecurityIpGroupAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group.
        /// <warning>You cannot modify a system-generated whitelist group. If you do not specify this parameter, the whitelist of the default group is modified.</warning></para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// <para>The IP addresses in the IP whitelist group. You can add up to 1,000 IP addresses. Separate multiple IP addresses with commas (,). The following formats are supported: 0.0.0.0/0,10.23.12.24 or 10.23.12.24/24 (CIDR notation, where /24 specifies the prefix length, which ranges from 1 to 32).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.64.<em><b>.0/24,10.101.11.</b></em></para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
