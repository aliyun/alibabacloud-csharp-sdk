// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetExchangeRateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExchangeRateResponseBodyData Data { get; set; }
        public class GetExchangeRateResponseBodyData : TeaModel {
            [NameInMap("ExchangeQuotaVO")]
            [Validation(Required=false)]
            public List<GetExchangeRateResponseBodyDataExchangeQuotaVO> ExchangeQuotaVO { get; set; }
            public class GetExchangeRateResponseBodyDataExchangeQuotaVO : TeaModel {
                [NameInMap("ExchangeName")]
                [Validation(Required=false)]
                public string ExchangeName { get; set; }

                [NameInMap("InQps")]
                [Validation(Required=false)]
                public long? InQps { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OutQps")]
                [Validation(Required=false)]
                public long? OutQps { get; set; }

                [NameInMap("VhostName")]
                [Validation(Required=false)]
                public string VhostName { get; set; }

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
