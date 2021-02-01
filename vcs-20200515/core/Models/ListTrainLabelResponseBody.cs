// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListTrainLabelResponseBody : TeaModel {
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
        public ListTrainLabelResponseBodyData Data { get; set; }
        public class ListTrainLabelResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTrainLabelResponseBodyDataList> List { get; set; }
            public class ListTrainLabelResponseBodyDataList : TeaModel {
                public string Id { get; set; }
                public string LabelName { get; set; }
                public string AlgorithmId { get; set; }
                public long? TrainMarkerCnt { get; set; }
                public long? TestMarkerCnt { get; set; }
                public string Deleted { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
            }
        };

    }

}
