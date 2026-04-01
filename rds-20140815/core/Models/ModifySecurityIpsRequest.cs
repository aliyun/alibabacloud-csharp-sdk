// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP address whitelist. By default, this parameter is empty.</para>
        /// <remarks>
        /// <para>The IP address whitelists that have the hidden attribute are not displayed in the ApsaraDB RDS console. These IP address whitelists are used to access Alibaba Cloud services, such as Data Transmission Service (DTS).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist that you want to modify. Default value: <b>Default</b>.</para>
        /// <remarks>
        /// <para>A maximum of 200 IP address whitelists can be configured for each instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp18n0c8zt45****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The read-only instances to which you want to synchronize the IP address whitelist.</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to ApsaraDB RDS for PostgreSQL instances.</description></item>
        /// <item><description>If the instance is attached with a read-only instance, you can use this parameter to synchronize the IP address whitelist to the read-only instance. If the instance is attached with multiple read-only instances, separate the read-only instances with commas (,).</description></item>
        /// <item><description>If the instance is not attached with a read-only instance, leave this parameter empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pgr-bp17yuz4dn3d****,pgr-bp1vn2ph54u1****</para>
        /// </summary>
        [NameInMap("FreshWhiteListReadins")]
        [Validation(Required=false)]
        public string FreshWhiteListReadins { get; set; }

        /// <summary>
        /// <para>The method that is used to modify the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: Use the IP addresses and CIDR blocks that are specified in the <b>SecurityIps</b> parameter to overwrite the existing IP addresses and CIDR blocks in the IP address whitelist.</description></item>
        /// <item><description><b>Append</b>: Add the IP addresses and CIDR blocks that are specified in the <b>SecurityIps</b> parameter to the IP address whitelist.</description></item>
        /// <item><description><b>Delete</b>: Delete the IP addresses and CIDR blocks that are specified in the <b>SecurityIps</b> parameter from the IP address whitelist. You must retain at least one IP address or CIDR block.</description></item>
        /// </list>
        /// <para>Default value: <b>Cover</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IP address type. The value is fixed as IPv4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// <para>The IP addresses in an IP address whitelist. Separate multiple IP addresses with commas (,). Each IP address in the IP address whitelist must be unique. The entries in the IP address whitelist must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses, such as 10.23.XX.XX.</description></item>
        /// <item><description>CIDR blocks, such as 10.23.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.</description></item>
        /// </list>
        /// <remarks>
        /// <para>A maximum of 1,000 IP addresses or CIDR blocks can be added for each instance. If you want to add a large number of IP addresses, we recommend that you merge them into CIDR blocks, such as 10.23.XX.XX/24.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.XX.XX</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// <para>The network type of the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b>: classic network in enhanced whitelist mode</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC) network type in enhanced whitelist mode.</description></item>
        /// <item><description><b>MIX</b>: standard whitelist mode</description></item>
        /// </list>
        /// <para>Default value: <b>MIX</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>In standard whitelist mode, IP addresses and CIDR blocks are added only to the default IP address whitelist. In enhanced whitelist mode, IP addresses and CIDR blocks are added to the IP address whitelists of the classic network type and the VPC network type.</para>
        /// </description></item>
        /// <item><description><para>If your RDS instance runs PostgreSQL and uses cloud disks, set this parameter to MIX. If you set it to another value, the system automatically changes the value to MIX.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
        /// </summary>
        [NameInMap("WhitelistNetworkType")]
        [Validation(Required=false)]
        public string WhitelistNetworkType { get; set; }

    }

}
