// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is not enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when PayType is set to Prepaid (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>Indicates whether the backup feature is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: The backup feature is supported.</description></item>
        /// <item><description><b>close</b>: The backup feature is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testhbase</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cluster</b>: Cluster Edition.</description></item>
        /// <item><description><b>single</b>: single-node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

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
        /// <para>Indicates whether the cold storage feature is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: The cold storage feature is supported.</description></item>
        /// <item><description><b>close</b>: The cold storage feature is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("ColdStorageStatus")]
        [Validation(Required=false)]
        public string ColdStorageStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the O&amp;M window of the instance has been confirmed for the first time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Confirmed.</description></item>
        /// <item><description><b>false</b>: Not confirmed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>Confirm the O&amp;M window for the first time</b> dialog box appears only when you access the <b>Basic Information</b> page of the instance for the first time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfirmMaintainTime")]
        [Validation(Required=false)]
        public string ConfirmMaintainTime { get; set; }

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
        /// <para>The disk capacity of core nodes. Unit: GB.</para>
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
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>local_hdd</b>: local HDD.</description></item>
        /// <item><description><b>local__ssd</b>: local SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        /// <summary>
        /// <para>The node specifications of core nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn2.2xlarge</para>
        /// </summary>
        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        /// <summary>
        /// <para>The number of core nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CoreNodeCount")]
        [Validation(Required=false)]
        public int? CoreNodeCount { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-19T11:23:22</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was created, in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-19T03:23:22Z</para>
        /// </summary>
        [NameInMap("CreatedTimeUTC")]
        [Validation(Required=false)]
        public string CreatedTimeUTC { get; set; }

        /// <summary>
        /// <para>The Unified Auto Renewal Cycle.</para>
        /// <list type="bullet">
        /// <item><description>Monthly subscription: The auto-renewal epoch is 1 month.</description></item>
        /// <item><description>Yearly subscription: The auto-renewal epoch is 1 year (12 months).</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when PayType is set to Prepaid (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Indicates whether access from the HBase open source client is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Access is supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Access is not supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableHbaseProxy")]
        [Validation(Required=false)]
        public bool? EnableHbaseProxy { get; set; }

        /// <summary>
        /// <para>The encryption key.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the encryption type is <b>CloudDisk</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-9a164dae****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoEncryption</b>: Encryption is not enabled.</description></item>
        /// <item><description><b>CloudDisk</b>: Cloud disk encryption is enabled.</description></item>
        /// <item><description><b>EncryptionKey</b>: The encryption key specified by the parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Cloud disk encryption cannot be disabled after it is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NoEncryption</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition or ApsaraDB for HBase single-node.</description></item>
        /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Performance-enhanced Edition.</description></item>
        /// <item><description><b>serverlesshbase</b>: ApsaraDB for HBase Serverless Edition.</description></item>
        /// <item><description><b>bds</b>: BDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-24T00:00:00</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expires, in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-23T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTimeUTC")]
        [Validation(Required=false)]
        public string ExpireTimeUTC { get; set; }

        /// <summary>
        /// <para>The initial default password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LFuVlAvSKsbo</para>
        /// </summary>
        [NameInMap("InitialRootPassword")]
        [Validation(Required=false)]
        public string InitialRootPassword { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testhbase</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public bool? IsDeletionProtection { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is configured for high availability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Configured for high availability.</description></item>
        /// <item><description><b>false</b>: Not configured for high availability.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Cluster Edition instances are configured for high availability with default configurations and use 2 master nodes.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Single-node instances are configured with the actual active capacity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsHa")]
        [Validation(Required=false)]
        public bool? IsHa { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is the latest version.</description></item>
        /// <item><description><b>false</b>: The instance is not the latest version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a multi-model Cluster Edition instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is a multi-model Cluster Edition instance.</description></item>
        /// <item><description><b>false</b>: The instance is not a multi-model Cluster Edition instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMultiModel")]
        [Validation(Required=false)]
        public bool? IsMultiModel { get; set; }

        /// <summary>
        /// <para>The minor version of the LPROXY service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3.2</para>
        /// </summary>
        [NameInMap("LproxyMinorVersion")]
        [Validation(Required=false)]
        public string LproxyMinorVersion { get; set; }

        /// <summary>
        /// <para>The end time of the O&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The major version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <para>The disk capacity of master nodes. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MasterDiskSize")]
        [Validation(Required=false)]
        public int? MasterDiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned for single-node instances.</para>
        /// </remarks>
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
        /// <para>hbase.sn2.large</para>
        /// </summary>
        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        /// <summary>
        /// <para>The master node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The master node is a single node.</description></item>
        /// <item><description><b>2</b>: The master node is in Cluster Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MasterNodeCount")]
        [Validation(Required=false)]
        public int? MasterNodeCount { get; set; }

        /// <summary>
        /// <para>The minor version number of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2.9.1</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

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
        /// <para>The module type version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phoenxi:4.0</para>
        /// </summary>
        [NameInMap("ModuleStackVersion")]
        [Validation(Required=false)]
        public string ModuleStackVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance components need to be upgraded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Upgrade is required.</description></item>
        /// <item><description><b>false</b>: Upgrade is not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedUpgrade")]
        [Validation(Required=false)]
        public bool? NeedUpgrade { get; set; }

        [NameInMap("NeedUpgradeComps")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyNeedUpgradeComps NeedUpgradeComps { get; set; }
        public class DescribeInstanceResponseBodyNeedUpgradeComps : TeaModel {
            [NameInMap("Comps")]
            [Validation(Required=false)]
            public List<string> Comps { get; set; }

        }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud. If the network type is VPC, the VswitchId and VpcId parameters are returned.</description></item>
        /// <item><description><b>CLASSIC</b>: classic network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The parent instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-uf699153o1m2l****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F429923-B6F6-52C5-9C2A-5B8A8C6BBA66</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The single-zone risk alert information.</para>
        /// </summary>
        [NameInMap("SingleZoneRiskAlert")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodySingleZoneRiskAlert SingleZoneRiskAlert { get; set; }
        public class DescribeInstanceResponseBodySingleZoneRiskAlert : TeaModel {
            /// <summary>
            /// <para>The confirmation date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01</para>
            /// </summary>
            [NameInMap("ConfirmDate")]
            [Validation(Required=false)]
            public string ConfirmDate { get; set; }

            /// <summary>
            /// <para>The disposition type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NO_SET: Not set.
            /// PLAN_MIGRATION: Plan to migrate to Lindorm multi-zone edition.
            /// EXTERNAL_BIZ_HA: Business-level disaster recovery</para>
            /// </summary>
            [NameInMap("DispositionType")]
            [Validation(Required=false)]
            public string DispositionType { get; set; }

            /// <summary>
            /// <para>Indicates whether an alert is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedAlert")]
            [Validation(Required=false)]
            public bool? NeedAlert { get; set; }

            /// <summary>
            /// <para>The planned completion date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-01-01</para>
            /// </summary>
            [NameInMap("PlannedCompletionDate")]
            [Validation(Required=false)]
            public string PlannedCompletionDate { get; set; }

        }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
        /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
        /// <item><description><b>RESTARTING</b>: The instance is being restarted.</description></item>
        /// <item><description><b>MINOR_VERSION_TRANSING</b>: A minor engine version update is in progress.</description></item>
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
        public DescribeInstanceResponseBodyTags Tags { get; set; }
        public class DescribeInstanceResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyTagsTag> Tag { get; set; }
            public class DescribeInstanceResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The task progress of the instance, in percentage (%). Tasks initiated from the ApsaraDB for HBase console include specification changes, node scale-out, node scale-in, instance restart, and minor engine version updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25.00</para>
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
        /// <para>The VPC ID. This parameter is returned when <b>NetworkType</b> is <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15s22y1a7sff5gj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is returned when <b>NetworkType</b> is <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1foll427ze3d4ps****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
