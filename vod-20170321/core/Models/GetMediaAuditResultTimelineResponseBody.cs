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
                /// *   **normal**: normal content
                /// *   **ad**: ad or text violation
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the review result category. Valid values: `[0, 100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// The collection of undesirable scene timelines.
            /// </summary>
            [NameInMap("Live")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive> Live { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive : TeaModel {
                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **terrorism**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the review result category. Valid values: `[0, 100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
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
                /// *   **normal**
                /// *   **logo**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the review result category. Valid values: `[0, 100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
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
                /// The score of the review result category. Valid values: `[0, 100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
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
                /// *   **terrorism**: terrorist content
                /// *   **outfit**: special costume
                /// *   **logo**: special logo
                /// *   **weapon**: weapon
                /// *   **politics**: politically sensitive content
                /// *   **others**: other terrorist and politically sensitive content
                /// *   **normal**: normal content
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The score of the review result category.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
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
