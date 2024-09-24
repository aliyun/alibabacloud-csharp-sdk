// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaClipByFaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaClipList")]
        [Validation(Required=false)]
        public List<SearchMediaClipByFaceResponseBodyMediaClipList> MediaClipList { get; set; }
        public class SearchMediaClipByFaceResponseBodyMediaClipList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>celebrity</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1031025****</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>69.06635</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>61.066353</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>168</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>128</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>517</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>409</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>62.03302</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.99041677</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E44FFACD-9E90-555A-A09A-6FD3B7335E39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
