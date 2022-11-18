// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetQuotaTipResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("QuotaData")]
        [Validation(Required=false)]
        public GetQuotaTipResponseBodyQuotaData QuotaData { get; set; }
        public class GetQuotaTipResponseBodyQuotaData : TeaModel {
            [NameInMap("GroupLeft")]
            [Validation(Required=false)]
            public int? GroupLeft { get; set; }

            [NameInMap("GroupUsed")]
            [Validation(Required=false)]
            public int? GroupUsed { get; set; }

            [NameInMap("IsPartitionBuy")]
            [Validation(Required=false)]
            public int? IsPartitionBuy { get; set; }

            [NameInMap("PartitionLeft")]
            [Validation(Required=false)]
            public int? PartitionLeft { get; set; }

            [NameInMap("PartitionNumOfBuy")]
            [Validation(Required=false)]
            public int? PartitionNumOfBuy { get; set; }

            [NameInMap("PartitionQuata")]
            [Validation(Required=false)]
            public int? PartitionQuata { get; set; }

            [NameInMap("PartitionUsed")]
            [Validation(Required=false)]
            public int? PartitionUsed { get; set; }

            [NameInMap("TopicLeft")]
            [Validation(Required=false)]
            public int? TopicLeft { get; set; }

            [NameInMap("TopicNumOfBuy")]
            [Validation(Required=false)]
            public int? TopicNumOfBuy { get; set; }

            [NameInMap("TopicQuota")]
            [Validation(Required=false)]
            public int? TopicQuota { get; set; }

            [NameInMap("TopicUsed")]
            [Validation(Required=false)]
            public int? TopicUsed { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
