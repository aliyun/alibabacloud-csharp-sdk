// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyResult> Result { get; set; }
        public class ListInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// The billing method.
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The commodity code of the instance.
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The time when the instance was created.
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
            /// The description of the instance.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// The time when the instance expires.
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// Indicates whether an overdue payment is involved.
            /// </summary>
            [NameInMap("inDebt")]
            [Validation(Required=false)]
            public bool? InDebt { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The lock state of the instance.
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// The network information of the instance.
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyResultNetwork Network { get; set; }
            public class ListInstancesResponseBodyResultNetwork : TeaModel {
                [NameInMap("allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                /// <summary>
                /// The instance endpoint.
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) in which the instance is deployed.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("noQrs")]
            [Validation(Required=false)]
            public bool? NoQrs { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyResultSpec Spec { get; set; }
            public class ListInstancesResponseBodyResultSpec : TeaModel {
                [NameInMap("qrsResource")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyResultSpecQrsResource QrsResource { get; set; }
                public class ListInstancesResponseBodyResultSpecQrsResource : TeaModel {
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

                [NameInMap("searchResource")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyResultSpecSearchResource SearchResource { get; set; }
                public class ListInstancesResponseBodyResultSpecSearchResource : TeaModel {
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

            }

            /// <summary>
            /// The instance status.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the instance.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyResultTags> Tags { get; set; }
            public class ListInstancesResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The time when the instance was updated.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The total number of entries returned
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
