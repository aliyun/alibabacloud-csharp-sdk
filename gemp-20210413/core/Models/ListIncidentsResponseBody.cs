// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentsResponseBodyData> Data { get; set; }
        public class ListIncidentsResponseBodyData : TeaModel {
            [NameInMap("assignToWhoIsValid")]
            [Validation(Required=false)]
            public long? AssignToWhoIsValid { get; set; }

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("assignUserId")]
            [Validation(Required=false)]
            public long? AssignUserId { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("assignUserName")]
            [Validation(Required=false)]
            public string AssignUserName { get; set; }

            [NameInMap("assignUserPhone")]
            [Validation(Required=false)]
            public string AssignUserPhone { get; set; }

            /// <summary>
            /// 事件级别
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 时间指派人ID
            /// </summary>
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            /// <summary>
            /// 影响程度
            /// </summary>
            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }

            /// <summary>
            /// 关联流转规则ID
            /// </summary>
            [NameInMap("incidentStatus")]
            [Validation(Required=false)]
            public string IncidentStatus { get; set; }

            /// <summary>
            /// 事件内容
            /// </summary>
            [NameInMap("incidentTitle")]
            [Validation(Required=false)]
            public string IncidentTitle { get; set; }

            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            [NameInMap("relRouteRuleDeleteType")]
            [Validation(Required=false)]
            public int? RelRouteRuleDeleteType { get; set; }

            [NameInMap("relServiceDeleteType")]
            [Validation(Required=false)]
            public int? RelServiceDeleteType { get; set; }

            /// <summary>
            /// 事件状态
            /// </summary>
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 关联的服务ID
            /// </summary>
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            [NameInMap("routeRuleName")]
            [Validation(Required=false)]
            public string RouteRuleName { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
