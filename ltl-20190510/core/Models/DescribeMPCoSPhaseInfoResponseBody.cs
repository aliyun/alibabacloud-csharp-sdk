// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class DescribeMPCoSPhaseInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMPCoSPhaseInfoResponseBodyData Data { get; set; }
        public class DescribeMPCoSPhaseInfoResponseBodyData : TeaModel {
            [NameInMap("BlockHash")]
            [Validation(Required=false)]
            public string BlockHash { get; set; }

            [NameInMap("BlockNumber")]
            [Validation(Required=false)]
            public long? BlockNumber { get; set; }

            [NameInMap("DataHash")]
            [Validation(Required=false)]
            public string DataHash { get; set; }

            [NameInMap("DataValue")]
            [Validation(Required=false)]
            public string DataValue { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("PreviousHash")]
            [Validation(Required=false)]
            public string PreviousHash { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("RelatedDataList")]
            [Validation(Required=false)]
            public List<DescribeMPCoSPhaseInfoResponseBodyDataRelatedDataList> RelatedDataList { get; set; }
            public class DescribeMPCoSPhaseInfoResponseBodyDataRelatedDataList : TeaModel {
                [NameInMap("RelatedDataKey")]
                [Validation(Required=false)]
                public string RelatedDataKey { get; set; }

                [NameInMap("RelatedDataSeq")]
                [Validation(Required=false)]
                public string RelatedDataSeq { get; set; }

                [NameInMap("RelatedPhaseDataHash")]
                [Validation(Required=false)]
                public string RelatedPhaseDataHash { get; set; }

                [NameInMap("RelatedPhaseId")]
                [Validation(Required=false)]
                public string RelatedPhaseId { get; set; }

                [NameInMap("RelatedPhaseName")]
                [Validation(Required=false)]
                public string RelatedPhaseName { get; set; }

            }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TransactionHash")]
            [Validation(Required=false)]
            public string TransactionHash { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
