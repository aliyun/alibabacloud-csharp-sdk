// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetDetailByUuidResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the server.</para>
        /// </summary>
        [NameInMap("AssetDetail")]
        [Validation(Required=false)]
        public GetAssetDetailByUuidResponseBodyAssetDetail AssetDetail { get; set; }
        public class GetAssetDetailByUuidResponseBodyAssetDetail : TeaModel {
            /// <summary>
            /// <para>The type of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: ECS instance</description></item>
            /// <item><description><b>1</b>: Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>2</b>: NAT gateway</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB instance</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Redis instance</description></item>
            /// <item><description><b>6</b>: image</description></item>
            /// <item><description><b>7</b>: container</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The timestamp when Security Center is authorized to protect the asset. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627974044000</para>
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that is authorized to protect the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic (Unauthorized).</description></item>
            /// <item><description><b>6</b>: Anti-virus.</description></item>
            /// <item><description><b>5</b>: Advanced.</description></item>
            /// <item><description><b>3</b>: Enterprise.</description></item>
            /// <item><description><b>7</b>: Ultimate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Security Center is authorized to protect the asset.</description></item>
            /// <item><description><b>false</b>: Security Center is not authorized to protect the asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The status of the Security Center agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pause</b>: The Security Center agent stops protecting your server.</description></item>
            /// <item><description><b>online</b>: The Security Center agent is protecting your server.</description></item>
            /// <item><description><b>offline</b>: The Security Center agent does not protect your server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The sub-status of the Security Center agent on the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The Security Center agent on the asset is <b>enabled</b>.</description></item>
            /// <item><description><b>offline</b>: The Security Center agent on the asset is <b>disabled</b>.</description></item>
            /// <item><description><b>pause</b>: The Security Center agent is <b>suspended</b>.</description></item>
            /// <item><description><b>uninstalled</b>: The Security Center agent is <b>not installed</b>.</description></item>
            /// <item><description><b>stopped</b>: The asset is <b>shut down</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientSubStatus")]
            [Validation(Required=false)]
            public string ClientSubStatus { get; set; }

            /// <summary>
            /// <para>The version of the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The details of the CPU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intel(R) Xeon(R) Platinum 8163 CPU @ 2.50GHz</para>
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// <para>The timestamp when Security Center records the details of the server. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603863599000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of information about the disk.</para>
            /// </summary>
            [NameInMap("DiskInfoList")]
            [Validation(Required=false)]
            public List<GetAssetDetailByUuidResponseBodyAssetDetailDiskInfoList> DiskInfoList { get; set; }
            public class GetAssetDetailByUuidResponseBodyAssetDetailDiskInfoList : TeaModel {
                /// <summary>
                /// <para>The name of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/vda1</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>The total disk space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

                /// <summary>
                /// <para>The total disk space. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42140479488</para>
                /// </summary>
                [NameInMap("TotalSizeByte")]
                [Validation(Required=false)]
                public long? TotalSizeByte { get; set; }

                /// <summary>
                /// <para>The amount of the used disk space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UseSize")]
                [Validation(Required=false)]
                public long? UseSize { get; set; }

                /// <summary>
                /// <para>The amount of the used disk space. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2998996992</para>
                /// </summary>
                [NameInMap("UseSizeByte")]
                [Validation(Required=false)]
                public long? UseSizeByte { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the asset is provided by Alibaba Cloud. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The server is provided by Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: The server is not provided by Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The group to which the server belongs. By default, the servers that are not grouped belong to the <b>Default</b> group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }

            /// <summary>
            /// <para>The name of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qewrqwerqs****</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf6h7p2fgk6rkk0g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-fasdfasdfadfafa****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.47.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IP address that is assigned to the Elastic Compute Service (ECS) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.47.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>An array that consists of the IP addresses of the server.</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

            /// <summary>
            /// <para>The kernel version of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.18.0-80.11.2.el8_0.x86_64</para>
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// <para>An array that consists of the media access control (MAC) addresses of the server.</para>
            /// </summary>
            [NameInMap("MacList")]
            [Validation(Required=false)]
            public List<string> MacList { get; set; }

            /// <summary>
            /// <para>The memory size of the server. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The memory size of the server. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16384</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The operating system type of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The operating system version of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux 64bit</para>
            /// </summary>
            [NameInMap("OsDetail")]
            [Validation(Required=false)]
            public string OsDetail { get; set; }

            /// <summary>
            /// <para>The name of the operating system that the server runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS  7.4 64bit</para>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hohhot)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The operating system information about the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS Linux 8.0.1905</para>
            /// </summary>
            [NameInMap("SysInfo")]
            [Validation(Required=false)]
            public string SysInfo { get; set; }

            /// <summary>
            /// <para>The tag that is added to the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetIp</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e6cad93-a379-46fd-a701-9bbf02f4****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("VendorAuthAlias")]
            [Validation(Required=false)]
            public string VendorAuthAlias { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1fs3bwonlfq503w****</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4892B68B-47BC-5E56-B327-9C2ACC6C1C09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
