// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListEscalationPlansResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListEscalationPlansResponseBodyData> Data { get; set; }
        public class ListEscalationPlansResponseBodyData : TeaModel {
            /// <summary>
            /// 升级计划id
            /// </summary>
            [NameInMap("escalationPlanId")]
            [Validation(Required=false)]
            public long? EscalationPlanId { get; set; }

            /// <summary>
            /// 升级计划名称
            /// </summary>
            [NameInMap("escalationPlanName")]
            [Validation(Required=false)]
            public string EscalationPlanName { get; set; }

            /// <summary>
            /// 升级计划范围对象
            /// </summary>
            [NameInMap("escalationPlanScopeObjects")]
            [Validation(Required=false)]
            public List<ListEscalationPlansResponseBodyDataEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
            public class ListEscalationPlansResponseBodyDataEscalationPlanScopeObjects : TeaModel {
                /// <summary>
                /// 范围对象类型
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// 范围对象id（服务id）
                /// </summary>
                [NameInMap("scopeObjectId")]
                [Validation(Required=false)]
                public long? ScopeObjectId { get; set; }

                /// <summary>
                /// 范围对象名称
                /// </summary>
                [NameInMap("scopeObjectName")]
                [Validation(Required=false)]
                public string ScopeObjectName { get; set; }

            }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 启用ENABLE 禁用DISABLE
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
