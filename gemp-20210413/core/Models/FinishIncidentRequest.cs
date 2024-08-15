// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class FinishIncidentRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("incidentFinishReason")]
        [Validation(Required=false)]
        public int? IncidentFinishReason { get; set; }

        [NameInMap("incidentFinishReasonDescription")]
        [Validation(Required=false)]
        public string IncidentFinishReasonDescription { get; set; }

        [NameInMap("incidentFinishSolution")]
        [Validation(Required=false)]
        public int? IncidentFinishSolution { get; set; }

        [NameInMap("incidentFinishSolutionDescription")]
        [Validation(Required=false)]
        public string IncidentFinishSolutionDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("incidentIds")]
        [Validation(Required=false)]
        public List<long?> IncidentIds { get; set; }

    }

}
