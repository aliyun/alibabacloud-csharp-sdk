// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResourceStruct : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("incidentResourceId")]
        [Validation(Required=false)]
        public string IncidentResourceId { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public IncidentResourceDetail Resource { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
