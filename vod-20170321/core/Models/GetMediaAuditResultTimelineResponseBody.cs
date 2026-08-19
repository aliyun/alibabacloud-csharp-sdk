// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultTimelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of automated review result timelines.</para>
        /// </summary>
        [NameInMap("MediaAuditResultTimeline")]
        [Validation(Required=false)]
        public GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline MediaAuditResultTimeline { get; set; }
        public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline : TeaModel {
            /// <summary>
            /// <para>The collection of advertisement detection timelines.</para>
            /// </summary>
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd> Ad { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd : TeaModel {
                /// <summary>
                /// <para>The classification of the advertisement detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal.</description></item>
                /// <item><description><b>ad</b>: other advertisements.</description></item>
                /// <item><description><b>politics</b>: text contains political content.</description></item>
                /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                /// <item><description><b>terrorism</b>: text contains terrorism-related content.</description></item>
                /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                /// <item><description><b>npx</b>: psoriasis advertisements.</description></item>
                /// <item><description><b>qrcode</b>: contains a QR code.</description></item>
                /// <item><description><b>programCode</b>: contains a mini program code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ad</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the advertisement detection result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The position of the video screenshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of undesirable scene timelines.</para>
            /// </summary>
            [NameInMap("Live")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive> Live { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive : TeaModel {
                /// <summary>
                /// <para>The classification of the undesirable content detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal.</description></item>
                /// <item><description><b>meaningless</b>: no content in the image (such as a black screen or white screen).</description></item>
                /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                /// <item><description><b>smoking</b>: smoking.</description></item>
                /// <item><description><b>drivelive</b>: in-car live streaming.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>smoking</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the undesirable content detection result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The position of the video screenshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of logo detection timelines.</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo> Logo { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo : TeaModel {
                /// <summary>
                /// <para>The classification of the logo detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal.</description></item>
                /// <item><description><b>TV</b>: contains a regulated logo.</description></item>
                /// <item><description><b>trademark</b>: contains a trademark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the logo detection result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The position of the video screenshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of pornography detection timelines.</para>
            /// </summary>
            [NameInMap("Porn")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn> Porn { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn : TeaModel {
                /// <summary>
                /// <para>The classification of the pornography detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: pornographic content.</description></item>
                /// <item><description><b>sexy</b>: sexually suggestive content.</description></item>
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the pornography detection result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The position of the video screenshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of terrorism detection timelines.</para>
            /// </summary>
            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism> Terrorism { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism : TeaModel {
                /// <summary>
                /// <para>The terrorism and political content detection result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal.</description></item>
                /// <item><description><b>bloody</b>: bloody content.</description></item>
                /// <item><description><b>explosion</b>: explosions and smoke.</description></item>
                /// <item><description><b>outfit</b>: special attire.</description></item>
                /// <item><description><b>logo</b>: special logos.</description></item>
                /// <item><description><b>weapon</b>: weapons.</description></item>
                /// <item><description><b>politics</b>: political content.</description></item>
                /// <item><description><b>violence</b>: fighting.</description></item>
                /// <item><description><b>crowd</b>: crowd gathering.</description></item>
                /// <item><description><b>parade</b>: parades.</description></item>
                /// <item><description><b>carcrash</b>: car accident scenes.</description></item>
                /// <item><description><b>flag</b>: flags.</description></item>
                /// <item><description><b>location</b>: landmarks.</description></item>
                /// <item><description><b>others</b>: others.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the terrorism and political content detection result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The position in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6438BD76-D523-46FC-956F-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
