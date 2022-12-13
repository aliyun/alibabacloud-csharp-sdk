// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListEscalationPlansByNoticeObjectResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListEscalationPlansByNoticeObjectResponseBodyData> Data { get; set; }
        public class ListEscalationPlansByNoticeObjectResponseBodyData : TeaModel {
            [NameInMap("escalationPlanId")]
            [Validation(Required=false)]
            public long? EscalationPlanId { get; set; }

            [NameInMap("escalationPlanName")]
            [Validation(Required=false)]
            public string EscalationPlanName { get; set; }

            [NameInMap("escalationPlanScopeObjects")]
            [Validation(Required=false)]
            public List<ListEscalationPlansByNoticeObjectResponseBodyDataEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
            public class ListEscalationPlansByNoticeObjectResponseBodyDataEscalationPlanScopeObjects : TeaModel {
                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("scopeObjectDeletedType")]
                [Validation(Required=false)]
                public int? ScopeObjectDeletedType { get; set; }

                [NameInMap("scopeObjectId")]
                [Validation(Required=false)]
                public long? ScopeObjectId { get; set; }

                [NameInMap("scopeObjectName")]
                [Validation(Required=false)]
                public string ScopeObjectName { get; set; }

            }

            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
