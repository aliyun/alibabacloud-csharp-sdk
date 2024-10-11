// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultTimelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of review result timelines.</para>
        /// </summary>
        [NameInMap("MediaAuditResultTimeline")]
        [Validation(Required=false)]
        public GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline MediaAuditResultTimeline { get; set; }
        public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimeline : TeaModel {
            /// <summary>
            /// <para>The collection of ad timelines.</para>
            /// </summary>
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd> Ad { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineAd : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>ad</b>: other ads.</description></item>
                /// <item><description><b>politics</b>: political content in text.</description></item>
                /// <item><description><b>porn</b>: pornographic content in text.</description></item>
                /// <item><description><b>abuse</b>: abuse in text.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content in text.</description></item>
                /// <item><description><b>contraband</b>: prohibited content in text.</description></item>
                /// <item><description><b>spam</b>: spam content.</description></item>
                /// <item><description><b>npx</b>: illegal ad.</description></item>
                /// <item><description><b>qrcode</b>: QR code.</description></item>
                /// <item><description><b>programCode</b>: mini program code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ad</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the ad review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of undesirable content timelines.</para>
            /// </summary>
            [NameInMap("Live")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive> Live { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLive : TeaModel {
                /// <summary>
                /// <para>The categories of undesired content review results. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                /// <item><description><b>PIP</b>: picture-in-picture.</description></item>
                /// <item><description><b>smoking</b>: smoking.</description></item>
                /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pip</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the undesirable content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of logo timelines.</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo> Logo { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineLogo : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>TV</b>: controlled TV station logo.</description></item>
                /// <item><description><b>trademark</b>: trademark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>logo</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the logo review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of pornographic content timelines.</para>
            /// </summary>
            [NameInMap("Porn")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn> Porn { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelinePorn : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b></description></item>
                /// <item><description><b>sexy</b></description></item>
                /// <item><description><b>normal</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the pornographic content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The collection of terrorist content timelines.</para>
            /// </summary>
            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism> Terrorism { get; set; }
            public class GetMediaAuditResultTimelineResponseBodyMediaAuditResultTimelineTerrorism : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>bloody</b></description></item>
                /// <item><description><b>explosion</b></description></item>
                /// <item><description><b>outfit</b></description></item>
                /// <item><description><b>logo</b></description></item>
                /// <item><description><b>weapon</b></description></item>
                /// <item><description><b>politics</b></description></item>
                /// <item><description><b>violence</b></description></item>
                /// <item><description><b>crowd</b></description></item>
                /// <item><description><b>parade</b></description></item>
                /// <item><description><b>carcrash</b></description></item>
                /// <item><description><b>flag</b></description></item>
                /// <item><description><b>location</b></description></item>
                /// <item><description><b>others</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the terrorist content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6438BD76-D523-46FC-956F-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
