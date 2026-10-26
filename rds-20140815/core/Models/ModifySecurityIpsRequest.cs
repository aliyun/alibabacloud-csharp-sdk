// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the whitelist group.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the group is a regular group. This is the default value.</description></item>
        /// <item><description>If you set this parameter to <c>hidden</c>, the group is a hidden group that is automatically created by the system for services such as DMS, DTS, and DAS. Hidden groups are not displayed in the console. If you delete or modify a hidden group, services such as DMS, DTS, and DAS cannot access the ApsaraDB RDS instance. Proceed with caution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist group to be modified. Default value: Default. If the specified group does not exist, the system automatically creates the group.</para>
        /// <remarks>
        /// <para>You can create up to 200 whitelist groups for a single instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp18n0c8zt45****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The read-only instances to which the whitelist is synchronized.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances that have read-only instances.</description></item>
        /// <item><description>If multiple read-only instances exist, separate their IDs with commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pgr-bp17yuz4dn3d****,pgr-bp1vn2ph54u1****</para>
        /// </summary>
        [NameInMap("FreshWhiteListReadins")]
        [Validation(Required=false)]
        public string FreshWhiteListReadins { get; set; }

        /// <summary>
        /// <para>The modification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the original IP address whitelist with the IP addresses specified by the <b>SecurityIps</b> parameter. This is the default value.</description></item>
        /// <item><description><b>Append</b>: appends the IP addresses specified by the <b>SecurityIps</b> parameter to the original IP address whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the IP addresses specified by the <b>SecurityIps</b> parameter from the original IP address whitelist. You must retain at least one IP address in the whitelist.</description></item>
        /// </list>
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
        /// <para>The type of the IP address. Set the value to IPv4. IPv6 is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. Before you modify the IP address whitelist, call the <a href="https://help.aliyun.com/document_detail/610518.html">DescribeDBInstanceIPArrayList</a> operation to query the existing IP address whitelist of the instance.</para>
        /// <details>
        /// <summary>Configuration rules</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>You can enter IP addresses (such as 10.23.XX.XX) or CIDR blocks (such as 10.23.XX.XX/24).</para>
        /// </description></item>
        /// <item><description><para>Separate multiple IP addresses or CIDR blocks with commas (,). Do not add spaces before or after the commas.</para>
        /// </description></item>
        /// <item><description><para>You can add up to 1,000 IP addresses or CIDR blocks to the whitelist of a single instance. If you have a large number of IP addresses, we recommend that you merge them into CIDR blocks, such as 10.23.XX.XX/24.</para>
        /// </details></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.XX.XX</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// <para>The network type of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIX</b>: the general mode. This is the default value.</description></item>
        /// <item><description><b>Classic</b>: the classic network in the enhanced whitelist mode.</description></item>
        /// <item><description><b>VPC</b>: the VPC in the enhanced whitelist mode.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for PostgreSQL instances with cloud disks, the network type is fixed to the general mode (MIX). If you configure another mode, the system automatically changes it to the general mode.</description></item>
        /// <item><description>The enhanced whitelist mode is supported only by ApsaraDB RDS for MySQL 5.1, 5.5, 5.6, and 5.7 instances with premium local SSDs, and ApsaraDB RDS for PostgreSQL 9.4 and 10 instances with premium local SSDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MIX</para>
        /// </summary>
        [NameInMap("WhitelistNetworkType")]
        [Validation(Required=false)]
        public string WhitelistNetworkType { get; set; }

    }

}
