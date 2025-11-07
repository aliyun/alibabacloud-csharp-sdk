// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeExposedStatisticsDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeExposedStatisticsDetailResponseBodyPageInfo : TeaModel {
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
            /// <para>The total number of entries returned.</para>
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
        /// <para>7CBAFB3F-1ED7-4A23-986A-6F67F0466BD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array consisting of the gateway assets, ports, system components, or public IP addresses that are exposed on the Internet and are returned.</para>
        /// </summary>
        [NameInMap("StatisticsDetails")]
        [Validation(Required=false)]
        public List<DescribeExposedStatisticsDetailResponseBodyStatisticsDetails> StatisticsDetails { get; set; }
        public class DescribeExposedStatisticsDetailResponseBodyStatisticsDetails : TeaModel {
            /// <summary>
            /// <para>The total number of system vulnerabilities that are detected on your server and are exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExposedCount")]
            [Validation(Required=false)]
            public int? ExposedCount { get; set; }

            /// <summary>
            /// <para>The system component that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tomcat</para>
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// <para>The public IP address that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.57.XX.XX</para>
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
            /// <item><description><b>INTERNET_IP</b>: the IP address of the Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>SLB</b>: the public IP address of the SLB instance</description></item>
            /// <item><description><b>EIP</b>: the elastic IP address (EIP)</description></item>
            /// <item><description><b>DNAT</b>: the NAT gateway that connects to the Internet by using the DNAT feature</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLB</para>
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the value of the ExposureType parameter.</para>
            /// <list type="bullet">
            /// <item><description>If the value of the <b>ExposureType</b> parameter is <b>INTERNET_IP</b>, the value of this parameter is an empty string.</description></item>
            /// <item><description>If the value of the <b>ExposureType</b> parameter is <b>SLB</b>, the value of this parameter is the ID of the Internet-facing SLB instance.</description></item>
            /// <item><description>If the value of the <b>ExposureType</b> parameter is <b>EIP</b>, the value of this parameter is the ID of the EIP.</description></item>
            /// <item><description>If the value of the <b>ExposureType</b> parameter is <b>DNAT</b>, the value of this parameter is the ID of the NAT gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2ze4rso39h4nczcqs****</para>
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// <para>The name of the gateway asset that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1vkbju8f3w87c9v****</para>
            /// </summary>
            [NameInMap("ExposureTypeInstanceName")]
            [Validation(Required=false)]
            public string ExposureTypeInstanceName { get; set; }

            /// <summary>
            /// <para>The listener port that is used to redirect HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ForwardPort")]
            [Validation(Required=false)]
            public string ForwardPort { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
