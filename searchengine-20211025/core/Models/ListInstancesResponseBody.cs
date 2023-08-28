// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyResult> Result { get; set; }
        public class ListInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the resource group to which the instance belongs.
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The total number of entries returned
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// Havenask instance
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the virtual switch
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the Virtual Private Cloud (VPC) network
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The ID of the request
            /// </summary>
            [NameInMap("inDebt")]
            [Validation(Required=false)]
            public bool? InDebt { get; set; }

            /// <summary>
            /// The access point of the gateway
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Emergency test
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// The lock status
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyResultNetwork Network { get; set; }
            public class ListInstancesResponseBodyResultNetwork : TeaModel {
                /// <summary>
                /// 353490
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// ### Sample responses
                /// 
                /// **Sample success responses**
                /// 
                ///     {
                ///         "requestId": "90D6B8F5-FE97-4509-9AAB-367836C51818",
                ///         "result": [
                ///             {
                ///                 "instanceId": "igraph-cn-xxxxxx1",
                ///                 "spec": {
                ///                     "password": "passwd",
                ///                     "searchResource": {
                ///                         "disk": 50,
                ///                         "mem": 8,
                ///                         "cpu": 2,
                ///                         "nodeCount": 2
                ///                     },
                ///                     "instanceName": "testInstance",
                ///                     "vSwitchId": "vswitch_id_xxx",
                ///                     "vpcId": "vpc_id_xxx",
                ///                     "qrsResource": {
                ///                         "disk": 50,
                ///                         "mem": 8,
                ///                         "cpu": 2,
                ///                         "nodeCount": 2
                ///                     },
                ///                     "region": "cn-hangzhou",
                ///                     "userName": "user"
                ///                 },
                ///                 "status": {
                ///                     "phase": "PENDING",
                ///                     "instancePhase": "INIT",
                ///                     "createSuccess": false
                ///                 }
                ///             },
                ///             {
                ///                 "instanceId": "igraph-cn-xxxxxx2",
                ///                 "spec": {
                ///                     "password": "passwd",
                ///                     "searchResource": {
                ///                         "disk": 50,
                ///                         "mem": 8,
                ///                         "cpu": 2,
                ///                         "nodeCount": 2
                ///                     },
                ///                     "instanceName": "testInstance",
                ///                     "vSwitchId": "vswitch_id_xxx",
                ///                     "vpcId": "vpc_id_xxx",
                ///                     "qrsResource": {
                ///                         "disk": 50,
                ///                         "mem": 8,
                ///                         "cpu": 2,
                ///                         "nodeCount": 2
                ///                     },
                ///                     "region": "cn-hangzhou",
                ///                     "userName": "user"
                ///                 },
                ///                 "status": {
                ///                     "phase": "PENDING",
                ///                     "instancePhase": "INIT",
                ///                     "createSuccess": false
                ///                 }
                ///             }
                ///         ],
                ///         "totalCount": 20
                ///     }
                /// 
                /// **Sample error responses**
                /// 
                ///     {
                ///       "requestId": "BD1EA715-DF6F-06C2-004C-C1FA0D3A9820",
                ///       "httpCode": 404,
                ///       "code": "App.NotFound",
                ///       "message": "App not found"
                ///     }
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// Queries instances.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The number of entries to return on each page. Valid values: 1 to 50. Default value: 10.
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The expiration time
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyResultTags> Tags { get; set; }
            public class ListInstancesResponseBodyResultTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The time when the instance was last updated
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
