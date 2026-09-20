// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The vSwitch ID of the arbiter zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-t4nax9mp3wk0czn****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchIds")]
        [Validation(Required=false)]
        public string ArbiterVSwitchIds { get; set; }

        /// <summary>
        /// <para>The zone ID of the arbiter zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1c</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the multi-zone instance when PayType is set to Prepaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: Auto-renewal is enabled.</description></item>
        /// <item><description>False: Auto-renewal is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-t4nn71xa0yn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mz_test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cold storage size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public int? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The number of core node disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoreDiskCount")]
        [Validation(Required=false)]
        public string CoreDiskCount { get; set; }

        /// <summary>
        /// <para>The disk size of a core node. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public int? CoreDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of core nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>local_hdd_pro: throughput-intensive local disk.</description></item>
        /// <item><description>local_ssd_pro: I/O-intensive local disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of core nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.large</para>
        /// </summary>
        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        /// <summary>
        /// <para>The number of core nodes. The minimum value is 4, and the increment is a multiple of 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("CoreNodeCount")]
        [Validation(Required=false)]
        public int? CoreNodeCount { get; set; }

        /// <summary>
        /// <para>The creation time in the current time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-15T18:04:52</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The creation time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-15T10:04:52Z</para>
        /// </summary>
        [NameInMap("CreatedTimeUTC")]
        [Validation(Required=false)]
        public string CreatedTimeUTC { get; set; }

        /// <summary>
        /// <para>The Unified Auto Renewal Cycle. This parameter is not returned for pay-as-you-go instances.</para>
        /// <list type="bullet">
        /// <item><description>Monthly subscription: The auto-renewal epoch is 1 month.</description></item>
        /// <item><description>Yearly subscription: The auto-renewal epoch is 1 year (12 months).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The ID of the encryption key. This parameter is empty if encryption is not enabled.</para>
        /// <remarks>
        /// <para>Cloud disk encryption cannot be disabled after it is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2a****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NULL: Encryption is not enabled. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>CloudDisk: Cloud disk encryption. The encryption key is specified by the <b>EncryptionKey</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDisk</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <para>The service type. Currently, only hbaseue is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The expiration time in the current time zone. This parameter is returned only when PayType is set to Prepaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-16T08:00:00</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The expiration time in UTC. This parameter is returned only when PayType is set to Prepaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-16T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTimeUTC")]
        [Validation(Required=false)]
        public string ExpireTimeUTC { get; set; }

        /// <summary>
        /// <para>The initial default password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yKcYVkFsULmC</para>
        /// </summary>
        [NameInMap("InitialRootPassword")]
        [Validation(Required=false)]
        public string InitialRootPassword { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-t4nn71xa0yn****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mz_test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: Deletion protection is enabled. The instance cannot be deleted. An error message is returned if you attempt to delete the instance.</description></item>
        /// <item><description>False: Deletion protection is disabled. The instance can be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public bool? IsDeletionProtection { get; set; }

        /// <summary>
        /// <para>The number of disks per log node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogDiskCount")]
        [Validation(Required=false)]
        public string LogDiskCount { get; set; }

        /// <summary>
        /// <para>The size of a single disk on a log node. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("LogDiskSize")]
        [Validation(Required=false)]
        public int? LogDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of log nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>local_hdd_pro: throughput-intensive local disk.</description></item>
        /// <item><description>local_ssd_pro: I/O-intensive local disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("LogDiskType")]
        [Validation(Required=false)]
        public string LogDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of log nodes. You can call <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> to query the exact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.large</para>
        /// </summary>
        [NameInMap("LogInstanceType")]
        [Validation(Required=false)]
        public string LogInstanceType { get; set; }

        /// <summary>
        /// <para>The number of log nodes. The minimum value is 4, and the value must be a multiple of 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNodeCount")]
        [Validation(Required=false)]
        public int? LogNodeCount { get; set; }

        /// <summary>
        /// <para>The end time of the O&amp;M window. The format is HH:MMZ, such as 20:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06:00:00</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O&amp;M window. The format is HH:MMZ, such as 20:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00:00</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The major version based on the engine type. Currently, only version 2.0 of hbaseue is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <para>The disk size of master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MasterDiskSize")]
        [Validation(Required=false)]
        public int? MasterDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("MasterDiskType")]
        [Validation(Required=false)]
        public string MasterDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.large</para>
        /// </summary>
        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        /// <summary>
        /// <para>The number of master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MasterNodeCount")]
        [Validation(Required=false)]
        public int? MasterNodeCount { get; set; }

        /// <summary>
        /// <para>The module ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ModuleId")]
        [Validation(Required=false)]
        public int? ModuleId { get; set; }

        /// <summary>
        /// <para>The module software stack version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ModuleStackVersion")]
        [Validation(Required=false)]
        public string ModuleStackVersion { get; set; }

        /// <summary>
        /// <para>The zone combination of the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1-abc-aliyun</para>
        /// </summary>
        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        [NameInMap("MultiZoneInstanceModels")]
        [Validation(Required=false)]
        public DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModels MultiZoneInstanceModels { get; set; }
        public class DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModels : TeaModel {
            [NameInMap("MultiZoneInstanceModel")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModelsMultiZoneInstanceModel> MultiZoneInstanceModel { get; set; }
            public class DescribeMultiZoneClusterResponseBodyMultiZoneInstanceModelsMultiZoneInstanceModel : TeaModel {
                [NameInMap("HdfsMinorVersion")]
                [Validation(Required=false)]
                public string HdfsMinorVersion { get; set; }

                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                [NameInMap("IsHdfsLatestVersion")]
                [Validation(Required=false)]
                public string IsHdfsLatestVersion { get; set; }

                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public bool? IsLatestVersion { get; set; }

                [NameInMap("LatestHdfsMinorVersion")]
                [Validation(Required=false)]
                public string LatestHdfsMinorVersion { get; set; }

                [NameInMap("LatestMinorVersion")]
                [Validation(Required=false)]
                public string LatestMinorVersion { get; set; }

                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The network type. Currently, only VPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The instance ID of the primary instance. This parameter is returned only when the instance is a component instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-fls1gf31y5s35****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription.</description></item>
        /// <item><description>Postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the primary zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-t4n3s1zd2gtidg****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchIds")]
        [Validation(Required=false)]
        public string PrimaryVSwitchIds { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1a</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A02C0E6D-3A47-4FA0-BA7E-60793CE256DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-lk51f5fer315e****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the secondary zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-t4nvvk7xur3rdi****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchIds")]
        [Validation(Required=false)]
        public string StandbyVSwitchIds { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1b</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATING: The cluster is being created.</description></item>
        /// <item><description>ACTIVATION: The cluster is running.</description></item>
        /// <item><description>DELETING: The cluster is being deleted.</description></item>
        /// <item><description>RESTARTING: The cluster is being restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeMultiZoneClusterResponseBodyTags Tags { get; set; }
        public class DescribeMultiZoneClusterResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneClusterResponseBodyTagsTag> Tag { get; set; }
            public class DescribeMultiZoneClusterResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The progress of the task running on the instance, in percentage (%). Tasks initiated from the ApsaraDB for HBase console include specification changes, node scale-out, node scale-in, instance restart, and minor engine version update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TaskProgress")]
        [Validation(Required=false)]
        public string TaskProgress { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: The task is running.</description></item>
        /// <item><description>pause: The task is paused.</description></item>
        /// <item><description>fail: The task is interrupted.</description></item>
        /// <item><description>finish: The task is completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4nx81tmlixcq5****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
