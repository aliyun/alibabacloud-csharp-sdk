// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. Example: qwertyui1234567</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwertyui1234567</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>Specifies whether to perform a dry run. Valid values:
        /// true: performs a dry run without calling the operation. The system checks the request parameters, request format, service limits, and available resources. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.
        /// false (default): sends the request. If the check succeeds, the operation is performed.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The modification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: Overwrites the original whitelist.</description></item>
        /// <item><description><b>Append</b>: Appends to the whitelist. An error is returned if duplicate IP addresses exist.</description></item>
        /// <item><description><b>Extend</b>: Appends to the whitelist. Duplicate IP addresses are merged.</description></item>
        /// <item><description><b>Delete</b>: Deletes the whitelist.</description></item>
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
        /// <para>The attribute of the whitelist group. The value can contain uppercase letters, lowercase letters, and digits. The maximum length is 120 characters.</para>
        /// <para>Default value: empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SecurityIpGroupAttribute")]
        [Validation(Required=false)]
        public string SecurityIpGroupAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group to modify. Default value: <b>default</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowserver</para>
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// <para>The list of IP addresses in the IP whitelist group. Separate multiple IP addresses with commas (,). IP addresses cannot be duplicated. A maximum of 1000 IP addresses are supported. The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 127.0.0.1.</description></item>
        /// <item><description>CIDR format, such as 127.0.0.1/24 (Classless Inter-Domain Routing, where 24 indicates the length of the prefix in the address. The value ranges from 1 to 32).</description></item>
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
