// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaClipByFaceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaClipList")]
        [Validation(Required=false)]
        public List<SearchMediaClipByFaceResponseBodyMediaClipList> MediaClipList { get; set; }
        public class SearchMediaClipByFaceResponseBodyMediaClipList : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }

            [NameInMap("OccurrencesInfos")]
            [Validation(Required=false)]
            public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos> OccurrencesInfos { get; set; }
            public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

                [NameInMap("TrackData")]
                [Validation(Required=false)]
                public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData> TrackData { get; set; }
                public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData : TeaModel {
                    [NameInMap("BoxPosition")]
                    [Validation(Required=false)]
                    public SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition BoxPosition { get; set; }
                    public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition : TeaModel {
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                }

            }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
