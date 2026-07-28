// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class InstanceDetail : TeaModel {
        /// <summary>
        /// <para>The automatic backup configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoBackup")]
        [Validation(Required=false)]
        public bool? AutoBackup { get; set; }

        /// <summary>
        /// <para>The component information.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<InstanceDetailComponents> Components { get; set; }
        public class InstanceDetailComponents : TeaModel {
            /// <summary>
            /// <para>The number of CUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
            public InstanceDetailComponentsDataDisk DataDisk { get; set; }
            public class InstanceDetailComponentsDataDisk : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("storageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

            /// <summary>
            /// <para>The disk size type for the Query Node. Set this parameter to Large for storage-optimized configurations, and to Normal for other configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("diskSizeType")]
            [Validation(Required=false)]
            public string DiskSizeType { get; set; }

            [NameInMap("payType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("podsList")]
            [Validation(Required=false)]
            public List<InstanceDetailComponentsPodsList> PodsList { get; set; }
            public class InstanceDetailComponentsPodsList : TeaModel {
                [NameInMap("podId")]
                [Validation(Required=false)]
                public string PodId { get; set; }

                [NameInMap("podName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

            }

            /// <summary>
            /// <para>The number of replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The component type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The configuration.</para>
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
        /// <para>The creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-27T02:04:25Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The instance version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.5</para>
        /// </summary>
        [NameInMap("dbVersion")]
        [Validation(Required=false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether data encryption is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-27T02:04:25Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether high availability is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>kms key Id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The multi-zone deployment mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("multiZoneMode")]
        [Validation(Required=false)]
        public string MultiZoneMode { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4751</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: PayAsYouGo: pay-as-you-go billing method. Subscription: subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3dcgyq7pnqwa</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The running time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("runningTime")]
        [Validation(Required=false)]
        public long? RunningTime { get; set; }

        /// <summary>
        /// <para>The security group IDs.</para>
        /// </summary>
        [NameInMap("securityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>creating: Being created.</description></item>
        /// <item><description>running: Running.</description></item>
        /// <item><description>updating: Being upgraded. This includes specification changes, configuration changes, and public network access changes.</description></item>
        /// <item><description>disable: Unavailable. The cluster has expired and requires renewal to reactivate.</description></item>
        /// <item><description>deleting: Being deleted.</description></item>
        /// <item><description>deleted: Deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<InstanceDetailTags> Tags { get; set; }
        public class InstanceDetailTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// </summary>
        [NameInMap("vSwitchIds")]
        [Validation(Required=false)]
        public List<InstanceDetailVSwitchIds> VSwitchIds { get; set; }
        public class InstanceDetailVSwitchIds : TeaModel {
            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
