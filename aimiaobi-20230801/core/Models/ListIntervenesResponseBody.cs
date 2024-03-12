// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListIntervenesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIntervenesResponseBodyData Data { get; set; }
        public class ListIntervenesResponseBodyData : TeaModel {
            [NameInMap("InterveneList")]
            [Validation(Required=false)]
            public List<ListIntervenesResponseBodyDataInterveneList> InterveneList { get; set; }
            public class ListIntervenesResponseBodyDataInterveneList : TeaModel {
                /// <summary>
                /// id
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
