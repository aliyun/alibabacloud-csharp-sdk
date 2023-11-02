// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEntityInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEntityInfoResponseBodyData Data { get; set; }
        public class DescribeEntityInfoResponseBodyData : TeaModel {
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            [NameInMap("EntityInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> EntityInfo { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("TipInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TipInfo { get; set; }

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
