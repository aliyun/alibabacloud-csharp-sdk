// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemPreviewRequest : TeaModel {
        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 影响服务
        /// </summary>
        [NameInMap("effectServiceIds")]
        [Validation(Required=false)]
        public List<long?> EffectServiceIds { get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 故障等级
        /// </summary>
        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        /// <summary>
        /// 通告类型
        /// </summary>
        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        /// <summary>
        /// 所属服务
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// 应急协同组
        /// </summary>
        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
