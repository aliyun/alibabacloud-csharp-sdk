// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class ListActivatedAlertsResponseBody : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListActivatedAlertsResponseBodyPage Page { get; set; }
        public class ListActivatedAlertsResponseBodyPage : TeaModel {
            [NameInMap("Alerts")]
            [Validation(Required=false)]
            public List<ListActivatedAlertsResponseBodyPageAlerts> Alerts { get; set; }
            public class ListActivatedAlertsResponseBodyPageAlerts : TeaModel {
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public string AlertId { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DispatchRules")]
                [Validation(Required=false)]
                public List<ListActivatedAlertsResponseBodyPageAlertsDispatchRules> DispatchRules { get; set; }
                public class ListActivatedAlertsResponseBodyPageAlertsDispatchRules : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public int? RuleId { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                [NameInMap("EndsAt")]
                [Validation(Required=false)]
                public long? EndsAt { get; set; }

                [NameInMap("ExpandFields")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExpandFields { get; set; }

                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                [NameInMap("InvolvedObjectKind")]
                [Validation(Required=false)]
                public string InvolvedObjectKind { get; set; }

                [NameInMap("InvolvedObjectName")]
                [Validation(Required=false)]
                public string InvolvedObjectName { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("StartsAt")]
                [Validation(Required=false)]
                public long? StartsAt { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

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

    }

}
