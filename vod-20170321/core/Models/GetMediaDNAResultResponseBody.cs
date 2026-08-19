// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaDNAResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The media fingerprint result.</para>
        /// </summary>
        [NameInMap("DNAResult")]
        [Validation(Required=false)]
        public GetMediaDNAResultResponseBodyDNAResult DNAResult { get; set; }
        public class GetMediaDNAResultResponseBodyDNAResult : TeaModel {
            /// <summary>
            /// <para>The media fingerprint recognition results.</para>
            /// </summary>
            [NameInMap("VideoDNA")]
            [Validation(Required=false)]
            public List<GetMediaDNAResultResponseBodyDNAResultVideoDNA> VideoDNA { get; set; }
            public class GetMediaDNAResultResponseBodyDNAResultVideoDNA : TeaModel {
                /// <summary>
                /// <para>The details of the similar video, including the position and duration.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<GetMediaDNAResultResponseBodyDNAResultVideoDNADetail> Detail { get; set; }
                public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetail : TeaModel {
                    /// <summary>
                    /// <para>The start time and duration of the video in the library.</para>
                    /// </summary>
                    [NameInMap("Duplication")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication Duplication { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication : TeaModel {
                        /// <summary>
                        /// <para>The duration of the video. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12.0</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The start time of the video. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2.0</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                    /// <summary>
                    /// <para>The start time and duration of the input video.</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput Input { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput : TeaModel {
                        /// <summary>
                        /// <para>The duration of the video. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12.0</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The start time of the video. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2.0</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the similar video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ad8987da46f4b*****490ce2873745</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The similarity of the video. A similarity value of 1 indicates 100% similarity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.98</para>
                /// </summary>
                [NameInMap("Similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63FC4896-E956-4B*****7D-134FF1BC597A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
