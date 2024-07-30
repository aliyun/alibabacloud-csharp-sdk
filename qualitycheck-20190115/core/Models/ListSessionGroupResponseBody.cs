// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListSessionGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSessionGroupResponseBodyData Data { get; set; }
        public class ListSessionGroupResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSessionGroupResponseBodyDataData> Data { get; set; }
            public class ListSessionGroupResponseBodyDataData : TeaModel {
                [NameInMap("AssignStatus")]
                [Validation(Required=false)]
                public int? AssignStatus { get; set; }

                [NameInMap("CallStartTime")]
                [Validation(Required=false)]
                public string CallStartTime { get; set; }

                [NameInMap("CallerList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataCallerList CallerList { get; set; }
                public class ListSessionGroupResponseBodyDataDataCallerList : TeaModel {
                    [NameInMap("CallerList")]
                    [Validation(Required=false)]
                    public List<string> CallerList { get; set; }

                }

                [NameInMap("CustomerIdList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataCustomerIdList CustomerIdList { get; set; }
                public class ListSessionGroupResponseBodyDataDataCustomerIdList : TeaModel {
                    [NameInMap("CustomerIdList")]
                    [Validation(Required=false)]
                    public List<string> CustomerIdList { get; set; }

                }

                [NameInMap("CustomerNameList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataCustomerNameList CustomerNameList { get; set; }
                public class ListSessionGroupResponseBodyDataDataCustomerNameList : TeaModel {
                    [NameInMap("CustomerNameList")]
                    [Validation(Required=false)]
                    public List<string> CustomerNameList { get; set; }

                }

                [NameInMap("CustomerServiceIdList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataCustomerServiceIdList CustomerServiceIdList { get; set; }
                public class ListSessionGroupResponseBodyDataDataCustomerServiceIdList : TeaModel {
                    [NameInMap("CustomerServiceIdList")]
                    [Validation(Required=false)]
                    public List<string> CustomerServiceIdList { get; set; }

                }

                [NameInMap("CustomerServiceNameList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataCustomerServiceNameList CustomerServiceNameList { get; set; }
                public class ListSessionGroupResponseBodyDataDataCustomerServiceNameList : TeaModel {
                    [NameInMap("CustomerServiceNameList")]
                    [Validation(Required=false)]
                    public List<string> CustomerServiceNameList { get; set; }

                }

                [NameInMap("HitSessionCount")]
                [Validation(Required=false)]
                public int? HitSessionCount { get; set; }

                [NameInMap("LastDataId")]
                [Validation(Required=false)]
                public string LastDataId { get; set; }

                [NameInMap("ReviewStatus")]
                [Validation(Required=false)]
                public int? ReviewStatus { get; set; }

                [NameInMap("ReviewerList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataReviewerList ReviewerList { get; set; }
                public class ListSessionGroupResponseBodyDataDataReviewerList : TeaModel {
                    [NameInMap("ReviewerList")]
                    [Validation(Required=false)]
                    public List<string> ReviewerList { get; set; }

                }

                [NameInMap("SchemeTaskConfigId")]
                [Validation(Required=false)]
                public long? SchemeTaskConfigId { get; set; }

                [NameInMap("SchemeTaskConfigName")]
                [Validation(Required=false)]
                public string SchemeTaskConfigName { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public long? Score { get; set; }

                [NameInMap("SessionCount")]
                [Validation(Required=false)]
                public int? SessionCount { get; set; }

                [NameInMap("SessionGroupId")]
                [Validation(Required=false)]
                public string SessionGroupId { get; set; }

                [NameInMap("SessionGroupReviewedOrComplained")]
                [Validation(Required=false)]
                public bool? SessionGroupReviewedOrComplained { get; set; }

                [NameInMap("SkillGroupNameList")]
                [Validation(Required=false)]
                public ListSessionGroupResponseBodyDataDataSkillGroupNameList SkillGroupNameList { get; set; }
                public class ListSessionGroupResponseBodyDataDataSkillGroupNameList : TeaModel {
                    [NameInMap("SkillGroupNameList")]
                    [Validation(Required=false)]
                    public List<string> SkillGroupNameList { get; set; }

                }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LastDataId")]
        [Validation(Required=false)]
        public string LastDataId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public ListSessionGroupResponseBodyMessages Messages { get; set; }
        public class ListSessionGroupResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
