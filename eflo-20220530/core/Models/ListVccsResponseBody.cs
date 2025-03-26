// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccsResponseBody : TeaModel {
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
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVccsResponseBodyContent Content { get; set; }
        public class ListVccsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Lingjun Connection Information List</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVccsResponseBodyContentData> Data { get; set; }
            public class ListVccsResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>Express Connect circuit access point ID:</para>
                /// <list type="bullet">
                /// <item><description><b>ap-cn-wulanchabu-jn-ts-A</b>: Ulanqab-Jining-A</description></item>
                /// <item><description><b>ap-cn-heyuan-yc-ts-SA127</b>: Heyuan-Yuancheng-A</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-wulanchabu-jn-ts-A</para>
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// <para>The bandwidth of the port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BandwidthStr")]
                [Validation(Required=false)]
                public string BandwidthStr { get; set; }

                /// <summary>
                /// <para>bgp as number</para>
                /// 
                /// <b>Example:</b>
                /// <para>bgpAsn</para>
                /// </summary>
                [NameInMap("BgpAsn")]
                [Validation(Required=false)]
                public string BgpAsn { get; set; }

                /// <summary>
                /// <para>bgp network segment</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.128.0/24</para>
                /// </summary>
                [NameInMap("BgpCidr")]
                [Validation(Required=false)]
                public string BgpCidr { get; set; }

                /// <summary>
                /// <para>The ID of the CEN instance; <a href="https://help.aliyun.com/document_detail/181681.html">What is the CEN?</a></para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/468215.htm">DescribeCens</a> to query the information of CEN instances under the current Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-w15qot0pfvs83pkckj</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>Account to which cen belongs</para>
                /// 
                /// <b>Example:</b>
                /// <para>1238685214107736</para>
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public string CenOwnerId { get; set; }

                /// <summary>
                /// <para>Commodity code</para>
                /// 
                /// <b>Example:</b>
                /// <para>bccluster_cloudconnectionpre_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The connection mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b></description></item>
                /// <item><description><b>CENTR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CENTR</para>
                /// </summary>
                [NameInMap("ConnectionType")]
                [Validation(Required=false)]
                public string ConnectionType { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Current process node</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-xxxx-node-x</para>
                /// </summary>
                [NameInMap("CurrentNode")]
                [Validation(Required=false)]
                public string CurrentNode { get; set; }

                /// <summary>
                /// <para>List of bound Lingjun HUB information</para>
                /// </summary>
                [NameInMap("ErInfos")]
                [Validation(Required=false)]
                public List<ListVccsResponseBodyContentDataErInfos> ErInfos { get; set; }
                public class ListVccsResponseBodyContentDataErInfos : TeaModel {
                    /// <summary>
                    /// <para>Connections</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Connections")]
                    [Validation(Required=false)]
                    public long? Connections { get; set; }

                    /// <summary>
                    /// <para>The time when the data address was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1678273219000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>Description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_api_coverage</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Elastic Router ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>er-a7rqv1rq</para>
                    /// </summary>
                    [NameInMap("ErId")]
                    [Validation(Required=false)]
                    public string ErId { get; set; }

                    /// <summary>
                    /// <para>ER instance name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>er-1</para>
                    /// </summary>
                    [NameInMap("ErName")]
                    [Validation(Required=false)]
                    public string ErName { get; set; }

                    /// <summary>
                    /// <para>The time when the agent was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1678273219000</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>Primary Zone</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-wulanchabu-b</para>
                    /// </summary>
                    [NameInMap("MasterZoneId")]
                    [Validation(Required=false)]
                    public string MasterZoneId { get; set; }

                    /// <summary>
                    /// <para>The message that is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>ER region information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-wulanchabu</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>Number of routing policy</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("RouteMaps")]
                    [Validation(Required=false)]
                    public long? RouteMaps { get; set; }

                    /// <summary>
                    /// <para>The status of the intervention entry. Valid value:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1620939556166277</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                }

                /// <summary>
                /// <para>The time when the application expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CO</para>
                /// </summary>
                [NameInMap("LineOperator")]
                [Validation(Required=false)]
                public string LineOperator { get; set; }

                /// <summary>
                /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>some message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The port type of the Express Connect circuit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>100GBase-LR</b>: 100,000 megabytes of single-mode optical port (10 km)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>100GBase-LR</para>
                /// </summary>
                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

                /// <summary>
                /// <para>Process progress; value returns 0 to 1; not started is null</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

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
                /// <para>The compute specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Large</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The state of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag information.</para>
                /// <para>You can specify up to 20 tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListVccsResponseBodyContentDataTags> Tags { get; set; }
                public class ListVccsResponseBodyContentDataTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                    /// <para>You can specify at most 20 tag keys in each call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tag-vcc</para>
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
                    /// <para>vcc-group-1</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-cd544092-ed0a-49e9-83eb-e8c94770dccf</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166279</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The ID of the Lingjun connection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-zvp2w222001</para>
                /// </summary>
                [NameInMap("VccId")]
                [Validation(Required=false)]
                public string VccId { get; set; }

                /// <summary>
                /// <para>The name of the Lingjun connection instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-heyuan-backup</para>
                /// </summary>
                [NameInMap("VccName")]
                [Validation(Required=false)]
                public string VccName { get; set; }

                /// <summary>
                /// <para>Virtual Private Cloud IDs; <a href="https://help.aliyun.com/document_detail/34217.html">What is Virtual Private Cloud</a></para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html#demo-0">DescribeVpcs</a> operation to query the specified VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-f8ziirfl9k25h2qn7y4f8</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>Lingjun network segment information (applicable to the scene where the old version of Lingjun connection is directly bound to Lingjun network segment)</para>
                /// </summary>
                [NameInMap("VpdBaseInfo")]
                [Validation(Required=false)]
                public ListVccsResponseBodyContentDataVpdBaseInfo VpdBaseInfo { get; set; }
                public class ListVccsResponseBodyContentDataVpdBaseInfo : TeaModel {
                    /// <summary>
                    /// <para>The CIDR block of the VPD.</para>
                    /// <list type="bullet">
                    /// <item><description>We recommend that you use an RFC private endpoint as the Lingjun CIDR block, such as 10.0.0.0/8,172.16.0.0/12,192.168.0.0/16. In scenarios where the Doringjun CIDR block is connected to each other or where the Lingjun CIDR block is connected to a VPC, make sure that the addresses do not conflict with each other.</description></item>
                    /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 and their subnets as the primary IPv4 CIDR block of the VPD.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.0/13</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The time when the data address was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1668158213000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>Lingjun CIDR block instance ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpd-9n7ioqrp</para>
                    /// </summary>
                    [NameInMap("VpdId")]
                    [Validation(Required=false)]
                    public string VpdId { get; set; }

                    /// <summary>
                    /// <para>Lingjun CIDR block instance name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yzp-rg-test3</para>
                    /// </summary>
                    [NameInMap("VpdName")]
                    [Validation(Required=false)]
                    public string VpdName { get; set; }

                }

                /// <summary>
                /// <para>Lingjun CIDR block instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-eoiy88ju</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>28451248-7038-5184-B5D3-80F104654BE8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
