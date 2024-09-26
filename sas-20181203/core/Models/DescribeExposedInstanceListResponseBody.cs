// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details about the exposed asset.</para>
        /// </summary>
        [NameInMap("ExposedInstances")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceListResponseBodyExposedInstances> ExposedInstances { get; set; }
        public class DescribeExposedInstanceListResponseBodyExposedInstances : TeaModel {
            /// <summary>
            /// <para>The number of high-severity vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AsapVulCount")]
            [Validation(Required=false)]
            public int? AsapVulCount { get; set; }

            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("CloudAssetInfo")]
            [Validation(Required=false)]
            public string CloudAssetInfo { get; set; }

            [NameInMap("CspmAlarmCount")]
            [Validation(Required=false)]
            public int? CspmAlarmCount { get; set; }

            /// <summary>
            /// <para>The total number of servers that are exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExploitHealthCount")]
            [Validation(Required=false)]
            public int? ExploitHealthCount { get; set; }

            /// <summary>
            /// <para>The server component that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl,openssh</para>
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// <para>The public IP address that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.12.XX.XX</para>
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// <para>The port that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// <para>The resource from which the asset is exposed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INTERNET_IP</b>: the public IP address of an ECS instance</description></item>
            /// <item><description><b>SLB</b>: the public IP address of a Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>EIP</b>: an elastic IP address (EIP)</description></item>
            /// <item><description><b>DNAT</b>: the NAT gateway that connects to the Internet by using the DNAT feature</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET_IP</para>
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the ExposureType parameter.</para>
            /// <list type="bullet">
            /// <item><description>If the value of the ExposureType parameter is <b>INTERNET_IP</b>, this parameter is empty.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>SLB</b>, the value of this parameter is the ID of the SLB instance.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>EIP</b>, the value of this parameter is the ID of the EIP.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>DNAT</b>, the value of this parameter is the ID of the NAT gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-ew11313a****</para>
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// <para>The ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9469268</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1g6wxdwps7s9dz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc_centos7.2_005</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.12.XX.XX</para>
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
            /// <para>The number of medium-severity vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LaterVulCount")]
            [Validation(Required=false)]
            public int? LaterVulCount { get; set; }

            /// <summary>
            /// <para>The number of low-severity vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NntfVulCount")]
            [Validation(Required=false)]
            public int? NntfVulCount { get; set; }

            /// <summary>
            /// <para>The ID of the region where the server resides.</para>
            /// <remarks>
            /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The total number of vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalVulCount")]
            [Validation(Required=false)]
            public int? TotalVulCount { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dd803d9e-a337-4add-9c5b-7d503e08****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeExposedInstanceListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeExposedInstanceListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries about the servers that are exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>598A4A61-ABA7-456B-8725-7378258276D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
