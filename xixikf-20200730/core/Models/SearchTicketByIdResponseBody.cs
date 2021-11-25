// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class SearchTicketByIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchTicketByIdResponseBodyData Data { get; set; }
        public class SearchTicketByIdResponseBodyData : TeaModel {
            [NameInMap("Activities")]
            [Validation(Required=false)]
            public List<SearchTicketByIdResponseBodyDataActivities> Activities { get; set; }
            public class SearchTicketByIdResponseBodyDataActivities : TeaModel {
                public string ActivityCode { get; set; }
                public string ActivityFormData { get; set; }
            }
            [NameInMap("ActivityRecords")]
            [Validation(Required=false)]
            public List<SearchTicketByIdResponseBodyDataActivityRecords> ActivityRecords { get; set; }
            public class SearchTicketByIdResponseBodyDataActivityRecords : TeaModel {
                public string ActionCode { get; set; }
                public string ActionCodeDesc { get; set; }
                public long? GmtCreate { get; set; }
                public string Memo { get; set; }
                public string OperatorName { get; set; }
            }
            [NameInMap("CarbonCopy")]
            [Validation(Required=false)]
            public string CarbonCopy { get; set; }
            [NameInMap("CaseStatus")]
            [Validation(Required=false)]
            public int? CaseStatus { get; set; }
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }
            [NameInMap("CreatorType")]
            [Validation(Required=false)]
            public int? CreatorType { get; set; }
            [NameInMap("FormData")]
            [Validation(Required=false)]
            public string FormData { get; set; }
            [NameInMap("FromInfo")]
            [Validation(Required=false)]
            public string FromInfo { get; set; }
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public long? TicketId { get; set; }
            [NameInMap("TicketName")]
            [Validation(Required=false)]
            public string TicketName { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
