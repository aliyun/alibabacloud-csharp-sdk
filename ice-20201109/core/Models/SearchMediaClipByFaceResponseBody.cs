// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaClipByFaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The media asset clips that meet the requirements.</para>
        /// </summary>
        [NameInMap("MediaClipList")]
        [Validation(Required=false)]
        public List<SearchMediaClipByFaceResponseBodyMediaClipList> MediaClipList { get; set; }
        public class SearchMediaClipByFaceResponseBodyMediaClipList : TeaModel {
            /// <summary>
            /// <para>The type of the character. Valid values: celebrity sensitive politician custom unknown</para>
            /// 
            /// <b>Example:</b>
            /// <para>celebrity</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The ID of the entity, which is the same as the entity ID returned in tag analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1031025****</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The name of the entity.</para>
            /// </summary>
            [NameInMap("LabelName")]
            [Validation(Required=false)]
            public string LabelName { get; set; }

            /// <summary>
            /// <para>The information about clips related to the face.</para>
            /// </summary>
            [NameInMap("OccurrencesInfos")]
            [Validation(Required=false)]
            public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos> OccurrencesInfos { get; set; }
            public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfos : TeaModel {
                /// <summary>
                /// <para>The end time of the clip. Unit: seconds. The value is of the Float type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>69.06635</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the clip. Unit: seconds. The value is of the Float type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61.066353</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

                /// <summary>
                /// <para>The information about the face in the clip.</para>
                /// </summary>
                [NameInMap("TrackData")]
                [Validation(Required=false)]
                public List<SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData> TrackData { get; set; }
                public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackData : TeaModel {
                    /// <summary>
                    /// <para>The coordinates of the face.</para>
                    /// </summary>
                    [NameInMap("BoxPosition")]
                    [Validation(Required=false)]
                    public SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition BoxPosition { get; set; }
                    public class SearchMediaClipByFaceResponseBodyMediaClipListOccurrencesInfosTrackDataBoxPosition : TeaModel {
                        /// <summary>
                        /// <para>The height of the rectangle frame. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>168</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The width of the rectangle frame. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>128</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The x-axis coordinate of the upper-left corner. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>517</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The y-axis coordinate of the upper-left corner. Unit: pixels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>409</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp when the face appears in the clip. Unit: seconds. The value is of the Float type.</para>
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
            /// <para>The score of the clip. The value is of the Float type. The value is in the range of [0,1].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.99041677</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E44FFACD-9E90-555A-A09A-6FD3B7335E39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
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
