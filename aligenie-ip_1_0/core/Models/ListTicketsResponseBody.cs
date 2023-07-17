// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListTicketsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListTicketsResponseBodyPage Page { get; set; }
        public class ListTicketsResponseBodyPage : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListTicketsResponseBodyResult> Result { get; set; }
        public class ListTicketsResponseBodyResult : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public bool? Action { get; set; }

            [NameInMap("AssignedHandler")]
            [Validation(Required=false)]
            public string AssignedHandler { get; set; }

            [NameInMap("ChargesRemark")]
            [Validation(Required=false)]
            public string ChargesRemark { get; set; }

            [NameInMap("CompleteRemark")]
            [Validation(Required=false)]
            public string CompleteRemark { get; set; }

            [NameInMap("Dialogs")]
            [Validation(Required=false)]
            public List<ListTicketsResponseBodyResultDialogs> Dialogs { get; set; }
            public class ListTicketsResponseBodyResultDialogs : TeaModel {
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

            }

            [NameInMap("GmtCalled")]
            [Validation(Required=false)]
            public string GmtCalled { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtDelayed")]
            [Validation(Required=false)]
            public string GmtDelayed { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GroupKey")]
            [Validation(Required=false)]
            public string GroupKey { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsAcceptedCharges")]
            [Validation(Required=false)]
            public bool? IsAcceptedCharges { get; set; }

            [NameInMap("IsDelayed")]
            [Validation(Required=false)]
            public bool? IsDelayed { get; set; }

            [NameInMap("IsNeedCallback")]
            [Validation(Required=false)]
            public bool? IsNeedCallback { get; set; }

            [NameInMap("IsNeedCharges")]
            [Validation(Required=false)]
            public bool? IsNeedCharges { get; set; }

            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Operations { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
