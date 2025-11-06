// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetExchangeErrorByTaskIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExchangeErrorByTaskIdResponseBodyData Data { get; set; }
        public class GetExchangeErrorByTaskIdResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public GetExchangeErrorByTaskIdResponseBodyDataVoList VoList { get; set; }
            public class GetExchangeErrorByTaskIdResponseBodyDataVoList : TeaModel {
                [NameInMap("ExchangeErrorDO")]
                [Validation(Required=false)]
                public List<GetExchangeErrorByTaskIdResponseBodyDataVoListExchangeErrorDO> ExchangeErrorDO { get; set; }
                public class GetExchangeErrorByTaskIdResponseBodyDataVoListExchangeErrorDO : TeaModel {
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public int? ErrorMessage { get; set; }

                    [NameInMap("ExchangeName")]
                    [Validation(Required=false)]
                    public string ExchangeName { get; set; }

                    [NameInMap("ExchangeType")]
                    [Validation(Required=false)]
                    public string ExchangeType { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("VhostName")]
                    [Validation(Required=false)]
                    public string VhostName { get; set; }

                }

            }

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
