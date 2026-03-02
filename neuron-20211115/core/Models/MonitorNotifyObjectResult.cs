// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MonitorNotifyObjectResult : TeaModel {
        [NameInMap("contactGroups")]
        [Validation(Required=false)]
        public List<MonitorContactGroup> ContactGroups { get; set; }

        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<MonitorContact> Contacts { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("webhooks")]
        [Validation(Required=false)]
        public List<MonitorWebhook> Webhooks { get; set; }

    }

}
