// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class GetMainPartListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMainPartListResponseBodyData Data { get; set; }
        public class GetMainPartListResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMainPartListResponseBodyDataList> List { get; set; }
            public class GetMainPartListResponseBodyDataList : TeaModel {
                [NameInMap("AccountNo")]
                [Validation(Required=false)]
                public string AccountNo { get; set; }

                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("BrandUserId")]
                [Validation(Required=false)]
                public long? BrandUserId { get; set; }

                [NameInMap("BrandUserNick")]
                [Validation(Required=false)]
                public string BrandUserNick { get; set; }

                [NameInMap("MainId")]
                [Validation(Required=false)]
                public long? MainId { get; set; }

                [NameInMap("MainName")]
                [Validation(Required=false)]
                public string MainName { get; set; }

                [NameInMap("ProxyUserId")]
                [Validation(Required=false)]
                public long? ProxyUserId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
