// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMeasureDataResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("MeasureDatas")]
        [Validation(Required=false)]
        public List<ListMeasureDataResponseBodyMeasureDatas> MeasureDatas { get; set; }
        public class ListMeasureDataResponseBodyMeasureDatas : TeaModel {
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            [NameInMap("DomainCode")]
            [Validation(Required=false)]
            public string DomainCode { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public long? Usage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
