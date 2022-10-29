// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemActivityResponseBody : TeaModel {
        [NameInMap("activities")]
        [Validation(Required=false)]
        public List<GetWorkItemActivityResponseBodyActivities> Activities { get; set; }
        public class GetWorkItemActivityResponseBodyActivities : TeaModel {
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("eventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("newValue")]
            [Validation(Required=false)]
            public List<GetWorkItemActivityResponseBodyActivitiesNewValue> NewValue { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesNewValue : TeaModel {
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                [NameInMap("plainValue")]
                [Validation(Required=false)]
                public string PlainValue { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("oldValue")]
            [Validation(Required=false)]
            public List<GetWorkItemActivityResponseBodyActivitiesOldValue> OldValue { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesOldValue : TeaModel {
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                [NameInMap("plainValue")]
                [Validation(Required=false)]
                public string PlainValue { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("parentEventId")]
            [Validation(Required=false)]
            public long? ParentEventId { get; set; }

            [NameInMap("property")]
            [Validation(Required=false)]
            public GetWorkItemActivityResponseBodyActivitiesProperty Property { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesProperty : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("propertyIdentifier")]
                [Validation(Required=false)]
                public string PropertyIdentifier { get; set; }

                [NameInMap("propertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                [NameInMap("propertyType")]
                [Validation(Required=false)]
                public string PropertyType { get; set; }

            }

            [NameInMap("resourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
