// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class ListExchangeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangeResponseBodyData Data { get; set; }
        public class ListExchangeResponseBodyData : TeaModel {
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
            public ListExchangeResponseBodyDataVoList VoList { get; set; }
            public class ListExchangeResponseBodyDataVoList : TeaModel {
                [NameInMap("ExchangVO")]
                [Validation(Required=false)]
                public List<ListExchangeResponseBodyDataVoListExchangVO> ExchangVO { get; set; }
                public class ListExchangeResponseBodyDataVoListExchangVO : TeaModel {
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    [NameInMap("AutoDelete")]
                    [Validation(Required=false)]
                    public bool? AutoDelete { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("ExchangeType")]
                    [Validation(Required=false)]
                    public int? ExchangeType { get; set; }

                    [NameInMap("Internal")]
                    [Validation(Required=false)]
                    public bool? Internal { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

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
