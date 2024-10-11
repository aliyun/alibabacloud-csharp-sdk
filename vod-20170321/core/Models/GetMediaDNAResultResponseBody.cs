// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaDNAResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The media fingerprinting results.</para>
        /// </summary>
        [NameInMap("DNAResult")]
        [Validation(Required=false)]
        public GetMediaDNAResultResponseBodyDNAResult DNAResult { get; set; }
        public class GetMediaDNAResultResponseBodyDNAResult : TeaModel {
            /// <summary>
            /// <para>The video fingerprint recognition result.</para>
            /// </summary>
            [NameInMap("VideoDNA")]
            [Validation(Required=false)]
            public List<GetMediaDNAResultResponseBodyDNAResultVideoDNA> VideoDNA { get; set; }
            public class GetMediaDNAResultResponseBodyDNAResultVideoDNA : TeaModel {
                /// <summary>
                /// <para>The details of the matched video. Information such as the location and duration of the video is returned.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<GetMediaDNAResultResponseBodyDNAResultVideoDNADetail> Detail { get; set; }
                public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetail : TeaModel {
                    /// <summary>
                    /// <para>The start time and duration of the matched video.</para>
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
                /// <para>The ID of the video that has a similar fingerprint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ad8987da46f4b*****490ce2873745</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The similarity between the fingerprints of the input video and the matched video. 1 indicates that the fingerprints of the two videos are the same.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63FC4896-E956-4B*****7D-134FF1BC597A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
