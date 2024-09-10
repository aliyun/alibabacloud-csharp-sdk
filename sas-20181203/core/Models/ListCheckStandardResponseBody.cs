// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckStandardResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the check items.
        /// </summary>
        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<ListCheckStandardResponseBodyStandards> Standards { get; set; }
        public class ListCheckStandardResponseBodyStandards : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// An array that consists of search conditions.
            /// </summary>
            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public List<ListCheckStandardResponseBodyStandardsRequirements> Requirements { get; set; }
            public class ListCheckStandardResponseBodyStandardsRequirements : TeaModel {
                /// <summary>
                /// The ID of the search condition.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The number of check items queried by using the search condition.
                /// </summary>
                [NameInMap("RiskCheckCount")]
                [Validation(Required=false)]
                public long? RiskCheckCount { get; set; }

                /// <summary>
                /// The display name of the search condition.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// The priority field indicates the level of prominence.
                /// </summary>
                [NameInMap("ShowPriorityLevel")]
                [Validation(Required=false)]
                public int? ShowPriorityLevel { get; set; }

            }

            /// <summary>
            /// The display name of the check item.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// The priority field indicates the level of prominence.
            /// </summary>
            [NameInMap("ShowPriorityLevel")]
            [Validation(Required=false)]
            public int? ShowPriorityLevel { get; set; }

            /// <summary>
            /// The type of the check item.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
