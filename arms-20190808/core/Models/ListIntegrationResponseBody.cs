// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListIntegrationResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListIntegrationResponseBodyPageInfo PageInfo { get; set; }
        public class ListIntegrationResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The information about each alert integration.
            /// </summary>
            [NameInMap("Integrations")]
            [Validation(Required=false)]
            public List<ListIntegrationResponseBodyPageInfoIntegrations> Integrations { get; set; }
            public class ListIntegrationResponseBodyPageInfoIntegrations : TeaModel {
                /// <summary>
                /// The endpoint of the alert integration.
                /// </summary>
                [NameInMap("ApiEndpoint")]
                [Validation(Required=false)]
                public string ApiEndpoint { get; set; }

                /// <summary>
                /// The time when the alert integration was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The information about the alert events.
                /// </summary>
                [NameInMap("IntegrationDetail")]
                [Validation(Required=false)]
                public ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail IntegrationDetail { get; set; }
                public class ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail : TeaModel {
                    /// <summary>
                    /// Indicates whether alert events are automatically cleared. Valid values:
                    /// 
                    /// *   true (default)
                    /// *   false
                    /// </summary>
                    [NameInMap("AutoRecover")]
                    [Validation(Required=false)]
                    public bool? AutoRecover { get; set; }

                    /// <summary>
                    /// The description of the alert integration.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The fields whose values are deduplicated.
                    /// </summary>
                    [NameInMap("DuplicateKey")]
                    [Validation(Required=false)]
                    public string DuplicateKey { get; set; }

                    /// <summary>
                    /// The extended mapped fields of the alert source.
                    /// </summary>
                    [NameInMap("ExtendedFieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> ExtendedFieldRedefineRules { get; set; }

                    /// <summary>
                    /// The predefined mapped fields of the alert source.
                    /// </summary>
                    [NameInMap("FieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> FieldRedefineRules { get; set; }

                    /// <summary>
                    /// The field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
                    /// 
                    /// > Only the Log Service alert integration supports the parameter.
                    /// </summary>
                    [NameInMap("InitiativeRecoverField")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverField { get; set; }

                    /// <summary>
                    /// The value of the field for clearing alert events. The system queries alert events based on the field of alert clearing events and clears the alert events.
                    /// 
                    /// > Only the Log Service alert integration supports the parameter.
                    /// </summary>
                    [NameInMap("InitiativeRecoverValue")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverValue { get; set; }

                    /// <summary>
                    /// The time when alert events are automatically cleared. Unit: seconds. Default value: 300.
                    /// </summary>
                    [NameInMap("RecoverTime")]
                    [Validation(Required=false)]
                    public long? RecoverTime { get; set; }

                    /// <summary>
                    /// The total number of alert events and the number of abnormal alert events in the last hour.
                    /// </summary>
                    [NameInMap("Stat")]
                    [Validation(Required=false)]
                    public List<long?> Stat { get; set; }

                }

                /// <summary>
                /// The ID of the alert integration.
                /// </summary>
                [NameInMap("IntegrationId")]
                [Validation(Required=false)]
                public long? IntegrationId { get; set; }

                /// <summary>
                /// The name of the alert integration.
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// The type of the alert integration. Valid values:
                /// 
                /// *   CLOUD_MONITOR: CloudMonitor
                /// *   LOG_SERVICE: Log Service
                /// </summary>
                [NameInMap("IntegrationProductType")]
                [Validation(Required=false)]
                public string IntegrationProductType { get; set; }

                /// <summary>
                /// The activity of the alert integration
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// The authentication token of the alert integration.
                /// </summary>
                [NameInMap("ShortToken")]
                [Validation(Required=false)]
                public string ShortToken { get; set; }

                /// <summary>
                /// Indicates whether the alert integration was enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public bool? State { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alert integrations returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of alert integrations.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
