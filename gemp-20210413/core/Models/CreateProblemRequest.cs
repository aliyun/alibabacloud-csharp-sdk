// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemRequest : TeaModel {
        /// <summary>
        /// 影响服务列表
        /// </summary>
        [NameInMap("affectServiceIds")]
        [Validation(Required=false)]
        public List<long?> AffectServiceIds { get; set; }

        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 发现时间 (XXXX-XX-XX 00:00:00)
        /// </summary>
        [NameInMap("discoverTime")]
        [Validation(Required=false)]
        public string DiscoverTime { get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 主要处理人
        /// </summary>
        [NameInMap("mainHandlerId")]
        [Validation(Required=false)]
        public long? MainHandlerId { get; set; }

        /// <summary>
        /// 初步原因
        /// </summary>
        [NameInMap("preliminaryReason")]
        [Validation(Required=false)]
        public string PreliminaryReason { get; set; }

        /// <summary>
        /// 故障等级 1=P1 2=P2 3=P3 4=P4
        /// </summary>
        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        /// <summary>
        /// 故障名称
        /// </summary>
        [NameInMap("problemName")]
        [Validation(Required=false)]
        public string ProblemName { get; set; }

        /// <summary>
        /// 通告类型
        /// </summary>
        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        /// <summary>
        /// 故障状态  HANDLING 处理中 RECOVERED 已恢复  REPLAYING 复盘中  REPLAYED 已复盘 CANCEL 已取消
        /// </summary>
        [NameInMap("problemStatus")]
        [Validation(Required=false)]
        public string ProblemStatus { get; set; }

        /// <summary>
        /// 进展摘要
        /// </summary>
        [NameInMap("progressSummary")]
        [Validation(Required=false)]
        public string ProgressSummary { get; set; }

        /// <summary>
        /// 进展摘要富文本id
        /// </summary>
        [NameInMap("progressSummaryRichTextId")]
        [Validation(Required=false)]
        public long? ProgressSummaryRichTextId { get; set; }

        /// <summary>
        /// 恢复时间
        /// </summary>
        [NameInMap("recoveryTime")]
        [Validation(Required=false)]
        public string RecoveryTime { get; set; }

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
