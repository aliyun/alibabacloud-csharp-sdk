// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetSubnetResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetSubnetResponseBodyContent Content { get; set; }
        public class GetSubnetResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("AvailableIps")]
            [Validation(Required=false)]
            public int? AvailableIps { get; set; }

            /// <summary>
            /// <para>The CIDR block of the Subnet.</para>
            /// <list type="bullet">
            /// <item><description>The network segment of the subnet must be a proper subset of the network segment of Lingjun to which it belongs, and the mask must be between 16 bits and 29 bits, which can provide 8 to 65536 addresses. For example, the CIDR block of the Lingjun CIDR block is 192.168.0.0/16, and the CIDR blocks of the subnets under the Lingjun CIDR block are 192.168.0.0/17 to 192.168.0.0/29.</description></item>
            /// <item><description>The first and last three IP addresses of each subnet segment are reserved by the system. For example, the CIDR blocks of the subnet are 192.168.1.0/24,192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The time when the activation code was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678273219000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The number of SLB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LbCount")]
            [Validation(Required=false)]
            public long? LbCount { get; set; }

            /// <summary>
            /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>test example</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The number of NCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("NcCount")]
            [Validation(Required=false)]
            public int? NcCount { get; set; }

            /// <summary>
            /// <para>Number of Lingjun network interface controller</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NetworkInterfaceCount")]
            [Validation(Required=false)]
            public int? NetworkInterfaceCount { get; set; }

            /// <summary>
            /// <para>The total number of secondary private IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PrivateIpCount")]
            [Validation(Required=false)]
            public long? PrivateIpCount { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of your Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2l4sq6l7unhi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the cache reserve instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the Lingjun subnet instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-aj93mko8</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>The name of the Lingjun subnet instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-1</para>
            /// </summary>
            [NameInMap("SubnetName")]
            [Validation(Required=false)]
            public string SubnetName { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// <para>You can specify up to 20 tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetSubnetResponseBodyContentTags> Tags { get; set; }
            public class GetSubnetResponseBodyContentTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                /// <para>You can specify at most 20 tag keys in each call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-subnet</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag that is added to the resource.</para>
                /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// <para>Each key-value pair must be unique. You can specify values for at most 20 tag keys in each call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-group-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655449505171</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>Lingjun Subnet Usage Type; optional; optional. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Empty for common data types</b></description></item>
            /// <item><description><b>OOB</b> :OOB type</description></item>
            /// <item><description><b>LB</b>: LB type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OOB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The information about the network segment of Lingjun.</para>
            /// </summary>
            [NameInMap("VpdBaseInfo")]
            [Validation(Required=false)]
            public GetSubnetResponseBodyContentVpdBaseInfo VpdBaseInfo { get; set; }
            public class GetSubnetResponseBodyContentVpdBaseInfo : TeaModel {
                /// <summary>
                /// <para>The CIDR block of the VPD.</para>
                /// <list type="bullet">
                /// <item><description>We recommend that you use an RFC private endpoint as the Lingjun CIDR block, such as 10.0.0.0/8,172.16.0.0/12,192.168.0.0/16. In scenarios where the Doringjun CIDR block is connected to each other or where the Lingjun CIDR block is connected to a VPC, make sure that the addresses do not conflict with each other.</description></item>
                /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 and their subnets as the primary IPv4 CIDR block of the VPD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The time when the activation code was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Lingjun CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-iv2zm1qf</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>The name of the Lingjun CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-1</para>
                /// </summary>
                [NameInMap("VpdName")]
                [Validation(Required=false)]
                public string VpdName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Lingjun CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-ze3na0wf</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0901F411-28FA-5B9C-BAEE-7776463FF0DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
