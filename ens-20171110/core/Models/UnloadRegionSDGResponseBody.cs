// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnloadRegionSDGResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnloadRegionSDGResponseBodyData Data { get; set; }
        public class UnloadRegionSDGResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public UnloadRegionSDGResponseBodyDataResult Result { get; set; }
            public class UnloadRegionSDGResponseBodyDataResult : TeaModel {
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<UnloadRegionSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class UnloadRegionSDGResponseBodyDataResultFailedItems : TeaModel {
                    [NameInMap("DestinationRegionId")]
                    [Validation(Required=false)]
                    public string DestinationRegionId { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
