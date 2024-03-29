// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class PickGlobalOutboundNumbersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DialNumberPairs")]
        [Validation(Required=false)]
        public PickGlobalOutboundNumbersResponseBodyDialNumberPairs DialNumberPairs { get; set; }
        public class PickGlobalOutboundNumbersResponseBodyDialNumberPairs : TeaModel {
            [NameInMap("DialNumberPair")]
            [Validation(Required=false)]
            public List<PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPair> DialNumberPair { get; set; }
            public class PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPair : TeaModel {
                public PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPairCallee Callee { get; set; }
                public class PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPairCallee : TeaModel {
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                }
                public PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPairCaller Caller { get; set; }
                public class PickGlobalOutboundNumbersResponseBodyDialNumberPairsDialNumberPairCaller : TeaModel {
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                }
            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
