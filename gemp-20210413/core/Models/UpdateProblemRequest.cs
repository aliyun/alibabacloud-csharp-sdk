// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemRequest : TeaModel {
        /// <summary>
        /// 舆情反馈
        /// </summary>
        [NameInMap("feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// 故障等级
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

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
        /// 故障ID
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 故障名
        /// </summary>
        [NameInMap("problemName")]
        [Validation(Required=false)]
        public string ProblemName { get; set; }

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
