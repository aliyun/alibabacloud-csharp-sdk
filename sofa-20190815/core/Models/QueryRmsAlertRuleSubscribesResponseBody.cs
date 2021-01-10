// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlertRuleSubscribesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAlertRuleSubscribesResponseBodyResponse Response { get; set; }
        public class QueryRmsAlertRuleSubscribesResponseBodyResponse : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsAlertRuleSubscribesResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsAlertRuleSubscribesResponseBodyResponseEntities : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MonitorTargetType")]
                [Validation(Required=false)]
                public string MonitorTargetType { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("SubscriberId")]
                [Validation(Required=false)]
                public string SubscriberId { get; set; }

                [NameInMap("SubscriberLoginName")]
                [Validation(Required=false)]
                public string SubscriberLoginName { get; set; }

                [NameInMap("SubscriberType")]
                [Validation(Required=false)]
                public string SubscriberType { get; set; }

                [NameInMap("SubscriptionTargetId")]
                [Validation(Required=false)]
                public string SubscriptionTargetId { get; set; }

                [NameInMap("SubscriptionTargetType")]
                [Validation(Required=false)]
                public string SubscriptionTargetType { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public QueryRmsAlertRuleSubscribesResponseBodyResponseMeta Meta { get; set; }
            public class QueryRmsAlertRuleSubscribesResponseBodyResponseMeta : TeaModel {
                [NameInMap("Page")]
                [Validation(Required=false)]
                public QueryRmsAlertRuleSubscribesResponseBodyResponseMetaPage Page { get; set; }
                public class QueryRmsAlertRuleSubscribesResponseBodyResponseMetaPage : TeaModel {
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public long? Offset { get; set; }
                    [NameInMap("TotalSize")]
                    [Validation(Required=false)]
                    public long? TotalSize { get; set; }
                };

            }
        };

    }

}
