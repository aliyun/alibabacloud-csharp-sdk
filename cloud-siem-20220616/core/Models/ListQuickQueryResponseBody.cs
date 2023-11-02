// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListQuickQueryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQuickQueryResponseBodyData Data { get; set; }
        public class ListQuickQueryResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("QuickQueryList")]
            [Validation(Required=false)]
            public List<ListQuickQueryResponseBodyDataQuickQueryList> QuickQueryList { get; set; }
            public class ListQuickQueryResponseBodyDataQuickQueryList : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

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
