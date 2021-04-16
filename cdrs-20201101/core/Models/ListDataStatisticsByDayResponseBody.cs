// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListDataStatisticsByDayResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataStatisticsByDayResponseBodyData> Data { get; set; }
        public class ListDataStatisticsByDayResponseBodyData : TeaModel {
            [NameInMap("NonMotorNumber")]
            [Validation(Required=false)]
            public int? NonMotorNumber { get; set; }

            [NameInMap("FaceNumber")]
            [Validation(Required=false)]
            public int? FaceNumber { get; set; }

            [NameInMap("MotorNumber")]
            [Validation(Required=false)]
            public int? MotorNumber { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("BodyNumber")]
            [Validation(Required=false)]
            public int? BodyNumber { get; set; }

            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
