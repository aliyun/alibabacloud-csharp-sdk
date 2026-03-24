// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EventResourceForEventView : TeaModel {
        [NameInMap("entity")]
        [Validation(Required=false)]
        public EventResourceForEventViewEntity Entity { get; set; }
        public class EventResourceForEventViewEntity : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("prop")]
            [Validation(Required=false)]
            public Dictionary<string, object> Prop { get; set; }

        }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
