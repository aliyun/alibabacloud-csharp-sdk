// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListBriefSkillGroupsResponseBody : TeaModel {
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
        public ListBriefSkillGroupsResponseBodyData Data { get; set; }
        public class ListBriefSkillGroupsResponseBodyData : TeaModel {
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
            public List<ListBriefSkillGroupsResponseBodyDataList> List { get; set; }
            public class ListBriefSkillGroupsResponseBodyDataList : TeaModel {
                public string DisplayName { get; set; }
                public string Description { get; set; }
                public int? PhoneNumberCount { get; set; }
                public string SkillGroupId { get; set; }
                public string SkillGroupName { get; set; }
                public int? UserCount { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
