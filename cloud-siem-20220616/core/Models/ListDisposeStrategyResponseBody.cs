// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDisposeStrategyResponseBodyData Data { get; set; }
        public class ListDisposeStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListDisposeStrategyResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListDisposeStrategyResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The current page number.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The detailed data.
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListDisposeStrategyResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListDisposeStrategyResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The UUID of the alert.
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is associated with the policy in SIEM.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// The status of the policy. Valid values:
                /// 
                /// *   0: invalid
                /// *   1: valid
                /// </summary>
                [NameInMap("EffectiveStatus")]
                [Validation(Required=false)]
                public int? EffectiveStatus { get; set; }

                /// <summary>
                /// The details of the entity. The value is a JSON array.
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public List<object> Entity { get; set; }

                /// <summary>
                /// The ID of the entity.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// The type of the entity. Valid values:
                /// 
                /// *   ip
                /// *   process
                /// *   file
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// The summary information about the failed task.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The end time of the task.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("IncidentName")]
                [Validation(Required=false)]
                public string IncidentName { get; set; }

                /// <summary>
                /// The UUID of the event.
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// The name of the playbook, which is the unique identifier of the playbook.
                /// </summary>
                [NameInMap("PlaybookName")]
                [Validation(Required=false)]
                public string PlaybookName { get; set; }

                /// <summary>
                /// The type of the playbook. Valid values:
                /// 
                /// *   system: user-triggered playbook
                /// *   custom: event-triggered playbook
                /// *   custom_alert: alert-triggered playbook
                /// *   soar-manual: user-run playbook
                /// *   soar-mdr: MDR-run playbook
                /// </summary>
                [NameInMap("PlaybookType")]
                [Validation(Required=false)]
                public string PlaybookType { get; set; }

                /// <summary>
                /// The UUID of the playbook.
                /// </summary>
                [NameInMap("PlaybookUuid")]
                [Validation(Required=false)]
                public string PlaybookUuid { get; set; }

                /// <summary>
                /// The scope of the policy.
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

                /// <summary>
                /// The ID of the SOAR handling policy.
                /// </summary>
                [NameInMap("SophonTaskId")]
                [Validation(Required=false)]
                public string SophonTaskId { get; set; }

                /// <summary>
                /// The running status of the playbook. Valid values:
                /// 
                /// *   200: successful
                /// *   10: deleted
                /// *   5: failed
                /// *   0: initial
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the Alibaba account that is used to configure the policy.
                /// </summary>
                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

                /// <summary>
                /// The parameters that are used to trigger the playbook. The value is in the JSON format.
                /// </summary>
                [NameInMap("TaskParam")]
                [Validation(Required=false)]
                public string TaskParam { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
