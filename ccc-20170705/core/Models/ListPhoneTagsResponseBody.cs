// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListPhoneTagsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public ListPhoneTagsResponseBodyPhoneNumbers PhoneNumbers { get; set; }
        public class ListPhoneTagsResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListPhoneTagsResponseBodyPhoneNumbersList> List { get; set; }
            public class ListPhoneTagsResponseBodyPhoneNumbersList : TeaModel {
                public string City { get; set; }
                public int? Concurrency { get; set; }
                public string ContactFlowId { get; set; }
                public long? CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string Number { get; set; }
                public string PhoneNumberDescription { get; set; }
                public string PhoneNumberId { get; set; }
                public string Provider { get; set; }
                public string Province { get; set; }
                public string ServiceTag { get; set; }
                public List<string> SkillGroupIdList { get; set; }
                public int? Type { get; set; }
                public string Usage { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
