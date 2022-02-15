// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentsRequest : TeaModel {
        /// <summary>
        /// 幂等校验id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 影响等级 高：HIGH 低 LOW
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// 事件级别 P1 P2 P3 P4
        /// </summary>
        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        /// <summary>
        /// 事件状态 ASSIGNED已分派 RESPONDED已响应  FINISHED已完结
        /// </summary>
        [NameInMap("incidentStatus")]
        [Validation(Required=false)]
        public string IncidentStatus { get; set; }

        /// <summary>
        /// 是否自己 1是 0不是
        /// </summary>
        [NameInMap("me")]
        [Validation(Required=false)]
        public int? Me { get; set; }

        /// <summary>
        /// 页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 行
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 关联服务ID
        /// </summary>
        [NameInMap("relationServiceId")]
        [Validation(Required=false)]
        public long? RelationServiceId { get; set; }

        /// <summary>
        /// 流转规则名字
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
