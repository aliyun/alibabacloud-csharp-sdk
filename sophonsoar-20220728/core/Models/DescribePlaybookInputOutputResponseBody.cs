// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookInputOutputResponseBody : TeaModel {
        /// <summary>
        /// The configurations.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribePlaybookInputOutputResponseBodyConfig Config { get; set; }
        public class DescribePlaybookInputOutputResponseBodyConfig : TeaModel {
            [NameInMap("ExeConfig")]
            [Validation(Required=false)]
            public string ExeConfig { get; set; }

            /// <summary>
            /// The input parameter configuration of the playbook. The value is a JSON array.
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// The output parameter configuration. This parameter is unavailable and is always left empty.
            /// </summary>
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }

            /// <summary>
            /// The input parameter type of the playbook. Valid values:
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
            /// The UUID of the playbook.
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
