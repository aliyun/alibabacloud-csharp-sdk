// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectRuleResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectRuleResponseBodyData Data { get; set; }
        public class GetFileProtectRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The handling method of the rule. Valid values:
            /// 
            /// 1.  pass: allow
            /// 2.  alert
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The severity of alerts. Valid values:
            /// 
            /// *   0: does not generate alerts
            /// *   1: sends notifications
            /// *   2: suspicious
            /// *   3: high-risk
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public int? AlertLevel { get; set; }

            /// <summary>
            /// The operations performed on the files.
            /// </summary>
            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            /// <summary>
            /// The paths to the monitored files.
            /// </summary>
            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The type of the operating system. Valid values:
            /// 
            /// *   **windows**: Windows
            /// *   **linux**: Linux
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The paths to the monitored processes.
            /// </summary>
            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// 1.  0: disabled
            /// 2.  1: enabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The switch ID of the rule.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
