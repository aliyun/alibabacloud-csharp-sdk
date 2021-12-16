// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnDeliverTaskRequest : TeaModel {
        [NameInMap("Deliver")]
        [Validation(Required=false)]
        public string Deliver { get; set; }

        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

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
