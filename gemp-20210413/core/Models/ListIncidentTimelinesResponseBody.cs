// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentTimelinesResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentTimelinesResponseBodyData> Data { get; set; }
        public class ListIncidentTimelinesResponseBodyData : TeaModel {
            /// <summary>
            /// 动态
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public long? Description { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 服务名称
            /// </summary>
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 事件标题
            /// </summary>
            [NameInMap("incidentTitle")]
            [Validation(Required=false)]
            public string IncidentTitle { get; set; }

            /// <summary>
            /// 动态类型  触发新增 INCIDENT_ADD 响应 INCIDENT_RESPONSE 转交 INCIDENT_DELIVER 变更 INCIDENT_UPDATE 添加小计 INCIDENT_ADD_SUBTOTAL 完结 INCIDENT_FINISH 分配 INCIDENT_ASSIGN 升级 INCIDENT_UPGRAD
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// 事件Id
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
