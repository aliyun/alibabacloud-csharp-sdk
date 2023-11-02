// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Ticket : TeaModel {
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        [NameInMap("expireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket_ { get; set; }

        [NameInMap("ticketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("unlimitedExpiration")]
        [Validation(Required=false)]
        public bool? UnlimitedExpiration { get; set; }

        [NameInMap("unlimitedNumber")]
        [Validation(Required=false)]
        public bool? UnlimitedNumber { get; set; }

        [NameInMap("usedNumber")]
        [Validation(Required=false)]
        public int? UsedNumber { get; set; }

        [NameInMap("valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

    }

}
