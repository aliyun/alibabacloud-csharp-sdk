// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the playbook.
        /// </summary>
        [NameInMap("Playbook")]
        [Validation(Required=false)]
        public DescribePlaybookResponseBodyPlaybook Playbook { get; set; }
        public class DescribePlaybookResponseBodyPlaybook : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to create the playbook.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The description of the playbook.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The display name of the playbook.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The number of times that the playbook failed to be run.
            /// </summary>
            [NameInMap("FailExeNum")]
            [Validation(Required=false)]
            public int? FailExeNum { get; set; }

            /// <summary>
            /// The creation time of the playbook. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The modification time of the playbook. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The input parameter configuration of the playbook. The value is a JSON array.
            /// 
            /// >  For more information, see [DescribePlaybookInputOutput](~~DescribePlaybookInputOutput~~).
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// The time when the playbook was last run. The value is a 13-digit timestamp.
            /// </summary>
            [NameInMap("LastExeTime")]
            [Validation(Required=false)]
            public long? LastExeTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to modify the playbook.
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// The status of the playbook. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("OnlineActive")]
            [Validation(Required=false)]
            public bool? OnlineActive { get; set; }

            /// <summary>
            /// The MD5 hash value in the latest published version of the playbook.
            /// </summary>
            [NameInMap("OnlineReleaseTaskflowMd5")]
            [Validation(Required=false)]
            public string OnlineReleaseTaskflowMd5 { get; set; }

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
            /// The number of times that the playbook was successfully run.
            /// </summary>
            [NameInMap("SuccessExeNum")]
            [Validation(Required=false)]
            public int? SuccessExeNum { get; set; }

            /// <summary>
            /// The XML configuration of the playbook.
            /// </summary>
            [NameInMap("Taskflow")]
            [Validation(Required=false)]
            public string Taskflow { get; set; }

            /// <summary>
            /// The playbook configuration type.
            /// *   **xml**: XML format.
            /// *   **x6**: JSON format.
            /// </summary>
            [NameInMap("TaskflowType")]
            [Validation(Required=false)]
            public string TaskflowType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
