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
                /// <para>The category of the ad review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>ad</b>: Other ads.</description></item>
                /// <item><description><b>politics</b>: Political content in text.</description></item>
                /// <item><description><b>porn</b>: Pornographic content in text.</description></item>
                /// <item><description><b>abuse</b>: Abusive content in text.</description></item>
                /// <item><description><b>terrorism</b>: Terrorism content in text.</description></item>
                /// <item><description><b>contraband</b>: Contraband content in text.</description></item>
                /// <item><description><b>spam</b>: Other spam content in text.</description></item>
                /// <item><description><b>npx</b>: Psoriasis ads.</description></item>
                /// <item><description><b>qrcode</b>: QR code included.</description></item>
                /// <item><description><b>programCode</b>: Mini program code included.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("AdLabel")]
                [Validation(Required=false)]
                public string AdLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video snapshot for the ad review result. Valid values: <c>[0-100]</c>. The value is accurate to 10 decimal places. The hit score indicates the probability that the snapshot matches the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AdScore")]
                [Validation(Required=false)]
                public string AdScore { get; set; }

                /// <summary>
                /// <para>The category of the undesirable scene review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                /// <item><description><b>smoking</b>: Smoking.</description></item>
                /// <item><description><b>drivelive</b>: Live streaming in a car.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LiveLabel")]
                [Validation(Required=false)]
                public string LiveLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video snapshot for the undesirable scene review result. Valid values: <c>[0-100]</c>. The value is accurate to 10 decimal places. The hit score indicates the probability that the snapshot matches the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LiveScore")]
                [Validation(Required=false)]
                public string LiveScore { get; set; }

                /// <summary>
                /// <para>The category of the logo review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>TV</b>: Restricted logo included.</description></item>
                /// <item><description><b>trademark</b>: Trademark included.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LogoLabel")]
                [Validation(Required=false)]
                public string LogoLabel { get; set; }

                /// <summary>
                /// <para>The hit score of the video snapshot for the logo review result. Valid values: <c>[0-100]</c>. The value is accurate to 10 decimal places. The hit score indicates the probability that the snapshot matches the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LogoScore")]
                [Validation(Required=false)]
                public string LogoScore { get; set; }

                /// <summary>
                /// <para>The category of the pornography review result. Valid values:</para>
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
                /// <para>The hit score of the video snapshot for the pornography review result. Valid values: <c>[0-100]</c>. The value is accurate to 10 decimal places. The hit score indicates the probability that the snapshot matches the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                /// <summary>
                /// <para>The terrorism and political content review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>bloody</b>: Bloody.</description></item>
                /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                /// <item><description><b>outfit</b>: Special outfit.</description></item>
                /// <item><description><b>logo</b>: Special logo.</description></item>
                /// <item><description><b>weapon</b>: Weapon.</description></item>
                /// <item><description><b>politics</b>: Political content.</description></item>
                /// <item><description><b>violence</b>: Violence.</description></item>
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
                /// <para>The hit score of the video snapshot for the terrorism and political content review result. Valid values: <c>[0-100]</c>. The value is accurate to 10 decimal places. The hit score indicates the probability that the snapshot matches the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                /// <summary>
                /// <para>The position of the video snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The URL of the video snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The total number of snapshots in the video review results.</para>
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
