// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetDetailByUuidsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset details.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeAssetDetailByUuidsResponseBodyAssetList> AssetList { get; set; }
        public class DescribeAssetDetailByUuidsResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The type of the asset.</para>
            /// <para>The only valid value is <b>0</b>, which indicates an ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The timestamp when the asset authorization was bound. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627974044000</para>
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// <para>The authorization version of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition (unauthorized)</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is bound to an authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: bound to an authorization</description></item>
            /// <item><description><b>false</b>: not bound to an authorization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The status of the China China China agent client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: online</description></item>
            /// <item><description><b>offline</b>: offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The version of the agent client.</para>
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
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The CPU details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intel(R) Xeon(R) Platinum 8163 CPU @ 2.50GHz</para>
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// <para>The timestamp when Security Center recorded the asset information. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603863599000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of disk information.</para>
            /// </summary>
            [NameInMap("DiskInfoList")]
            [Validation(Required=false)]
            public List<string> DiskInfoList { get; set; }

            /// <summary>
            /// <para>The asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: asset outside the cloud</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
            /// <item><description><b>8</b>: lightweight asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The group to which the server belongs. Servers that are not assigned to a group belong to the <b>Ungrouped</b> group by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupTrace")]
            [Validation(Required=false)]
            public string GroupTrace { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-rj9gda4wolo0zixi****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestInstanceName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
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
            /// <para>The IP address of the server.</para>
            /// <remarks>
            /// <para>If a public IP address exists, this value is the public IP address. If no public IP address exists but a private IP address exists, this value is the private IP address.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The list of IP addresses of the server.</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public List<string> IpList { get; set; }

            /// <summary>
            /// <para>The Milvus version of the operating system kernel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.18.0-80.11.2.el8_0.x86_64</para>
            /// </summary>
            [NameInMap("Kernel")]
            [Validation(Required=false)]
            public string Kernel { get; set; }

            /// <summary>
            /// <para>The list of MAC addresses.</para>
            /// </summary>
            [NameInMap("MacList")]
            [Validation(Required=false)]
            public List<string> MacList { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The operating system type of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The operating system version and architecture of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux 64bit</para>
            /// </summary>
            [NameInMap("OsDetail")]
            [Validation(Required=false)]
            public string OsDetail { get; set; }

            /// <summary>
            /// <para>The name of the operating system of the server asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS  7.6 64位</para>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The region in which the server resides.</para>
            /// <remarks>
            /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The operating system information of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS Linux 8.0.1905</para>
            /// </summary>
            [NameInMap("SysInfo")]
            [Validation(Required=false)]
            public string SysInfo { get; set; }

            /// <summary>
            /// <para>The tag of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a98f149-0256-414c-a29a-a69f8a75****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The VPC-connected instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13231-331331</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92016EC8-D52D-49D8-9FF7-9EA340A950B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
