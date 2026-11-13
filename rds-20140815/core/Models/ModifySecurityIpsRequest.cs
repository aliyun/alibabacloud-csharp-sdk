// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the batch modification mode. Valid values:</para>
        /// <para>true: enables the batch modification mode. You can modify multiple IP whitelist groups at a time based on the GroupItems parameter. In this case, the SecurityIps, DBInstanceIPArrayName, and DBInstanceIPArrayAttribute parameters for a single group do not take effect.</para>
        /// <para>false: disables the batch modification mode. You can modify a single IP whitelist group based on parameters such as SecurityIps. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BatchMode")]
        [Validation(Required=false)]
        public bool? BatchMode { get; set; }

        /// <summary>
        /// <para>The attribute of the IP whitelist group.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the group is a regular group. This is the default value.</description></item>
        /// <item><description>If you set this parameter to <c>hidden</c>, the group is a system-generated group that is used by services such as Data Management (DMS), Data Transmission Service (DTS), and Database Autonomy Service (DAS). These groups are not displayed in the console. If you delete or modify these groups, services such as DMS, DTS, and DAS cannot access the ApsaraDB RDS instance. Proceed with caution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group to be modified. Default value: Default. If the specified group does not exist, the system automatically creates the group.</para>
        /// <remarks>
        /// <para>A single instance supports up to 200 IP whitelist groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// <para>The instance ID of the target instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp18n0c8zt45****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of read-only instances to which the IP whitelist is synchronized.</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to ApsaraDB RDS for PostgreSQL instances that have read-only instances.</description></item>
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
        /// <para>The details of the IP whitelist groups. This parameter is required when BatchMode is set to true. The GroupName parameter is required and must be unique for each group. You must specify at least one of the SecurityIPList and GroupTag parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;GroupName&quot;:&quot;default&quot;,&quot;SecurityIPList&quot;:&quot;127.0.0.1&quot;},{&quot;GroupName&quot;:&quot;test&quot;,&quot;SecurityIPList&quot;:&quot;10.23.XX.XX,10.24.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("GroupItems")]
        [Validation(Required=false)]
        public List<ModifySecurityIpsRequestGroupItems> GroupItems { get; set; }
        public class ModifySecurityIpsRequestGroupItems : TeaModel {
            /// <summary>
            /// <para>The name of the IP whitelist group. This parameter is required in batch mode and must be unique within the same GroupItems list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The attribute of the IP whitelist group. If you set this parameter to hidden, the group is a system-generated group that is used by services such as DMS, DTS, and DAS. These groups are not displayed in the console. Proceed with caution. Generally, you do not need to specify this parameter. You must specify at least one of this parameter and SecurityIPList.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hidden</para>
            /// </summary>
            [NameInMap("GroupTag")]
            [Validation(Required=false)]
            public string GroupTag { get; set; }

            /// <summary>
            /// <para>The modified IP address whitelist of the group. Separate multiple IP addresses with commas (,). You must specify at least one of this parameter and GroupTag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.23.XX.XX,10.24.XX.XX</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

        }

        /// <summary>
        /// <para>The modification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the existing IP whitelist with the IP addresses specified by the <b>SecurityIps</b> parameter. This is the default value.</description></item>
        /// <item><description><b>Append</b>: appends the IP addresses specified by the <b>SecurityIps</b> parameter to the existing IP whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the IP addresses specified by the <b>SecurityIps</b> parameter from the existing IP whitelist. You must retain at least one IP address in the whitelist.</description></item>
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
        /// <para>The IP whitelist. Before you modify the IP whitelist, call the <a href="https://help.aliyun.com/document_detail/610518.html">DescribeDBInstanceIPArrayList</a> operation to query the existing IP whitelist of the instance.</para>
        /// <details>
        /// <summary>Configuration rules</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>You can enter IP addresses such as 10.23.XX.XX or CIDR blocks such as 10.23.XX.XX/24.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple IP addresses or CIDR blocks with commas (,). Do not add spaces before or after the commas.</para>
        /// </description></item>
        /// <item><description><para>You can add up to 1,000 IP addresses or CIDR blocks to the whitelist of a single instance. If you have a large number of IP addresses, we recommend that you merge them into CIDR blocks, such as 10.23.XX.XX/24.</para>
        /// </details></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.XX.XX</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// <para>The network type of the IP whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIX</b>: the standard whitelist mode. This is the default value.</description></item>
        /// <item><description><b>Classic</b>: the classic network in the enhanced whitelist mode.</description></item>
        /// <item><description><b>VPC</b>: the VPC in the enhanced whitelist mode.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for PostgreSQL instances with cloud disks, the network type is fixed to MIX. If you configure another mode, the system automatically changes it to MIX.</description></item>
        /// <item><description>The enhanced whitelist mode is supported only by ApsaraDB RDS for MySQL 5.1, 5.5, 5.6, and 5.7 instances with Premium Local SSDs, and ApsaraDB RDS for PostgreSQL 9.4 and 10 instances with Premium Local SSDs.</description></item>
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
