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
        /// <item><description>(Default) If you do not specify this parameter, the group is a common group.</description></item>
        /// <item><description>If you set this parameter to <c>hidden</c>, the group is a system default group used by services such as DMS, DTS, and DAS. These groups are not displayed in the console. Deleting or modifying these groups may prevent DMS, DTS, and DAS from accessing ApsaraDB RDS. Proceed with caution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the whitelist group to modify. Default value: Default. If the specified group does not exist, a new group is automatically created.</para>
        /// <remarks>
        /// <para>Each instance supports up to 200 whitelist groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// <para>The target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp18n0c8zt45****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of read-only instances to which the whitelist is synchronized.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances that have read-only instances.</description></item>
        /// <item><description>Separate multiple read-only instances with commas (,).</description></item>
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
        /// <item><description><b>Cover</b> (default): overwrites the original IP whitelist with the value of the <b>SecurityIps</b> parameter.</description></item>
        /// <item><description><b>Append</b>: appends the IP addresses specified in the <b>SecurityIps</b> parameter to the original IP whitelist.</description></item>
        /// <item><description><b>Delete</b>: removes the IP addresses specified in the <b>SecurityIps</b> parameter from the original IP whitelist. At least one IP address must be retained.</description></item>
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
        /// <para>The type of IP address. The value is fixed as IPv4. IPv6 is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// <para>The IP whitelist. Before you modify the IP whitelist, call the <a href="https://help.aliyun.com/document_detail/610518.html">DescribeDBInstanceIPArrayList</a> operation to query the existing IP whitelist information of the instance.</para>
        /// <details>
        /// <summary>Configuration rules</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>IP addresses (such as 10.23.XX.XX) and CIDR blocks (such as 10.23.XX.XX/24) are supported.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple IP addresses or CIDR blocks with commas (,). No spaces are allowed before or after the commas.</para>
        /// </description></item>
        /// <item><description><para>Each instance can contain up to 1,000 IP addresses or CIDR blocks. If you have a large number of IP addresses, merge them into CIDR blocks, such as 10.23.XX.XX/24.</para>
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
        /// <item><description><b>MIX</b> (default): general mode.</description></item>
        /// <item><description><b>Classic</b>: the classic network in enhanced whitelist mode.</description></item>
        /// <item><description><b>VPC</b>: the virtual private cloud (VPC) in enhanced whitelist mode.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for PostgreSQL instances with cloud disks use only the general mode (MIX). If you set this parameter to another mode, the value is automatically converted to MIX.</description></item>
        /// <item><description>Only ApsaraDB RDS for MySQL 5.1, 5.5, 5.6, and 5.7 instances with Premium Local SSDs and ApsaraDB RDS for PostgreSQL 9.4 and 10 instances with Premium Local SSDs support the enhanced whitelist mode.</description></item>
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
