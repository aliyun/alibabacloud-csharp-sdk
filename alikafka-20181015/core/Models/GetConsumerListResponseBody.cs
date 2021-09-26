// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetConsumerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ConsumerList")]
        [Validation(Required=false)]
        public GetConsumerListResponseBodyConsumerList ConsumerList { get; set; }
        public class GetConsumerListResponseBodyConsumerList : TeaModel {
            [NameInMap("ConsumerVO")]
            [Validation(Required=false)]
            public List<GetConsumerListResponseBodyConsumerListConsumerVO> ConsumerVO { get; set; }
            public class GetConsumerListResponseBodyConsumerListConsumerVO : TeaModel {
                public string ConsumerId { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
