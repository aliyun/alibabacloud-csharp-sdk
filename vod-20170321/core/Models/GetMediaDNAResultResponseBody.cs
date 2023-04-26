// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaDNAResultResponseBody : TeaModel {
        /// <summary>
        /// The similarity between the fingerprints of the input video and the matched video. 1 indicates that the fingerprints of the two videos are the same.
        /// </summary>
        [NameInMap("DNAResult")]
        [Validation(Required=false)]
        public GetMediaDNAResultResponseBodyDNAResult DNAResult { get; set; }
        public class GetMediaDNAResultResponseBodyDNAResult : TeaModel {
            /// <summary>
            /// The media fingerprinting results.
            /// </summary>
            [NameInMap("VideoDNA")]
            [Validation(Required=false)]
            public List<GetMediaDNAResultResponseBodyDNAResultVideoDNA> VideoDNA { get; set; }
            public class GetMediaDNAResultResponseBodyDNAResultVideoDNA : TeaModel {
                /// <summary>
                /// The duration of the video. Unit: seconds.
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<GetMediaDNAResultResponseBodyDNAResultVideoDNADetail> Detail { get; set; }
                public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetail : TeaModel {
                    /// <summary>
                    /// Queries a media fingerprinting result. After a media fingerprinting job is complete, you can call this operation to query the media fingerprinting result.
                    /// </summary>
                    [NameInMap("Duplication")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication Duplication { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailDuplication : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput Input { get; set; }
                    public class GetMediaDNAResultResponseBodyDNAResultVideoDNADetailInput : TeaModel {
                        /// <summary>
                        /// The start time of the video. Unit: seconds.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// The duration of the video. Unit: seconds.
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public string Start { get; set; }

                    }

                }

                /// <summary>
                /// The start time and duration of the input video.
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// The video fingerprint recognition result.
                /// </summary>
                [NameInMap("Similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

        }

        /// <summary>
        /// The start time of the video. Unit: seconds.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
