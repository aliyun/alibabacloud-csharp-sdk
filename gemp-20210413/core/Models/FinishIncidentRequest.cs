// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class FinishIncidentRequest : TeaModel {
        /// <summary>
        /// 事件ID数组
        /// </summary>
        [NameInMap("incidentIds")]
        [Validation(Required=false)]
        public List<long?> IncidentIds { get; set; }

        /// <summary>
        /// 完结原因
        /// </summary>
        [NameInMap("incidentFinishReason")]
        [Validation(Required=false)]
        public int? IncidentFinishReason { get; set; }

        /// <summary>
        /// 原因描述
        /// </summary>
        [NameInMap("incidentFinishReasonDescription")]
        [Validation(Required=false)]
        public string IncidentFinishReasonDescription { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [NameInMap("incidentFinishSolution")]
        [Validation(Required=false)]
        public int? IncidentFinishSolution { get; set; }

        /// <summary>
        /// 解决方案描述
        /// </summary>
        [NameInMap("incidentFinishSolutionDescription")]
        [Validation(Required=false)]
        public string IncidentFinishSolutionDescription { get; set; }

        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
