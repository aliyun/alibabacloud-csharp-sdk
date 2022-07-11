// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListPhoneNumbersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPhoneNumbersResponseBodyData Data { get; set; }
        public class ListPhoneNumbersResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListPhoneNumbersResponseBodyDataList> List { get; set; }
            public class ListPhoneNumbersResponseBodyDataList : TeaModel {
                public bool? Active { get; set; }
                public string City { get; set; }
                public string ContactFlowId { get; set; }
                public string ContactFlowName { get; set; }
                public string CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string Number { get; set; }
                public string Provider { get; set; }
                public string Province { get; set; }
                public List<ListPhoneNumbersResponseBodyDataListSkillGroups> SkillGroups { get; set; }
                public class ListPhoneNumbersResponseBodyDataListSkillGroups : TeaModel {
                    public string DisplayName { get; set; }
                    public string InstanceId { get; set; }
                    public string Name { get; set; }
                    public string SkillGroupId { get; set; }
                }
                public string Tags { get; set; }
                public string Usage { get; set; }
                public string UserId { get; set; }
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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
