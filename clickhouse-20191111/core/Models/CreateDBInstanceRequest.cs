// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// <remarks>
        /// <para>This parameter applies only when <c>PayType</c> is set to <c>Prepaid</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/360339.html">DescribeBackups</a> API to query backup set IDs.</para>
        /// <remarks>
        /// <para>This parameter is required when restoring data to an ApsaraDB for ClickHouse cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b-12af23adsf</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// <para>A client token used to ensure request idempotence. The value must be a string of no more than 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The replica configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: single-replica</para>
        /// </description></item>
        /// <item><description><para><b>HighAvailability</b>: high availability (dual-replica)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// <para>The instance type.&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>For single-replica clusters, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LS20</b>: Large-storage, 20 cores, 88 GB</para>
        /// </description></item>
        /// <item><description><para><b>LS40</b>: Large-storage, 40 cores, 176 GB</para>
        /// </description></item>
        /// <item><description><para><b>LS80</b>: Large-storage, 80 cores, 352 GB</para>
        /// </description></item>
        /// <item><description><para><b>S8</b>: Standard, 8 cores, 32 GB</para>
        /// </description></item>
        /// <item><description><para><b>S16</b>: Standard, 16 cores, 64 GB</para>
        /// </description></item>
        /// <item><description><para><b>S32</b>: Standard, 32 cores, 128 GB</para>
        /// </description></item>
        /// <item><description><para><b>S64</b>: Standard, 64 cores, 256 GB</para>
        /// </description></item>
        /// <item><description><para><b>S80</b>: Standard, 80 cores, 384 GB</para>
        /// </description></item>
        /// <item><description><para><b>S104</b>: Standard, 104 cores, 384 GB</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For high availability clusters, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LC20</b>: Large-storage, 20 cores, 88 GB</para>
        /// </description></item>
        /// <item><description><para><b>LC40</b>: Large-storage, 40 cores, 176 GB</para>
        /// </description></item>
        /// <item><description><para><b>LC80</b>: Large-storage, 80 cores, 352 GB</para>
        /// </description></item>
        /// <item><description><para><b>C8</b>: Standard, 8 cores, 32 GB</para>
        /// </description></item>
        /// <item><description><para><b>C16</b>: Standard, 16 cores, 64 GB</para>
        /// </description></item>
        /// <item><description><para><b>C32</b>: Standard, 32 cores, 128 GB</para>
        /// </description></item>
        /// <item><description><para><b>C64</b>: Standard, 64 cores, 256 GB</para>
        /// </description></item>
        /// <item><description><para><b>C80</b>: Standard, 80 cores, 384 GB</para>
        /// </description></item>
        /// <item><description><para><b>C104</b>: Standard, 104 cores, 384 GB</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>For single-replica clusters, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>S8</b>: 8 cores, 32 GB</para>
        /// </description></item>
        /// <item><description><para><b>S16</b>: 16 cores, 64 GB</para>
        /// </description></item>
        /// <item><description><para><b>S32</b>: 32 cores, 128 GB</para>
        /// </description></item>
        /// <item><description><para><b>S64</b>: 64 cores, 256 GB</para>
        /// </description></item>
        /// <item><description><para><b>S104</b>: 104 cores, 384 GB</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For high availability clusters, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>C8</b>: 8 cores, 32 GB</para>
        /// </description></item>
        /// <item><description><para><b>C16</b>: 16 cores, 64 GB</para>
        /// </description></item>
        /// <item><description><para><b>C32</b>: 32 cores, 128 GB</para>
        /// </description></item>
        /// <item><description><para><b>C64</b>: 64 cores, 256 GB</para>
        /// </description></item>
        /// <item><description><para><b>C104</b>: 104 cores, 384 GB</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S8</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The network type. Currently, only VPC is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>21.8.10.19</b></para>
        /// </description></item>
        /// <item><description><para><b>22.8.5.29</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.8.5.29</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// <list type="bullet">
        /// <item><description><para>For single-replica clusters, the valid range is 1–48.</para>
        /// </description></item>
        /// <item><description><para>For high availability clusters, the valid range is 1–24.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The storage capacity per node, in GB. The valid range is 100–32,000.</para>
        /// <remarks>
        /// <para>The value must be a multiple of 100.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><b>CloudESSD_PL0</b>: ESSD PL0 cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>CloudESSD</b>: ESSD PL1 cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>CloudESSD_PL2</b>: ESSD PL2 cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>CloudESSD_PL3</b>: ESSD PL3 cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>CloudEfficiency</b>: Ultra Disk</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudESSD_PL2</para>
        /// </summary>
        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <c>EncryptionType</c> is set to <c>CloudDisk</c>.</para>
        /// <para>The ID of the cloud disk encryption key. You can create and manage keys in the Key Management Service console.</para>
        /// <remarks>
        /// <para>If <c>EncryptionType</c> is not specified, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-9a164dae****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Only cloud disk encryption is supported. Set this value to <b>CloudDisk</b>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, encryption is disabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDisk</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription duration unit.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required only when <c>PayType</c> is set to <c>Prepaid</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b>: Measured in years.</para>
        /// </description></item>
        /// <item><description><para><b>Month</b>: Measured in months.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> API to query the latest region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group that contains the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the source cluster. You can call the <a href="https://help.aliyun.com/document_detail/170879.html">DescribeDBClusters</a> API to query cluster IDs.</para>
        /// <remarks>
        /// <para>This parameter is required when restoring data to an ApsaraDB for ClickHouse cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1lxbo89u950****</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        /// <summary>
        /// <para>The tags to add to the cluster.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTags> Tags { get; set; }
        public class CreateDBInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example string</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required only when <c>PayType</c> is set to <c>Prepaid</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If <c>Period</c> is <c>Year</c>, the valid range is 1–3.</para>
        /// </description></item>
        /// <item><description><para>If <c>Period</c> is <c>Month</c>, the valid range is 1–9.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary VSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchBak")]
        [Validation(Required=false)]
        public string VSwitchBak { get; set; }

        /// <summary>
        /// <para>The ID of the second standby VSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchBak2")]
        [Validation(Required=false)]
        public string VSwitchBak2 { get; set; }

        /// <summary>
        /// <para>The VSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the second standby availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZondIdBak2")]
        [Validation(Required=false)]
        public string ZondIdBak2 { get; set; }

        /// <summary>
        /// <para>The availability zone ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> API to query the latest availability zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneIdBak")]
        [Validation(Required=false)]
        public string ZoneIdBak { get; set; }

    }

}
