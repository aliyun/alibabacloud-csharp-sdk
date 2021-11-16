// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemMeasureRequest : TeaModel {
        /// <summary>
        /// 验收标准
        /// </summary>
        [NameInMap("checkStandard")]
        [Validation(Required=false)]
        public string CheckStandard { get; set; }

        /// <summary>
        /// 验收人id
        /// </summary>
        [NameInMap("checkUserId")]
        [Validation(Required=false)]
        public long? CheckUserId { get; set; }

        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 措施内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        [NameInMap("directorId")]
        [Validation(Required=false)]
        public long? DirectorId { get; set; }

        /// <summary>
        /// 措施Id
        /// </summary>
        [NameInMap("measureId")]
        [Validation(Required=false)]
        public long? MeasureId { get; set; }

        /// <summary>
        /// 计划完成时间
        /// </summary>
        [NameInMap("planFinishTime")]
        [Validation(Required=false)]
        public string PlanFinishTime { get; set; }

        /// <summary>
        /// 故障Id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 跟踪人id
        /// </summary>
        [NameInMap("stalkerId")]
        [Validation(Required=false)]
        public long? StalkerId { get; set; }

        /// <summary>
        /// 状态 IMPROVED 改进 2 未改进UNIMPROVED
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 措施类型 码表 PROBLEM_REPLAY_IMPROVEMENT
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
