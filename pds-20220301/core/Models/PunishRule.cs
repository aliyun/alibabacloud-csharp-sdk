// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class PunishRule : TeaModel {
        [NameInMap("action_code")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        [NameInMap("ends_at")]
        [Validation(Required=false)]
        public string EndsAt { get; set; }

        [NameInMap("impermanent")]
        [Validation(Required=false)]
        public bool? Impermanent { get; set; }

        [NameInMap("starts_at")]
        [Validation(Required=false)]
        public string StartsAt { get; set; }

    }

}
