// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyResult Result { get; set; }
        public class GetInstanceResponseBodyResult : TeaModel {
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
            /// The lock status.
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("network")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyResultNetwork Network { get; set; }
            public class GetInstanceResponseBodyResultNetwork : TeaModel {
                [NameInMap("allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("newMode")]
            [Validation(Required=false)]
            public bool? NewMode { get; set; }

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
            public GetInstanceResponseBodyResultSpec Spec { get; set; }
            public class GetInstanceResponseBodyResultSpec : TeaModel {
                [NameInMap("qrsResource")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyResultSpecQrsResource QrsResource { get; set; }
                public class GetInstanceResponseBodyResultSpecQrsResource : TeaModel {
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
                public GetInstanceResponseBodyResultSpecSearchResource SearchResource { get; set; }
                public class GetInstanceResponseBodyResultSpecSearchResource : TeaModel {
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
            /// The status of the instance. Valid values:
            /// 
            /// *   INIT: being initialized
            /// *   WAIT_CONFIG: to be configured
            /// *   CONFIG_UPDATING: configuration taking effect
            /// *   READY: normal
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the instance.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyResultTags> Tags { get; set; }
            public class GetInstanceResponseBodyResultTags : TeaModel {
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

    }

}
