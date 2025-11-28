// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListMemberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMemberResponseBodyData Data { get; set; }
        public class ListMemberResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListMemberResponseBodyDataPageData> PageData { get; set; }
            public class ListMemberResponseBodyDataPageData : TeaModel {
                [NameInMap("AdminName")]
                [Validation(Required=false)]
                public string AdminName { get; set; }

                [NameInMap("AuthorizedCount")]
                [Validation(Required=false)]
                public long? AuthorizedCount { get; set; }

                [NameInMap("AuthorizedDeviceCount")]
                [Validation(Required=false)]
                public int? AuthorizedDeviceCount { get; set; }

                [NameInMap("Contactor")]
                [Validation(Required=false)]
                public string Contactor { get; set; }

                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Telephony")]
                [Validation(Required=false)]
                public string Telephony { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

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
