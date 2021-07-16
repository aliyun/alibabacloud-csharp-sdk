// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentDetailTimelinesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentDetailTimelinesResponseBodyData> Data { get; set; }
        public class ListIncidentDetailTimelinesResponseBodyData : TeaModel {
            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// 事件Id
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            /// <summary>
            /// 事件action
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

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
