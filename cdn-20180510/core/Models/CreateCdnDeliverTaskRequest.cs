// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CreateCdnDeliverTaskRequest : TeaModel {
        [NameInMap("Deliver")]
        [Validation(Required=false)]
        public string Deliver { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Reports")]
        [Validation(Required=false)]
        public string Reports { get; set; }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
