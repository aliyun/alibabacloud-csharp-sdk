// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubAlbumResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListSubAlbumResponseBodyResult Result { get; set; }
        public class ListSubAlbumResponseBodyResult : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListSubAlbumResponseBodyResultDataList> DataList { get; set; }
            public class ListSubAlbumResponseBodyResultDataList : TeaModel {
                [NameInMap("AlbumId")]
                [Validation(Required=false)]
                public string AlbumId { get; set; }

                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public int? CategoryId { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsAdded")]
                [Validation(Required=false)]
                public bool? IsAdded { get; set; }

                [NameInMap("ScheduleInfo")]
                [Validation(Required=false)]
                public ListSubAlbumResponseBodyResultDataListScheduleInfo ScheduleInfo { get; set; }
                public class ListSubAlbumResponseBodyResultDataListScheduleInfo : TeaModel {
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    [NameInMap("ScheduleId")]
                    [Validation(Required=false)]
                    public long? ScheduleId { get; set; }

                }

                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public long? Sequence { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("TotalEpisode")]
                [Validation(Required=false)]
                public int? TotalEpisode { get; set; }

            }

            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public int? TotalPageCount { get; set; }

        }

    }

}
