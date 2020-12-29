// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeCreditInfoResponseBody : TeaModel {
        [NameInMap("PunishTimes")]
        [Validation(Required=false)]
        public long? PunishTimes { get; set; }

        [NameInMap("LastOrderTime")]
        [Validation(Required=false)]
        public long? LastOrderTime { get; set; }

        [NameInMap("LastLoginTime")]
        [Validation(Required=false)]
        public long? LastLoginTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserLevel")]
        [Validation(Required=false)]
        public string UserLevel { get; set; }

        [NameInMap("BlackTimes")]
        [Validation(Required=false)]
        public long? BlackTimes { get; set; }

        [NameInMap("NewCreatetime")]
        [Validation(Required=false)]
        public string NewCreatetime { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("Productid")]
        [Validation(Required=false)]
        public List<string> Productid { get; set; }

    }

}
