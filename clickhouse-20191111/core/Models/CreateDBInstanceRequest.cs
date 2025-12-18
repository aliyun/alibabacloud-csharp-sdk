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
        /// <para> This parameter is valid only if the value of PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/360339.html">DescribeBackups</a> operation to query the backup sets.</para>
        /// <remarks>
        /// <para> If you want to restore the data of an ApsaraDB for ClickHouse cluster, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b-12af23adsf</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The value is a string and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Single-replica Edition</description></item>
        /// <item><description><b>HighAvailability</b>: Double-replica Edition</description></item>
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
        /// <para>The specifications of the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for a Single-replica Edition cluster:</para>
        /// <list type="bullet">
        /// <item><description><b>S8</b>: 8 cores and 32 GB of memory</description></item>
        /// <item><description><b>S16</b>: 16 cores and 64 GB of memory</description></item>
        /// <item><description><b>S32</b>: 32 cores and 128 GB of memory</description></item>
        /// <item><description><b>S64</b>: 64 cores and 256 GB of memory</description></item>
        /// <item><description><b>S104</b>: 104 cores and 384 GB of memory</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for a Double-replica Edition cluster:</para>
        /// <list type="bullet">
        /// <item><description><b>C8</b>: 8 cores and 32 GB of memory</description></item>
        /// <item><description><b>C16</b>: 16 cores and 64 GB of memory</description></item>
        /// <item><description><b>C32</b>: 32 cores and 128 GB of memory</description></item>
        /// <item><description><b>C64</b>: 64 cores and 256 GB of memory</description></item>
        /// <item><description><b>C104</b>: 104 cores and 384 GB of memory</description></item>
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
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Only Virtual Private Cloud (VPC) is supported.</para>
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
        /// <item><description><b>21.8.10.19</b></description></item>
        /// <item><description><b>22.8.5.29</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21.8.10.19</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when the cluster is of Single-replica Edition: 1 to 48.</description></item>
        /// <item><description>Valid values when the cluster is of Double-replica Edition: 1 to 24.</description></item>
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
        /// <para>The storage capacity of a single node. Valid values: 100 to 32000. Unit: GB.</para>
        /// <remarks>
        /// <para> This value is a multiple of 100.</para>
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
        /// <para>The storage type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudESSD</b>: The cluster uses an enhanced SSD (ESSD) of performance level 1 (PL1).</description></item>
        /// <item><description><b>CloudESSD_PL2</b>: The cluster uses an ESSD of PL2.</description></item>
        /// <item><description><b>CloudESSD_PL3</b>: The cluster uses an ESSD of PL3.</description></item>
        /// <item><description><b>CloudEfficiency</b>: The cluster uses an ultra disk.</description></item>
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
        /// <para>You must specify this parameter when EncryptionType is set to CloudDisk.</para>
        /// <para>The ID of the key that is used to encrypt data on disks. You can obtain the ID of the key from the Key Management Service (KMS) console. You can also create a key.</para>
        /// <remarks>
        /// <para> If EncryptionType is empty, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-9a164dae****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Set the value to <b>CloudDisk</b>, which indicates that only disk encryption is supported.</para>
        /// <remarks>
        /// <para> If this parameter is not specified, data is not encrypted.</para>
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
        /// <para>The billing method of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: The cluster uses the pay-as-you-go billing method.</description></item>
        /// <item><description><b>Prepaid</b>: The cluster uses the subscription billing method.</description></item>
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
        /// <para>The unit of the subscription duration for the cluster. Valid values:</para>
        /// <remarks>
        /// <para> This parameter is required only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the source cluster. You can call the <a href="https://help.aliyun.com/document_detail/170879.html">DescribeDBClusters</a> operation to query backup set IDs.</para>
        /// <remarks>
        /// <para> If you want to restore the data of an ApsaraDB for ClickHouse cluster, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1lxbo89u950****</para>
        /// </summary>
        [NameInMap("SourceDBClusterId")]
        [Validation(Required=false)]
        public string SourceDBClusterId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTags> Tags { get; set; }
        public class CreateDBInstanceRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例字符串</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration of the subscription cluster.</para>
        /// <remarks>
        /// <para> This parameter is required only when PayType is set to Prepaid.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Valid values when Period is set to Year: 1 to 3 (integer)</description></item>
        /// <item><description>Valid values when Period is set to Month: 1 to 9 (integer)</description></item>
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
        /// <para>The vSwitch in the secondary zone for the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchBak")]
        [Validation(Required=false)]
        public string VSwitchBak { get; set; }

        /// <summary>
        /// <para>The vSwitch in secondary zone 2 for the VPC.</para>
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
        /// <para>The secondary zone 2 of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZondIdBak2")]
        [Validation(Required=false)]
        public string ZondIdBak2 { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the most recent zone list.</para>
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
