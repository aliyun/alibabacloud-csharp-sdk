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
        /// <para>This parameter takes effect only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup set ID. You can call the <a href="https://help.aliyun.com/document_detail/360339.html">DescribeBackups</a> operation to query the backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you restore data for an ApsaraDB for ClickHouse cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b-12af23adsf</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The value is a string that contains up to 64 ASCII characters.</para>
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
        /// <item><description><b>Basic</b>: single-replica edition.</description></item>
        /// <item><description><b>HighAvailability</b>: double-replica edition.</description></item>
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
        /// <para>The cluster specifications.
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Single-replica edition. Valid values:<list type="bullet">
        /// <item><description><b>LS20</b>: large storage, 20 cores, 88 GB.</description></item>
        /// <item><description><b>LS40</b>: large storage, 40 cores, 176 GB.</description></item>
        /// <item><description><b>LS80</b>: large storage, 80 cores, 352 GB.</description></item>
        /// <item><description><b>S8</b>: standard, 8 cores, 32 GB.</description></item>
        /// <item><description><b>S16</b>: standard, 16 cores, 64 GB.</description></item>
        /// <item><description><b>S32</b>: standard, 32 cores, 128 GB.</description></item>
        /// <item><description><b>S64</b>: standard, 64 cores, 256 GB.</description></item>
        /// <item><description><b>S80</b>: standard, 80 cores, 384 GB.</description></item>
        /// <item><description><b>S104</b>: standard, 104 cores, 384 GB.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Double-replica edition. Valid values:<list type="bullet">
        /// <item><description><b>LC20</b>: large storage, 20 cores, 88 GB.</description></item>
        /// <item><description><b>LC40</b>: large storage, 40 cores, 176 GB.</description></item>
        /// <item><description><b>LC80</b>: large storage, 80 cores, 352 GB.</description></item>
        /// <item><description><b>C8</b>: standard, 8 cores, 32 GB.</description></item>
        /// <item><description><b>C16</b>: standard, 16 cores, 64 GB.</description></item>
        /// <item><description><b>C32</b>: standard, 32 cores, 128 GB.</description></item>
        /// <item><description><b>C64</b>: standard, 64 cores, 256 GB.</description></item>
        /// <item><description><b>C80</b>: standard, 80 cores, 384 GB.</description></item>
        /// <item><description><b>C104</b>: standard, 104 cores, 384 GB.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Single-replica edition. Valid values:    <list type="bullet">
        /// <item><description><b>S8</b>: 8 cores, 32 GB.</description></item>
        /// <item><description><b>S16</b>: 16 cores, 64 GB.    </description></item>
        /// <item><description><b>S32</b>: 32 cores, 128 GB.</description></item>
        /// <item><description><b>S64</b>: 64 cores, 256 GB.</description></item>
        /// <item><description><b>S104</b>: 104 cores, 384 GB.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Double-replica edition. Valid values:<list type="bullet">
        /// <item><description><b>C8</b>: 8 cores, 32 GB.</description></item>
        /// <item><description><b>C16</b>: 16 cores, 64 GB.</description></item>
        /// <item><description><b>C32</b>: 32 cores, 128 GB.</description></item>
        /// <item><description><b>C64</b>: 64 cores, 256 GB.</description></item>
        /// <item><description><b>C104</b>: 104 cores, 384 GB.</description></item>
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
        /// <para>The network type. Only VPC is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The kernel version. Valid values:</para>
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
        /// <item><description>Single-replica edition: valid values: 1 to 48.</description></item>
        /// <item><description>Double-replica edition: valid values: 1 to 24.</description></item>
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
        /// <para>The storage capacity per node. Valid values: 100 to 32000. Unit: GB.</para>
        /// <remarks>
        /// <para>The step size is 100 GB.</para>
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
        /// <para>The storage type. Valid values:
        /// &lt;props=&quot;china&quot;&gt;- <b>CloudESSD_PL0</b>: PL0 ESSD.</para>
        /// <list type="bullet">
        /// <item><description><b>CloudESSD</b>: PL1 ESSD.</description></item>
        /// <item><description><b>CloudESSD_PL2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>CloudESSD_PL3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>CloudEfficiency</b>: ultra cloud disk.</description></item>
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
        /// <para>The ID of the key used for cloud disk encryption. This parameter is required when EncryptionType is set to CloudDisk.</para>
        /// <para>You can view the key ID in the Key Management Service (KMS) console or create a key.</para>
        /// <remarks>
        /// <para>If EncryptionType is not specified, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-9a164dae****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Only cloud disk encryption is supported. Set the value to <b>CloudDisk</b>.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, data is not encrypted.</para>
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
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
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
        /// <para>The subscription type of the subscription cluster. Valid values:</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect and is required only when PayType is set to Prepaid.				</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: subscription on a yearly basis.</description></item>
        /// <item><description><b>Month</b>: subscription on a monthly basis.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cluster belongs.</para>
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
        /// <para>The source cluster ID. You can call the <a href="https://help.aliyun.com/document_detail/170879.html">DescribeDBClusters</a> operation to query the cluster ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you restore data for an ApsaraDB for ClickHouse cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1lxbo89u950****</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
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
        /// <para>The subscription duration of the subscription cluster.</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect and is required only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If Period is set to Year, valid values: 1 to 3 (integer).</description></item>
        /// <item><description>If Period is set to Month, valid values: 1 to 9 (integer).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchBak")]
        [Validation(Required=false)]
        public string VSwitchBak { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchBak2")]
        [Validation(Required=false)]
        public string VSwitchBak2 { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The secondary zone 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZondIdBak2")]
        [Validation(Required=false)]
        public string ZondIdBak2 { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneIdBak")]
        [Validation(Required=false)]
        public string ZoneIdBak { get; set; }

    }

}
