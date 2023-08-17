// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        /// <summary>
        /// Execution details of the SQL statement, including the SQL statement text, statistics, execution plan, and operator information.
        /// </summary>
        [NameInMap("DiagnosisSQLInfo")]
        [Validation(Required=false)]
        public string DiagnosisSQLInfo { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Execution details of the query by stage.
        /// </summary>
        [NameInMap("StageInfos")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisSQLInfoResponseBodyStageInfos> StageInfos { get; set; }
        public class DescribeDiagnosisSQLInfoResponseBodyStageInfos : TeaModel {
            /// <summary>
            /// The total amount of input data in the stage. Unit: bytes.
            /// </summary>
            [NameInMap("InputDataSize")]
            [Validation(Required=false)]
            public long? InputDataSize { get; set; }

            /// <summary>
            /// The total number of input rows in the stage.
            /// </summary>
            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            /// <summary>
            /// The total amount of time consumed by all operators in the stage. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            /// <summary>
            /// The total amount of output data in the stage. Unit: bytes.
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// The total number of output rows in the stage.
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// The total peak memory of the stage. Unit: bytes.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// The execution progress of the stage.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public double? Progress { get; set; }

            /// <summary>
            /// The ID of the stage.
            /// </summary>
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// The state of the stage.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
