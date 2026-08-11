// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89B968E6-1E41-58DF-BB25-5F98ECC759CE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyResult> Result { get; set; }
        public class ListInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch_ha3post_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-04T02:03:21Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dataSourceDetails")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyResultDataSourceDetails> DataSourceDetails { get; set; }
            public class ListInstancesResponseBodyResultDataSourceDetails : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyResultDataSourceDetailsConfig Config { get; set; }
                public class ListInstancesResponseBodyResultDataSourceDetailsConfig : TeaModel {
                    [NameInMap("accessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    [NameInMap("bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    [NameInMap("database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    [NameInMap("ossPath")]
                    [Validation(Required=false)]
                    public string OssPath { get; set; }

                    [NameInMap("partition")]
                    [Validation(Required=false)]
                    public string Partition { get; set; }

                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The edition of the instance.vector: Vector Search Editionengine: Retrieval Engine Edition</para>
            /// 
            /// <b>Example:</b>
            /// <para>vector</para>
            /// </summary>
            [NameInMap("edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634885083</para>
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has an overdue payment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("inDebt")]
            [Validation(Required=false)]
            public bool? InDebt { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The network information of the search engine instance.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyResultNetwork Network { get; set; }
            public class ListInstancesResponseBodyResultNetwork : TeaModel {
                /// <summary>
                /// <para>The whitelist for the public domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                /// <summary>
                /// <para>The gateway endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3r****.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The public domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3ni****.public.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// <para>The ID of the virtual switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp11ldcf59q2n****</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz9axk41d9vff****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the instance is a standalone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("noQrs")]
            [Validation(Required=false)]
            public bool? NoQrs { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The specifications of the nodes.</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyResultSpec Spec { get; set; }
            public class ListInstancesResponseBodyResultSpec : TeaModel {
                /// <summary>
                /// <para>The specifications of the query nodes.</para>
                /// </summary>
                [NameInMap("qrsResource")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyResultSpecQrsResource QrsResource { get; set; }
                public class ListInstancesResponseBodyResultSpecQrsResource : TeaModel {
                    /// <summary>
                    /// <para>The instance type. Valid values:local_ssd: local solid-state drive (SSD)cloud: disk</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage space of the node in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory size in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

                /// <summary>
                /// <para>The specifications of the data nodes.</para>
                /// </summary>
                [NameInMap("searchResource")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyResultSpecSearchResource SearchResource { get; set; }
                public class ListInstancesResponseBodyResultSpecSearchResource : TeaModel {
                    /// <summary>
                    /// <para>The instance type. Valid values:local_ssd: local SSDcloud: disk</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage space of the node in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory size in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyResultTags> Tags { get; set; }
            public class ListInstancesResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-06T11:17:49.0</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The version of the engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha3_3.10.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
