// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCheckChannelResponseBody : TeaModel {
        [NameInMap("Audit")]
        [Validation(Required=false)]
        public GetCheckChannelResponseBodyAudit Audit { get; set; }
        public class GetCheckChannelResponseBodyAudit : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("LegalSwitch")]
            [Validation(Required=false)]
            public string LegalSwitch { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
