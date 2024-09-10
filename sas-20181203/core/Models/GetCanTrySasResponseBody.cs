// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCanTrySasResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCanTrySasResponseBodyData Data { get; set; }
        public class GetCanTrySasResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the user is qualified for the trial use. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CanTry")]
            [Validation(Required=false)]
            public int? CanTry { get; set; }

            /// <summary>
            /// The editions that are allowed for the trial use.
            /// </summary>
            [NameInMap("CanTryVersions")]
            [Validation(Required=false)]
            public List<int?> CanTryVersions { get; set; }

            /// <summary>
            /// The trial type. Valid values:
            /// 
            /// *   **0**: trial prohibited
            /// *   **1**: first trial
            /// *   **2**: second trial
            /// </summary>
            [NameInMap("TryType")]
            [Validation(Required=false)]
            public int? TryType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
