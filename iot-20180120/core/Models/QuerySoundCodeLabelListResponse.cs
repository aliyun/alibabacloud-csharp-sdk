// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeLabelListResponse : TeaModel {
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
        public QuerySoundCodeLabelListResponseData Data { get; set; }
        public class QuerySoundCodeLabelListResponseData : TeaModel {
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
            public QuerySoundCodeLabelListResponseDataList List { get; set; }
            public class QuerySoundCodeLabelListResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySoundCodeLabelListResponseDataListItems> Items { get; set; }
                public class QuerySoundCodeLabelListResponseDataListItems : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=true)]
                    public string Label { get; set; }

                    [NameInMap("SoundCode")]
                    [Validation(Required=true)]
                    public string SoundCode { get; set; }

                }

            }

        }

    }

}
