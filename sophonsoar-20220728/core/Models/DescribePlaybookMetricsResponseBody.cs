// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookMetricsResponseBody : TeaModel {
        /// <summary>
        /// The details of the playbook.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribePlaybookMetricsResponseBodyMetrics Metrics { get; set; }
        public class DescribePlaybookMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// The status of the playbook. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            /// <summary>
            /// The description of the playbook.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the playbook.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The number of the tasks that are created for the playbook and failed to run.
            /// </summary>
            [NameInMap("FailNum")]
            [Validation(Required=false)]
            public int? FailNum { get; set; }

            /// <summary>
            /// The time when the playbook was created. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The number of historical versions of the playbook.
            /// </summary>
            [NameInMap("HistoryMd5")]
            [Validation(Required=false)]
            public int? HistoryMd5 { get; set; }

            /// <summary>
            /// The time when the playbook was last run. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            /// <summary>
            /// The type of the playbook. Valid values:
            /// 
            /// *   **preset**: predefined playbook
            /// *   **user**: custom playbook
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            /// <summary>
            /// The UUID of the playbook.
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// The number of the tasks that are created for the playbook and were successfully run.
            /// </summary>
            [NameInMap("SuccNum")]
            [Validation(Required=false)]
            public int? SuccNum { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
