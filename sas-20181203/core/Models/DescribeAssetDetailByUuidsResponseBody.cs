// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetDetailByUuidsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the instances.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeAssetDetailByUuidsResponseBodyAssetList> AssetList { get; set; }
        public class DescribeAssetDetailByUuidsResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The type of the asset.</para>
            /// <para>The value is fixed as <b>0</b>, which indicates ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The timestamp when Security Center is authorized to protect the instance. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627974044000</para>
            /// </summary>
            [NameInMap("AuthModifyTime")]
            [Validation(Required=false)]
            public long? AuthModifyTime { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that is authorized to protect the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic edition (Unauthorized)</description></item>
            /// <item><description><b>6</b>: Anti-virus edition</description></item>
            /// <item><description><b>5</b>: Advanced edition</description></item>
            /// <item><description><b>3</b>: Enterprise edition</description></item>
            /// <item><description><b>7</b>: Ultimate edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to protect the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>online</b></description></item>
            /// <item><description><b>offline</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

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
            /// <para>4</para>
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
            /// <para>The timestamp when Security Center records the details of the instance. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603863599000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>An array that consists of the information about the disk.</para>
            /// </summary>
            [NameInMap("DiskInfoList")]
            [Validation(Required=false)]
            public List<string> DiskInfoList { get; set; }

            /// <summary>
            /// <para>The type of the asset by source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The asset is provided by Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: The asset is not provided by Alibaba Cloud.</description></item>
            /// <item><description><b>2</b>: The asset resides in a data center.</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset.</description></item>
            /// <item><description><b>8</b>: light-weight assets.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            /// <summary>
            /// <para>The group to which the instance belongs. By default, the instances that are not grouped belong to the <b>Default</b> group.</para>
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
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-rj9gda4wolo0zixi****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestInstanceName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IP address of the ECS instance.</para>
            /// <remarks>
            /// <para> If the ECS instance has a public IP address, the value of this parameter is the public IP address of the ECS instance. If the ECS instance does not have a public IP address, the value of this parameter is the private IP address of the ECS instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP addresses of the instances.</para>
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
            /// <para>The media access control (MAC) addresses of the instances.</para>
            /// </summary>
            [NameInMap("MacList")]
            [Validation(Required=false)]
            public List<string> MacList { get; set; }

            /// <summary>
            /// <para>The memory size of the instance. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The memory size of the instance. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The operating system of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The operating system version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux 64bit</para>
            /// </summary>
            [NameInMap("OsDetail")]
            [Validation(Required=false)]
            public string OsDetail { get; set; }

            /// <summary>
            /// <para>The name of the operating system run by the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS 7.6 64-bit</para>
            /// </summary>
            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>The region in which the ECS instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The region in which the ECS instance resides.</para>
            /// <remarks>
            /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region in which the ECS instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The operating system information about the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS Linux 8.0.1905</para>
            /// </summary>
            [NameInMap("SysInfo")]
            [Validation(Required=false)]
            public string SysInfo { get; set; }

            /// <summary>
            /// <para>The tag added to the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The UUID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a98f149-0256-414c-a29a-a69f8a75****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>13231-331331</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92016EC8-D52D-49D8-9FF7-9EA340A950B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
