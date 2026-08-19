// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the review results.</para>
        /// </summary>
        [NameInMap("MediaAuditResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail MediaAuditResultDetail { get; set; }
        public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail : TeaModel {
            /// <summary>
            /// <para>The list of video review result details.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList> List { get; set; }
            public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList : TeaModel {
                /// <summary>
                /// <para>The classification of the ad review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>ad</b>: Other ads.</description></item>
                /// <item><description><b>politics</b>: Text contains politically sensitive content.</description></item>
                /// <item><description><b>porn</b>: Text contains pornographic content.</description></item>
                /// <item><description><b>abuse</b>: Text contains abusive content.</description></item>
                /// <item><description><b>terrorism</b>: Text contains terrorism-related content.</description></item>
                /// <item><description><b>contraband</b>: Text contains prohibited content.</description></item>
                /// <item><description><b>spam</b>: Text contains other spam content.</description></item>
                /// <item><description><b>npx</b>: Psoriasis ads.</description></item>
                /// <item><description><b>qrcode</b>: Contains a QR code.</description></item>
                /// <item><description><b>programCode</b>: Contains a mini program code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("AdLabel")]
                [Validation(Required=false)]
                public string AdLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the ad review result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AdScore")]
                [Validation(Required=false)]
                public string AdScore { get; set; }

                /// <summary>
                /// <para>The classification of the undesirable scene review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>meaningless</b>: The image has no content (for example, a black screen or white screen).</description></item>
                /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                /// <item><description><b>smoking</b>: Smoking.</description></item>
                /// <item><description><b>drivelive</b>: In-car live streaming.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LiveLabel")]
                [Validation(Required=false)]
                public string LiveLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the undesirable scene review result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LiveScore")]
                [Validation(Required=false)]
                public string LiveScore { get; set; }

                /// <summary>
                /// <para>The classification of the logo review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>TV</b>: Contains a regulated logo.</description></item>
                /// <item><description><b>trademark</b>: Contains a trademark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LogoLabel")]
                [Validation(Required=false)]
                public string LogoLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the logo review result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LogoScore")]
                [Validation(Required=false)]
                public string LogoScore { get; set; }

                /// <summary>
                /// <para>The classification of the pornography review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>porn</b>: Pornographic.</description></item>
                /// <item><description><b>sexy</b>: Sexy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("PornLabel")]
                [Validation(Required=false)]
                public string PornLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the pornography review result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                /// <summary>
                /// <para>The classification of the terrorism review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>bloody</b>: Bloody.</description></item>
                /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                /// <item><description><b>outfit</b>: Special attire.</description></item>
                /// <item><description><b>logo</b>: Special logo.</description></item>
                /// <item><description><b>weapon</b>: Weapon.</description></item>
                /// <item><description><b>politics</b>: Politically sensitive.</description></item>
                /// <item><description><b>violence</b>: Fighting.</description></item>
                /// <item><description><b>crowd</b>: Crowd gathering.</description></item>
                /// <item><description><b>parade</b>: Parade.</description></item>
                /// <item><description><b>carcrash</b>: Car crash scene.</description></item>
                /// <item><description><b>flag</b>: Flag.</description></item>
                /// <item><description><b>location</b>: Landmark.</description></item>
                /// <item><description><b>others</b>: Others.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("TerrorismLabel")]
                [Validation(Required=false)]
                public string TerrorismLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video screenshot for the terrorism review result. Value range: <c>[0-100]</c>, with a precision of 10 decimal places. The hit result indicates the probability of the corresponding classification label. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                /// <summary>
                /// <para>The position of the video screenshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The URL of the video screenshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The total number of video review result screenshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
