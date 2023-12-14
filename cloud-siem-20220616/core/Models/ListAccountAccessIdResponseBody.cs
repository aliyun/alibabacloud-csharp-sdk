// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountAccessIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountAccessIdResponseBodyData> Data { get; set; }
        public class ListAccountAccessIdResponseBodyData : TeaModel {
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("AccessIdMd5")]
            [Validation(Required=false)]
            public string AccessIdMd5 { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AccountStr")]
            [Validation(Required=false)]
            public string AccountStr { get; set; }

            [NameInMap("Bound")]
            [Validation(Required=false)]
            public int? Bound { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

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
