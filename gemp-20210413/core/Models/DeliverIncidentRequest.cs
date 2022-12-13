// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeliverIncidentRequest : TeaModel {
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public long? AssignUserId { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

    }

}
