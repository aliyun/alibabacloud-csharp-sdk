// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternAttributeResponseBody : TeaModel {
        /// <summary>
        /// The detailed information of the SQL pattern.
        /// </summary>
        [NameInMap("PatternDetail")]
        [Validation(Required=false)]
        public DescribeSQLPatternAttributeResponseBodyPatternDetail PatternDetail { get; set; }
        public class DescribeSQLPatternAttributeResponseBodyPatternDetail : TeaModel {
            /// <summary>
            /// The average memory consumption associated with the SQL pattern. Unit: MB.
            /// </summary>
            [NameInMap("AverageMemory")]
            [Validation(Required=false)]
            public string AverageMemory { get; set; }

            /// <summary>
            /// The average query time associated with the SQL pattern. Unit: milliseconds.
            /// </summary>
            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public string AverageQueryTime { get; set; }

            /// <summary>
            /// The number of queries performed based on the SQL pattern.
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
            /// The total query time associated with the SQL pattern. Unit: milliseconds.
            /// </summary>
            [NameInMap("TotalQueryTime")]
            [Validation(Required=false)]
            public string TotalQueryTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
