// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPlaybookResponseBody : TeaModel {
        /// <summary>
        /// The result of the verification.
        /// </summary>
        [NameInMap("CheckTaskInfos")]
        [Validation(Required=false)]
        public List<VerifyPlaybookResponseBodyCheckTaskInfos> CheckTaskInfos { get; set; }
        public class VerifyPlaybookResponseBodyCheckTaskInfos : TeaModel {
            /// <summary>
            /// The error message returned when the playbook does not pass the check.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The name of the node in the playbook.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The severity level of the verification information. Valid values:
            /// 
            /// *   warn: An issue may occur during playbook running.
            /// *   error: The playbook cannot be compiled.
            /// *   remind: The publishing and running of the playbook are not affected. We recommend that you optimize the playbook format.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
