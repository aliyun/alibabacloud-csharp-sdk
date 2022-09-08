// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryTicketInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryTicketInfoResponseBodyResult Result { get; set; }
        public class QueryTicketInfoResponseBodyResult : TeaModel {
            [NameInMap("AccessTicket")]
            [Validation(Required=false)]
            public string AccessTicket { get; set; }

            [NameInMap("CmptId")]
            [Validation(Required=false)]
            public string CmptId { get; set; }

            [NameInMap("GlobalParam")]
            [Validation(Required=false)]
            public string GlobalParam { get; set; }

            [NameInMap("InvalidTime")]
            [Validation(Required=false)]
            public string InvalidTime { get; set; }

            [NameInMap("MaxTicketNum")]
            [Validation(Required=false)]
            public int? MaxTicketNum { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public string RegisterTime { get; set; }

            [NameInMap("UsedTicketNum")]
            [Validation(Required=false)]
            public int? UsedTicketNum { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WatermarkParam")]
            [Validation(Required=false)]
            public string WatermarkParam { get; set; }

            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
