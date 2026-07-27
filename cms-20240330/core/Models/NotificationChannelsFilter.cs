// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotificationChannelsFilter : TeaModel {
        [NameInMap("containsContacts")]
        [Validation(Required=false)]
        public List<string> ContainsContacts { get; set; }

        [NameInMap("containsCustomWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsCustomWebhooks { get; set; }

        [NameInMap("containsDingWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsDingWebhooks { get; set; }

        [NameInMap("containsFsWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsFsWebhooks { get; set; }

        [NameInMap("containsGroups")]
        [Validation(Required=false)]
        public List<string> ContainsGroups { get; set; }

        [NameInMap("containsSlackWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsSlackWebhooks { get; set; }

        [NameInMap("containsWxWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsWxWebhooks { get; set; }

    }

}
