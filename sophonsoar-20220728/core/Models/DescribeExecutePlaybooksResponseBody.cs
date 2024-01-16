// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// The playbook.
        /// </summary>
        [NameInMap("PlaybookMetrics")]
        [Validation(Required=false)]
        public List<DescribeExecutePlaybooksResponseBodyPlaybookMetrics> PlaybookMetrics { get; set; }
        public class DescribeExecutePlaybooksResponseBodyPlaybookMetrics : TeaModel {
            /// <summary>
            /// The playbook description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The playbook name.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The configuration of the input parameter. The value is a JSON array.
            /// 
            /// >  For more information, see [DescribePlaybookInputOutput](~~DescribePlaybookInputOutput~~).
            /// </summary>
            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public string ParamConfig { get; set; }

            /// <summary>
            /// The input parameter type of the playbook.
            /// 
            /// *   **template-ip**
            /// *   **template-file**
            /// *   **template-process**
            /// *   **custom**
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// The playbook UUID.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
