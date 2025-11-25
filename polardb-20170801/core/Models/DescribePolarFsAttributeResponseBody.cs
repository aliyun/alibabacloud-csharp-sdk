// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AcceleratedStorageSpace")]
        [Validation(Required=false)]
        public double? AcceleratedStorageSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("AcceleratingEnable")]
        [Validation(Required=false)]
        public string AcceleratingEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public double? Bandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("BandwidthBaseLine")]
        [Validation(Required=false)]
        public double? BandwidthBaseLine { get; set; }

        [NameInMap("BucketId")]
        [Validation(Required=false)]
        public string BucketId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>high_performance</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientDownloadPath")]
        [Validation(Required=false)]
        public string ClientDownloadPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-08-02T05:57:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-10T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        [NameInMap("MetaUrl")]
        [Validation(Required=false)]
        public string MetaUrl { get; set; }

        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        [NameInMap("MountInfo")]
        [Validation(Required=false)]
        public DescribePolarFsAttributeResponseBodyMountInfo MountInfo { get; set; }
        public class DescribePolarFsAttributeResponseBodyMountInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP://<b>.</b>.<b>.</b>:3000,TCP://<b>.</b>.<b>.</b>:3000,TCP://<b>.</b>.<b>.</b>:3000</para>
            /// </summary>
            [NameInMap("PolarDbProxy")]
            [Validation(Required=false)]
            public string PolarDbProxy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pfs-**********</para>
            /// </summary>
            [NameInMap("PolarFsCluster")]
            [Validation(Required=false)]
            public string PolarFsCluster { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a734298c391cb9ebd05e2ee85feb624</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PolarFsInstanceDescription")]
        [Validation(Required=false)]
        public string PolarFsInstanceDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("PolarFsStatus")]
        [Validation(Required=false)]
        public string PolarFsStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PolarFS 2.0</para>
        /// </summary>
        [NameInMap("PolarFsType")]
        [Validation(Required=false)]
        public string PolarFsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.1-1.0.3</para>
        /// </summary>
        [NameInMap("PolarFsVersion")]
        [Validation(Required=false)]
        public string PolarFsVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2zejpr41d9xk3uk34</para>
        /// </summary>
        [NameInMap("RelativeDbClusterId")]
        [Validation(Required=false)]
        public string RelativeDbClusterId { get; set; }

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
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public double? StorageSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>essdpl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3012558848</para>
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public double? StorageUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-**************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
