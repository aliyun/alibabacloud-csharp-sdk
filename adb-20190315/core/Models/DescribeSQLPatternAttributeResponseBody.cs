// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternAttributeResponseBody : TeaModel {
        /// <summary>
        /// The queried SQL pattern.
        /// </summary>
        [NameInMap("PatternDetail")]
        [Validation(Required=false)]
        public DescribeSQLPatternAttributeResponseBodyPatternDetail PatternDetail { get; set; }
        public class DescribeSQLPatternAttributeResponseBodyPatternDetail : TeaModel {
            /// <summary>
            /// The average used memory associated with the SQL pattern. Unit: MB.
            /// </summary>
            [NameInMap("AverageMemory")]
            [Validation(Required=false)]
            public string AverageMemory { get; set; }

            /// <summary>
            /// The average query duration associated with the SQL pattern. Unit: milliseconds.
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public string AverageQueryTime { get; set; }

            /// <summary>
            /// The number of queries.
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            /// <summary>
            /// The statement of the SQL pattern.
            /// </summary>
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            /// <summary>
            /// The total query duration associated with the SQL pattern. Unit: milliseconds.
            /// </summary>
            [NameInMap("TotalQueryTime")]
            [Validation(Required=false)]
            public string TotalQueryTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
