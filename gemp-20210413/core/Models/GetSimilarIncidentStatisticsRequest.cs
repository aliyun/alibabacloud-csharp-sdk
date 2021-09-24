// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSimilarIncidentStatisticsRequest : TeaModel {
        /// <summary>
        /// 事件id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 事件标题
        /// </summary>
        [NameInMap("incidentTitle")]
        [Validation(Required=false)]
        public string IncidentTitle { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 关联服务id
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// 事件告警内容
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
