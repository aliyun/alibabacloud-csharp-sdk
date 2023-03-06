// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnoseReportResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDiagnoseReportResponseBodyHeaders Headers { get; set; }
        public class ListDiagnoseReportResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDiagnoseReportResponseBodyResult> Result { get; set; }
        public class ListDiagnoseReportResponseBodyResult : TeaModel {
            /// <summary>
            /// The timestamp when the report was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// Reports the list of diagnostic item information.
            /// </summary>
            [NameInMap("diagnoseItems")]
            [Validation(Required=false)]
            public List<ListDiagnoseReportResponseBodyResultDiagnoseItems> DiagnoseItems { get; set; }
            public class ListDiagnoseReportResponseBodyResultDiagnoseItems : TeaModel {
                /// <summary>
                /// The details of the diagnostic item.
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail Detail { get; set; }
                public class ListDiagnoseReportResponseBodyResultDiagnoseItemsDetail : TeaModel {
                    /// <summary>
                    /// The description of the diagnostic item.
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// The full name of the diagnostic item.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The diagnosis.
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// The suggestion for the diagnosis.
                    /// </summary>
                    [NameInMap("suggest")]
                    [Validation(Required=false)]
                    public string Suggest { get; set; }

                    /// <summary>
                    /// The type of the diagnostic result. Valid values:
                    /// 
                    /// *   TEXT: text description
                    /// *   CONSOLE_API: console-triggered
                    /// *   ES_API: API triggered
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The health of the diagnostic item. Supported: GREEN, YELLOW, RED, and UNKNOWN.
                /// </summary>
                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// The name of the item.
                /// </summary>
                [NameInMap("item")]
                [Validation(Required=false)]
                public string Item { get; set; }

            }

            /// <summary>
            /// The overall health of the cluster in the report. Supported: GREEN, YELLOW, RED, and UNKNOWN.
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// The ID of the instance for diagnosis.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the report.
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// The diagnosis status. Valid values: Supported: SUCCESS, FAILED, and RUNNING.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The trigger mode of health diagnostics. Valid values:
            /// 
            /// *   SYSTEM: The system is automatically triggered.
            /// *   INNER: internal trigger
            /// *   USER: manually triggered by the user
            /// </summary>
            [NameInMap("trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

        }

    }

}
