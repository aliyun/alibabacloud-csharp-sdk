// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The method that is used to modify the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the original IP address whitelist.</description></item>
        /// <item><description><b>Append</b>: appends data to the IP address whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the IP address whitelist.</description></item>
        /// </list>
        /// <para>Default value: <b>Cover</b>.</para>
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
        /// <para>The attribute of the IP address whitelist. It can contain a maximum of 120 characters in length and can contain uppercase letters, lowercase letters, and digits.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SecurityIpGroupAttribute")]
        [Validation(Required=false)]
        public string SecurityIpGroupAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist that you want to modify. Default value: <b>default</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowserver</para>
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// <para>The IP addresses in the IP address whitelist. Separate multiple IP addresses with commas (,). You can add a maximum of 1,000 different IP addresses to the IP address whitelist. The entries in the IP address whitelist must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses, such as 127.0.0.1.</description></item>
        /// <item><description>CIDR blocks, such as 127.0.0.1/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1/24,127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
