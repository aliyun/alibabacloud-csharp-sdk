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
        /// The result returned.
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
            /// The product code.
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

            /// <summary>
            /// The expiration time.
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
            /// The ID of the resource.
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

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

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
            /// 标签。
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyResultTags> Tags { get; set; }
            public class GetInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// 标签键
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 标签值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The time when the instance was last updated.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
