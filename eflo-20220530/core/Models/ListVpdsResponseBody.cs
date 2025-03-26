// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVpdsResponseBody : TeaModel {
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
        public ListVpdsResponseBodyContent Content { get; set; }
        public class ListVpdsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVpdsResponseBodyContentData> Data { get; set; }
            public class ListVpdsResponseBodyContentData : TeaModel {
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
                /// <para>Dependencies.</para>
                /// </summary>
                [NameInMap("Dependence")]
                [Validation(Required=false)]
                public Dictionary<string, object> Dependence { get; set; }

                /// <summary>
                /// <para>The information list of the bound Lingjun HUB(ER).</para>
                /// </summary>
                [NameInMap("ErInfos")]
                [Validation(Required=false)]
                public List<ListVpdsResponseBodyContentDataErInfos> ErInfos { get; set; }
                public class ListVpdsResponseBodyContentDataErInfos : TeaModel {
                    /// <summary>
                    /// <para>The number of connections.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Connections")]
                    [Validation(Required=false)]
                    public long? Connections { get; set; }

                    /// <summary>
                    /// <para>The time when the activation code was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-12-26 20:16:36</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The description of the synchronization task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No description</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The ID of the Elastic Router (ER) instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>er-63vzm0fw</para>
                    /// </summary>
                    [NameInMap("ErId")]
                    [Validation(Required=false)]
                    public string ErId { get; set; }

                    /// <summary>
                    /// <para>The name of the Lingjun HUB(ER) instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>er-1</para>
                    /// </summary>
                    [NameInMap("ErName")]
                    [Validation(Required=false)]
                    public string ErName { get; set; }

                    /// <summary>
                    /// <para>The time when the O\&amp;M task was modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-12-26 20:16:36</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The primary zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-wulanchabu-b</para>
                    /// </summary>
                    [NameInMap("MasterZoneId")]
                    [Validation(Required=false)]
                    public string MasterZoneId { get; set; }

                    /// <summary>
                    /// <para>The returned message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The supported region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-wulanchabu</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The number of routing policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("RouteMaps")]
                    [Validation(Required=false)]
                    public long? RouteMaps { get; set; }

                    /// <summary>
                    /// <para>The task status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1620939556166277</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                }

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
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>nc quantity.</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetworkInterfaceCount")]
                [Validation(Required=false)]
                public int? NetworkInterfaceCount { get; set; }

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
                /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.htm?spm=a2c4g.11186623.0.0.29e15d7akXhpuu">Resource groups</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2l4sq6l7unhi</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The list of additional CIDR blocks.</para>
                /// </summary>
                [NameInMap("SecondaryCidrBlocks")]
                [Validation(Required=false)]
                public List<string> SecondaryCidrBlocks { get; set; }

                /// <summary>
                /// <para>The Service CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.252.0/23</para>
                /// </summary>
                [NameInMap("ServiceCidr")]
                [Validation(Required=false)]
                public string ServiceCidr { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of subnets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubnetCount")]
                [Validation(Required=false)]
                public int? SubnetCount { get; set; }

                /// <summary>
                /// <para>The tag information.</para>
                /// <para>You can specify up to 20 tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListVpdsResponseBodyContentDataTags> Tags { get; set; }
                public class ListVpdsResponseBodyContentDataTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                    /// <para>You can specify at most 20 tag keys in each call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tag-vpd-region</para>
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
                    /// <para>cn-wulanchabu</para>
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
                /// <para>The ID of the VPD instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-lg4dppgi</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>The name of the VPD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-1</para>
                /// </summary>
                [NameInMap("VpdName")]
                [Validation(Required=false)]
                public string VpdName { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
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
        /// <para>9C50C9CD-E799-54DA-BA7A-1FAF3DF80857</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
