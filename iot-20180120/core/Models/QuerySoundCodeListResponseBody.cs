// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySoundCodeListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySoundCodeListResponseBodyData Data { get; set; }
        public class QuerySoundCodeListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySoundCodeListResponseBodyDataList List { get; set; }
            public class QuerySoundCodeListResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySoundCodeListResponseBodyDataListItems> Items { get; set; }
                public class QuerySoundCodeListResponseBodyDataListItems : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OpenType")]
                    [Validation(Required=false)]
                    public string OpenType { get; set; }

                    [NameInMap("SoundCode")]
                    [Validation(Required=false)]
                    public string SoundCode { get; set; }

                    [NameInMap("SoundCodeContent")]
                    [Validation(Required=false)]
                    public string SoundCodeContent { get; set; }

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
