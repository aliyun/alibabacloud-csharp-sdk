// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaClipByFaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The collection of media asset clips that meet the requirements.</para>
        /// </summary>
        [NameInMap("MediaClipList")]
        [Validation(Required=false)]
        public List<SearchMediaClipByFaceResponseBodyMediaClipList> MediaClipList { get; set; }
        public class SearchMediaClipByFaceResponseBodyMediaClipList : TeaModel {
            /// <summary>
            /// <para>The person type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>celebrity: celebrity.</description></item>
            /// <item><description>sensitive: sensitive person.</description></item>
            /// <item><description>politician: political figure.</description></item>
            /// <item><description>custom: custom person.</description></item>
            /// <item><description>unknown: unknown person.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>celebrity</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The entity ID, which corresponds to the entity ID in the label analysis results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1031025****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The entity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Doe</para>
            /// </summary>
            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }

            /// <summary>
            /// <para>The clustering information of person clips.</para>
            /// </summary>
            [NameInMap("OccurrencesInfos")]
            [Validation(Required=false)]
            public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos> OccurrencesInfos { get; set; }
            public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos : TeaModel {
                /// <summary>
                /// <para>The end time of the matched clip, in seconds. The value is of the Float type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>69.06635</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <para>The facial expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Calm</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The start time of the matched clip, in seconds. The value is of the Float type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61.066353</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

                /// <summary>
                /// <para>The detailed information of the face in the clip.</para>
                /// </summary>
                [NameInMap("TrackData")]
                [Validation(Required=false)]
                public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData> TrackData { get; set; }
                public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData : TeaModel {
                    /// <summary>
                    /// <para>The face coordinate information.</para>
                    /// </summary>
                    [NameInMap("BoxPosition")]
                    [Validation(Required=false)]
                    public SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition BoxPosition { get; set; }
                    public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition : TeaModel {
                        /// <summary>
                        /// <para>The height of the bounding box, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>168</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The width of the bounding box, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>128</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The x-axis coordinate of the upper-left vertex, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>517</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The y-axis coordinate of the upper-left vertex, in pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>409</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp when the face appears in the media asset, in seconds. The value is of the Float type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>62.03302</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                }

            }

            /// <summary>
            /// <para>The score of the matched clip. The value is of the Float type and ranges from 0 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.99041677</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E44FFACD-9E90-555A-A09A-6FD3B7335E39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of media asset clips that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
