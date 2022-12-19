// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetDetailByUuidResponseBody : TeaModel {
        /// <summary>
        /// The details of the server.
        /// </summary>
        [NameInMap("AssetDetail")]
        [Validation(Required=false)]
        public DescribeAssetDetailByUuidResponseBodyAssetDetail AssetDetail { get; set; }
        public class DescribeAssetDetailByUuidResponseBodyAssetDetail : TeaModel {
            /// <summary>
            /// The type of the asset. Valid values:
            /// 
            /// *   **0**: ECS instance
            /// *   **1**: Server Load Balancer (SLB) instance
            /// *   **2**: NAT gateway
            /// *   **3**: ApsaraDB RDS database
            /// *   **4**: ApsaraDB for MongoDB database
            /// *   **5**: ApsaraDB for Redis database
            /// *   **6**: image
            /// *   **7**: container
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// The timestamp when Security Center is authorized to protect the asset. Unit: milliseconds.
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// The edition of Security Center that is authorized to protect the asset. Valid values:
            /// 
            /// *   **1**: Basic edition (Unauthorized)
            /// *   **6**: Anti-virus edition
            /// *   **5**: Advanced edition
            /// *   **3**: Enterprise edition
            /// *   **7**: Ultimate edition
            /// *   **10**: Value-added Plan edition
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// Indicates whether Security Center is authorized to protect the asset. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// The status of the Security Center agent. Valid values:
            /// 
            /// *   **pause**: The Security Center agent suspends protection for your server.
            /// *   **online**: The Security Center agent is protecting your server.
            /// *   **offline**: The Security Center agent does not protect your server.
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The version of the Security Center agent.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The number of CPU cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The details of the CPU.
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// The timestamp when Security Center records the details of the server. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// An array that consists of the information about the disk.
            /// </summary>
            [NameInMap("DiskInfoList")]
            [Validation(Required=false)]
            public List<string> DiskInfoList { get; set; }

            /// <summary>
            /// Indicates whether the asset is provided by Alibaba Cloud. Valid values:
            /// 
            /// *   **0**: yes
            /// *   **1**: no
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// The group to which the server belongs. By default, the servers that are not grouped belong to the **Default** group.
            /// </summary>
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }

            /// <summary>
            /// The name of the host.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The IP address that is assigned to the Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The IP addresses of the server.
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

            /// <summary>
            /// The kernel version of the operating system.
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// The media access control (MAC) addresses of the server.
            /// </summary>
            [NameInMap("MacList")]
            [Validation(Required=false)]
            public List<string> MacList { get; set; }

            /// <summary>
            /// The memory size of the server. Unit: GB.
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// The memory size of the server. Unit: MB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The operating system type of the server.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The operating system version of the server.
            /// </summary>
            [NameInMap("OsDetail")]
            [Validation(Required=false)]
            public string OsDetail { get; set; }

            /// <summary>
            /// The name of the operating system.
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// The region in which the server resides.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the region in which the asset resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region in which the server resides.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// The operating system information about the server.
            /// </summary>
            [NameInMap("SysInfo")]
            [Validation(Required=false)]
            public string SysInfo { get; set; }

            /// <summary>
            /// The tag that is added to the server.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) in which the server resides.
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
