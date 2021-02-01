// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetTrainLabelResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrainLabelResponseBodyData Data { get; set; }
        public class GetTrainLabelResponseBodyData : TeaModel {
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }
            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }
            [NameInMap("AlgorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }
            [NameInMap("TrainMarkerCnt")]
            [Validation(Required=false)]
            public long? TrainMarkerCnt { get; set; }
            [NameInMap("TestMarkerCnt")]
            [Validation(Required=false)]
            public long? TestMarkerCnt { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
        };

    }

}
