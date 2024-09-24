// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The server ID.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The status of the host network extension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: online</description></item>
            /// <item><description><b>false</b>: offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AliNetOnline")]
            [Validation(Required=false)]
            public bool? AliNetOnline { get; set; }

            /// <summary>
            /// <para>The blocking type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>group</b>: security group</description></item>
            /// <item><description><b>alinet</b>: host network extension</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public string BlockType { get; set; }

            /// <summary>
            /// <para>The error code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliNetNotOnline</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myInstance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.62.121.1xx</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.xx</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled for the server.</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: enabling failed</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The information that is returned after brute-force attacks are blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;aliUid&quot;:*******,&quot;groupId&quot;:&quot;sg-xxxx&quot;,&quot;groupName&quot;:&quot;Sas_Malicious_Ip_Security_Group&quot;,&quot;groupType&quot;:&quot;normal&quot;,&quot;instanceId&quot;:&quot;i-xxxx&quot;,&quot;regionId&quot;:&quot;cn-shenzhen&quot;,&quot;vpcId&quot;:&quot;vpc-xxxxxxxx&quot;}</para>
            /// </summary>
            [NameInMap("SuccessInfo")]
            [Validation(Required=false)]
            public string SuccessInfo { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2d6e901-1004-4ca8-9dae-53ec04a9****</para>
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
        public DescribeCustomBlockInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of servers to which the defense rule is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D81DD78E-E006-5C65-A171-C8CB09XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
