// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class RequestTableQAOnlineRequest : TeaModel {
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
