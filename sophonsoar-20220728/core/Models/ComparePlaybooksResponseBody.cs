// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// The comparison result.
        /// </summary>
        [NameInMap("CompareResult")]
        [Validation(Required=false)]
        public ComparePlaybooksResponseBodyCompareResult CompareResult { get; set; }
        public class ComparePlaybooksResponseBodyCompareResult : TeaModel {
            /// <summary>
            /// The description of the comparison result.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the second version provides more information than the first version. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("New")]
            [Validation(Required=false)]
            public bool? New { get; set; }

            /// <summary>
            /// Indicates whether the configurations of the two versions are the same. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("Same")]
            [Validation(Required=false)]
            public bool? Same { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
