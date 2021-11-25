// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class ExecuteActivityRequest : TeaModel {
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        [NameInMap("ActivityForm")]
        [Validation(Required=false)]
        public string ActivityForm { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public long? OperatorId { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public long? TicketId { get; set; }

    }

}
