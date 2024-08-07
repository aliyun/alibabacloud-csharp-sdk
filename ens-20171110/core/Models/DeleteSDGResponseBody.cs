// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSDGResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSDGResponseBodyData Data { get; set; }
        public class DeleteSDGResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public DeleteSDGResponseBodyDataResult Result { get; set; }
            public class DeleteSDGResponseBodyDataResult : TeaModel {
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<DeleteSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeleteSDGResponseBodyDataResultFailedItems : TeaModel {
                    [NameInMap("ErrMessage")]
                    [Validation(Required=false)]
                    public string ErrMessage { get; set; }

                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public DeleteSDGResponseBodyDataResultFailedItemsItem Item { get; set; }
                    public class DeleteSDGResponseBodyDataResultFailedItemsItem : TeaModel {
                        [NameInMap("SdgId")]
                        [Validation(Required=false)]
                        public string SdgId { get; set; }

                    }

                }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
