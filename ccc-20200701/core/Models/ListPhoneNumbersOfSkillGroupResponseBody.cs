// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListPhoneNumbersOfSkillGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPhoneNumbersOfSkillGroupResponseBodyData Data { get; set; }
        public class ListPhoneNumbersOfSkillGroupResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListPhoneNumbersOfSkillGroupResponseBodyDataList> List { get; set; }
            public class ListPhoneNumbersOfSkillGroupResponseBodyDataList : TeaModel {
                public bool? Active { get; set; }
                public string Number { get; set; }
                public string City { get; set; }
                public string InstanceId { get; set; }
                public string Usage { get; set; }
                public string ContactFlowId { get; set; }
                public string Province { get; set; }
            }
        };

    }

}
