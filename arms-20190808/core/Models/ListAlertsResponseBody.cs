// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertsResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListAlertsResponseBodyPageBean PageBean { get; set; }
        public class ListAlertsResponseBodyPageBean : TeaModel {
            [NameInMap("ListAlerts")]
            [Validation(Required=false)]
            public List<ListAlertsResponseBodyPageBeanListAlerts> ListAlerts { get; set; }
            public class ListAlertsResponseBodyPageBeanListAlerts : TeaModel {
                [NameInMap("Activities")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsActivities> Activities { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsActivities : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("HandlerName")]
                    [Validation(Required=false)]
                    public string HandlerName { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                [NameInMap("AlertEvents")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsAlertEvents> AlertEvents { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsAlertEvents : TeaModel {
                    [NameInMap("AlertName")]
                    [Validation(Required=false)]
                    public string AlertName { get; set; }

                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public string Annotations { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("GeneratorURL")]
                    [Validation(Required=false)]
                    public string GeneratorURL { get; set; }

                    [NameInMap("IntegrationName")]
                    [Validation(Required=false)]
                    public string IntegrationName { get; set; }

                    [NameInMap("IntegrationType")]
                    [Validation(Required=false)]
                    public string IntegrationType { get; set; }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("ReceiveTime")]
                    [Validation(Required=false)]
                    public string ReceiveTime { get; set; }

                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DispatchRuleId")]
                [Validation(Required=false)]
                public float? DispatchRuleId { get; set; }

                [NameInMap("DispatchRuleName")]
                [Validation(Required=false)]
                public string DispatchRuleName { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("Solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public long? State { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
