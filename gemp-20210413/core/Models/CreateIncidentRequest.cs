// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIncidentRequest : TeaModel {
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public long? AssignUserId { get; set; }

        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("incidentDescription")]
        [Validation(Required=false)]
        public string IncidentDescription { get; set; }

        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        [NameInMap("incidentTitle")]
        [Validation(Required=false)]
        public string IncidentTitle { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// 12000
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
