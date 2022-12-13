// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentsRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        [NameInMap("incidentStatus")]
        [Validation(Required=false)]
        public string IncidentStatus { get; set; }

        [NameInMap("me")]
        [Validation(Required=false)]
        public int? Me { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("relationServiceId")]
        [Validation(Required=false)]
        public long? RelationServiceId { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
