// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertySoftwareDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Information displayed on the query result page.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertySoftwareDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertySoftwareDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of fingerprint information of software assets displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page during pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The NextToken value returned using the NextToken method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of software asset fingerprint information displayed per page when performing a paginated query. The default value is <b>10</b>, indicating that 10 pieces of software asset fingerprint information are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of fingerprint information for the queried software assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Details list of the queried software asset\&quot;s fingerprint information.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertySoftwareDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertySoftwareDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The timestamp of the latest scan of the asset fingerprint. The unit is milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The installation time of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-07 10:54:49</para>
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public string InstallTime { get; set; }

            /// <summary>
            /// <para>The installation timestamp of the software. The unit is in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649066826000</para>
            /// </summary>
            [NameInMap("InstallTimeDt")]
            [Validation(Required=false)]
            public long? InstallTimeDt { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc-host-****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>List of server IPs</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The name of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa_base</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The installation directory information of the software asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/etc/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162eb349-c2d9-4f8b-805c-75b43d4c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The version information of the software asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.10.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the current request, generated by Alibaba Cloud as a unique identifier for the request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AEE7412-0065-1135-B790-AE2C38BA68FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
