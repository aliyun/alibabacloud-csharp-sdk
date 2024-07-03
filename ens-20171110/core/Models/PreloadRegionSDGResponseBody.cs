// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreloadRegionSDGResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreloadRegionSDGResponseBodyData Data { get; set; }
        public class PreloadRegionSDGResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public PreloadRegionSDGResponseBodyDataResult Result { get; set; }
            public class PreloadRegionSDGResponseBodyDataResult : TeaModel {
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<PreloadRegionSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class PreloadRegionSDGResponseBodyDataResultFailedItems : TeaModel {
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
