// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyResult Result { get; set; }
        public class GetInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// 付费类型
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// 商品code
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// WB01240825
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// 是否欠费
            /// </summary>
            [NameInMap("inDebt")]
            [Validation(Required=false)]
            public bool? InDebt { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 锁定状态
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// ### Sample responses
            /// 
            /// **Sample success responses**
            /// 
            ///     {
            ///       "requestId": "90D6B8F5-FE97-4509-9AAB-367836C51818",
            ///       "result": 
            ///       {
            ///         "instanceId":"fadsfsafs",
            ///         "inDebt":true,
            ///         "lockMode":"Unlock",
            ///         "expiredTime":"asdfas",
            ///         "updateTime":"dfasf",
            ///         "createTime":"dfasf",
            ///         "resourceGroupId":"resourceGroupID",
            ///         "commodityCode":"commodityCode",
            ///         "chargeType":"POSYPAY",
            ///         "description":"this is description",
            ///         "apiVersion": "tisplus/v1",
            ///         "network": {
            ///           "vSwitchId": "vswitch_id_xxx",
            ///           "vpcId": "vpc_id_xxx",	  
            ///         },
            ///         "userName": "user",
            ///         "spec": {
            ///           "searchResource": {
            ///             "disk": 50,
            ///             "mem": 8,
            ///             "cpu": 2,
            ///             "nodeCount": 2
            ///           },
            ///           "qrsResource": {
            ///             "disk": 50,
            ///             "mem": 8,
            ///             "cpu": 2,
            ///             "nodeCount": 2
            ///           }
            ///         },
            ///        "status": "INIT",
            ///       }
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
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyResultTags> Tags { get; set; }
            public class GetInstanceResponseBodyResultTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
