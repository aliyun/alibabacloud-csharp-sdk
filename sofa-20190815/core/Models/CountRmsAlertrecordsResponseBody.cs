// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CountRmsAlertrecordsResponseBody : TeaModel {
        [NameInMap("Response")]
        [Validation(Required=false)]
        public CountRmsAlertrecordsResponseBodyResponse Response { get; set; }
        public class CountRmsAlertrecordsResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public CountRmsAlertrecordsResponseBodyResponseEntity Entity { get; set; }
            public class CountRmsAlertrecordsResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<CountRmsAlertrecordsResponseBodyResponseEntityData> Data { get; set; }
                public class CountRmsAlertrecordsResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
