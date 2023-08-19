// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditAudioResultDetailResponseBody : TeaModel {
        /// <summary>
        /// Details of review results.
        /// </summary>
        [NameInMap("MediaAuditAudioResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail MediaAuditAudioResultDetail { get; set; }
        public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail : TeaModel {
            /// <summary>
            /// The list of results.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList> List { get; set; }
            public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList : TeaModel {
                /// <summary>
                /// The end time of the audio that failed the review. Unit: seconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The review results. Valid values:
                /// *   **spam**
                /// *   **ad**
                /// *   **abuse**
                /// *   **flood**
                /// *   **contraband**
                /// *   **meaningless**
                /// *   **normal**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The start time of the audio that failed the review. Unit: seconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The text that corresponds to the audio.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
