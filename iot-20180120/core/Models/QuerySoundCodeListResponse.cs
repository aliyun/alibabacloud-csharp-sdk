// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeListResponse : TeaModel {
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
        public QuerySoundCodeListResponseData Data { get; set; }
        public class QuerySoundCodeListResponseData : TeaModel {
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
            public QuerySoundCodeListResponseDataList List { get; set; }
            public class QuerySoundCodeListResponseDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=true)]
                public List<QuerySoundCodeListResponseDataListItems> Items { get; set; }
                public class QuerySoundCodeListResponseDataListItems : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=true)]
                    public int? Duration { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("OpenType")]
                    [Validation(Required=true)]
                    public string OpenType { get; set; }

                    [NameInMap("SoundCode")]
                    [Validation(Required=true)]
                    public string SoundCode { get; set; }

                    [NameInMap("SoundCodeContent")]
                    [Validation(Required=true)]
                    public string SoundCodeContent { get; set; }

                }

            }

        }

    }

}
