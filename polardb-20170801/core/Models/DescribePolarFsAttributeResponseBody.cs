// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The acceleration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alluxio</para>
        /// </summary>
        [NameInMap("AccelerateType")]
        [Validation(Required=false)]
        public string AccelerateType { get; set; }

        /// <summary>
        /// <para>The acceleration storage space, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AcceleratedStorageSpace")]
        [Validation(Required=false)]
        public double? AcceleratedStorageSpace { get; set; }

        /// <summary>
        /// <para>Indicates whether the acceleration cache is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enabled.</description></item>
        /// <item><description><b>OFF</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("AcceleratingEnable")]
        [Validation(Required=false)]
        public string AcceleratingEnable { get; set; }

        /// <summary>
        /// <para>The bandwidth, in MB/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public double? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth baseline, in MB/s/TiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BandwidthBaseLine")]
        [Validation(Required=false)]
        public double? BandwidthBaseLine { get; set; }

        /// <summary>
        /// <para>The storage bucket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("BucketId")]
        [Validation(Required=false)]
        public string BucketId { get; set; }

        /// <summary>
        /// <para>The PolarLakebase edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high_performance</b>: High-performance Edition.</para>
        /// </description></item>
        /// <item><description><para><b>basic</b>: Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><b>cold</b>: Cold Storage Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high_performance</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://*</para>
        /// </summary>
        [NameInMap("ClientDownloadPath")]
        [Validation(Required=false)]
        public string ClientDownloadPath { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-02T05:57:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The custom bucket path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx-%d.oss-cn-beijing-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CustomBucketPath")]
        [Validation(Required=false)]
        public string CustomBucketPath { get; set; }

        /// <summary>
        /// <para>The list of custom storage paths.</para>
        /// </summary>
        [NameInMap("CustomBucketPathList")]
        [Validation(Required=false)]
        public List<DescribePolarFsAttributeResponseBodyCustomBucketPathList> CustomBucketPathList { get; set; }
        public class DescribePolarFsAttributeResponseBodyCustomBucketPathList : TeaModel {
            /// <summary>
            /// <para>The custom storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pfs-xxx.oss-[regionId]-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The custom storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The database ecosystem type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The expiration time of the cluster.</para>
        /// <remarks>
        /// <para>This parameter is returned only for clusters whose billing method is <b>Prepaid</b> (subscription). An empty value is returned for <b>Postpaid</b> (pay-as-you-go) clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-10T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster has expired.</para>
        /// <remarks>
        /// <para>This parameter is returned only for clusters whose billing method is <b>Prepaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Unlock</b>: not locked.</description></item>
        /// <item><description><b>ManualLock</b>: manually locked. </description></item>
        /// <item><description><b>LockByExpiration</b>: automatically locked due to cluster expiration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("MetaInstanceName")]
        [Validation(Required=false)]
        public string MetaInstanceName { get; set; }

        /// <summary>
        /// <para>The metadata URL for Fuse mounting (encrypted).</para>
        /// 
        /// <b>Example:</b>
        /// <para>e6cc1d2e2a6fa292038d999fda6501*****</para>
        /// </summary>
        [NameInMap("MetaUrl")]
        [Validation(Required=false)]
        public string MetaUrl { get; set; }

        /// <summary>
        /// <para>The minor version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.3.0-v1.1.1</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("MountInfo")]
        [Validation(Required=false)]
        public DescribePolarFsAttributeResponseBodyMountInfo MountInfo { get; set; }
        public class DescribePolarFsAttributeResponseBodyMountInfo : TeaModel {
            /// <summary>
            /// <para>The cluster management endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP://<b>.</b>.<b>.</b>:3000,TCP://<b>.</b>.<b>.</b>:3000,TCP://<b>.</b>.<b>.</b>:3000</para>
            /// </summary>
            [NameInMap("PolarDbProxy")]
            [Validation(Required=false)]
            public string PolarDbProxy { get; set; }

            /// <summary>
            /// <para>The file system name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pfs-**********</para>
            /// </summary>
            [NameInMap("PolarFsCluster")]
            [Validation(Required=false)]
            public string PolarFsCluster { get; set; }

            /// <summary>
            /// <para>The token value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a734298c391cb9ebd05e2ee85feb624</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The description of the PolarLakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PolarFsInstanceDescription")]
        [Validation(Required=false)]
        public string PolarFsInstanceDescription { get; set; }

        /// <summary>
        /// <para>The PolarLakebase instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The PolarLakebase instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("PolarFsStatus")]
        [Validation(Required=false)]
        public string PolarFsStatus { get; set; }

        /// <summary>
        /// <para>The instance version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PolarFS 2.0</b>: 2.0</description></item>
        /// <item><description><b>PolarFS 1.0</b>: 1.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PolarFS 2.0</para>
        /// </summary>
        [NameInMap("PolarFsType")]
        [Validation(Required=false)]
        public string PolarFsType { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1-1.0.3</para>
        /// </summary>
        [NameInMap("PolarFsVersion")]
        [Validation(Required=false)]
        public string PolarFsVersion { get; set; }

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
        /// <para>The ID of the associated PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zejpr41d9xk3uk34</para>
        /// </summary>
        [NameInMap("RelativeDbClusterId")]
        [Validation(Required=false)]
        public string RelativeDbClusterId { get; set; }

        /// <summary>
        /// <para>The instance ID of the associated PolarLakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-**********</para>
        /// </summary>
        [NameInMap("RelativePfsClusterId")]
        [Validation(Required=false)]
        public string RelativePfsClusterId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F9E6A3B-C13E-4064-A010-18582A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The managed security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The storage space, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public double? StorageSpace { get; set; }

        /// <summary>
        /// <para>Valid values for the High-performance Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL0</b></description></item>
        /// </list>
        /// <para>Valid values for the Basic Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>city_redundancy</b>: zone-redundant storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>essdpl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The used storage space, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public double? StorageUsed { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
