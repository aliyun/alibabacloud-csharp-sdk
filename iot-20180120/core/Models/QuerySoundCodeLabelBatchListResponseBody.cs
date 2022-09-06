// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeLabelBatchListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySoundCodeLabelBatchListResponseBodyData Data { get; set; }
        public class QuerySoundCodeLabelBatchListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySoundCodeLabelBatchListResponseBodyDataList List { get; set; }
            public class QuerySoundCodeLabelBatchListResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySoundCodeLabelBatchListResponseBodyDataListItems> Items { get; set; }
                public class QuerySoundCodeLabelBatchListResponseBodyDataListItems : TeaModel {
                    [NameInMap("BatchCode")]
                    [Validation(Required=false)]
                    public string BatchCode { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("SuccessNum")]
                    [Validation(Required=false)]
                    public int? SuccessNum { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

            }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
