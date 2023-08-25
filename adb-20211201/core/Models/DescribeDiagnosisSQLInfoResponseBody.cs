// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        [NameInMap("DiagnosisSQLInfo")]
        [Validation(Required=false)]
        public string DiagnosisSQLInfo { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StageInfos")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisSQLInfoResponseBodyStageInfos> StageInfos { get; set; }
        public class DescribeDiagnosisSQLInfoResponseBodyStageInfos : TeaModel {
            [NameInMap("InputDataSize")]
            [Validation(Required=false)]
            public long? InputDataSize { get; set; }

            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public double? Progress { get; set; }

            /// <summary>
            /// StageID。
            /// </summary>
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
