// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultTimelineResponseBody : TeaModel {
        /// <summary>
        /// The collection of review result timelines.
        /// </summary>
        [NameInMap("MediaAuditResultTimeline")]
        [Validation(Required=false)]
        public GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline MediaAuditResultTimeline { get; set; }
        public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline : TeaModel {
            /// <summary>
            /// The collection of ad timelines.
            /// </summary>
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd> Ad { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd : TeaModel {
                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **ad**: other ads.
                /// *   **politics**: political content in text.
                /// *   **porn**: pornographic content in text.
                /// *   **abuse**: abuse in text.
                /// *   **terrorism**: terrorist content in text.
                /// *   **contraband**: prohibited content in text.
                /// *   **spam**: spam content.
                /// *   **npx**: illegal ad.
                /// *   **qrcode**: QR code.
                /// *   **programCode**: mini program code.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the video snapshot in the ad review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// The collection of undesirable content timelines.
            /// </summary>
            [NameInMap("Live")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive> Live { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive : TeaModel {
                /// <summary>
                /// The categories of undesired content review results. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **meaningless**: meaningless content, such as a black or white screen.
                /// *   **PIP**: picture-in-picture.
                /// *   **smoking**: smoking.
                /// *   **drivelive**: live broadcasting in a running vehicle.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the video snapshot in the undesirable content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// The collection of logo timelines.
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo> Logo { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo : TeaModel {
                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **TV**: controlled TV station logo.
                /// *   **trademark**: trademark.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the video snapshot in the logo review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// The collection of pornographic content timelines.
            /// </summary>
            [NameInMap("Porn")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn> Porn { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn : TeaModel {
                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **porn**
                /// *   **sexy**
                /// *   **normal**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the video snapshot in the pornographic content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// The collection of terrorist content timelines.
            /// </summary>
            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism> Terrorism { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism : TeaModel {
                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **bloody**
                /// *   **explosion**
                /// *   **outfit**
                /// *   **logo**
                /// *   **weapon**
                /// *   **politics**
                /// *   **violence**
                /// *   **crowd**
                /// *   **parade**
                /// *   **carcrash**
                /// *   **flag**
                /// *   **location**
                /// *   **others**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the video snapshot in the terrorist content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
