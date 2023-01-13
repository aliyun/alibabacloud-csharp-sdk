// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeLabelBatchListResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySoundCodeLabelBatchListResponseData Data { get; set; }
        public class QuerySoundCodeLabelBatchListResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QuerySoundCodeLabelBatchListResponseDataList List { get; set; }
            public class QuerySoundCodeLabelBatchListResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySoundCodeLabelBatchListResponseDataListItems> Items { get; set; }
                public class QuerySoundCodeLabelBatchListResponseDataListItems : TeaModel {
                    [NameInMap("BatchCode")]
                    [Validation(Required=true)]
                    public string BatchCode { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=true)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                    [NameInMap("SuccessNum")]
                    [Validation(Required=true)]
                    public int? SuccessNum { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=true)]
                    public int? Total { get; set; }

                }

            }

        }

    }

}
