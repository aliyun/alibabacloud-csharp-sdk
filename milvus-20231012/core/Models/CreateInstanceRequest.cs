// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable AI function.</para>
        /// </summary>
        [NameInMap("aiFunction")]
        [Validation(Required=false)]
        public bool? AiFunction { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoBackup")]
        [Validation(Required=false)]
        public bool? AutoBackup { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: true. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when the payment type is set to Subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup and restoration information.</para>
        /// </summary>
        [NameInMap("backupRestoreInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestBackupRestoreInfo BackupRestoreInfo { get; set; }
        public class CreateInstanceRequestBackupRestoreInfo : TeaModel {
            /// <summary>
            /// <para>The backup ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bt-xxxxx</para>
            /// </summary>
            [NameInMap("backupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The backup name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Backup1</para>
            /// </summary>
            [NameInMap("backupName")]
            [Validation(Required=false)]
            public string BackupName { get; set; }

            /// <summary>
            /// <para>The ID of the source backup cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-xxxxxxx</para>
            /// </summary>
            [NameInMap("sourceClusterId")]
            [Validation(Required=false)]
            public string SourceClusterId { get; set; }

        }

        /// <summary>
        /// <para>The component information.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestComponents> Components { get; set; }
        public class CreateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// <para>The number of compute units (CUs).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cuNum")]
            [Validation(Required=false)]
            public int? CuNum { get; set; }

            /// <summary>
            /// <para>The CU type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("cuType")]
            [Validation(Required=false)]
            public string CuType { get; set; }

            [NameInMap("dataDisk")]
            [Validation(Required=false)]
            public CreateInstanceRequestComponentsDataDisk DataDisk { get; set; }
            public class CreateInstanceRequestComponentsDataDisk : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alicloud-disk-essd-pl1</para>
                /// </summary>
                [NameInMap("storageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

            /// <summary>
            /// <para>The disk size type for Query Node. Set to Large for storage-optimized, and Normal for compute-optimized or other configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("diskSizeType")]
            [Validation(Required=false)]
            public string DiskSizeType { get; set; }

            /// <summary>
            /// <para>The number of replicas.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The component type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standalone</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The configuration items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rootCoord:
        ///     maxDatabaseNum: 64 # Maximum number of database
        ///     maxPartitionNum: 4096</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <para>The database administrator password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test12</para>
        /// </summary>
        [NameInMap("dbAdminPassword")]
        [Validation(Required=false)]
        public string DbAdminPassword { get; set; }

        /// <summary>
        /// <para>The Milvus version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("dbVersion")]
        [Validation(Required=false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OSS encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable high availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>milvus-test</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-zone storage.</para>
        /// </summary>
        [NameInMap("isMultiAzStorage")]
        [Validation(Required=false)]
        public bool? IsMultiAzStorage { get; set; }

        /// <summary>
        /// <para>The ID of the KMS key used for encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The number of load replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("loadReplicas")]
        [Validation(Required=false)]
        public int? LoadReplicas { get; set; }

        /// <summary>
        /// <para>The zone configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("multiZoneMode")]
        [Validation(Required=false)]
        public string MultiZoneMode { get; set; }

        /// <summary>
        /// <para>The payment duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("paymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        /// <summary>
        /// <para>The payment duration unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("paymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// <para>The payment type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22120151****</para>
        /// </summary>
        [NameInMap("promotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-123xxx&quot;]</para>
        /// </summary>
        [NameInMap("vSwitchIds")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestVSwitchIds> VSwitchIds { get; set; }
        public class CreateInstanceRequestVSwitchIds : TeaModel {
            /// <summary>
            /// <para>The vSwitch ID configuration in the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-a</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-123xxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The primary zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-g</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
