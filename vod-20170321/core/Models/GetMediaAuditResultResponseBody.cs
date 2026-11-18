// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The moderation result.</para>
        /// </summary>
        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            /// <summary>
            /// <para>The moderated content that contains violations. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: Video.</description></item>
            /// <item><description><b>image-cover</b>: Thumbnail.</description></item>
            /// <item><description><b>text-title</b>: Title.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }

            /// <summary>
            /// <para>The audio moderation result.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The category of the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal content.</description></item>
                /// <item><description><b>spam</b>: Spam.</description></item>
                /// <item><description><b>ad</b>: Ads.</description></item>
                /// <item><description><b>politics</b>: Political content.</description></item>
                /// <item><description><b>terrorism</b>: Terrorist content.</description></item>
                /// <item><description><b>abuse</b>: Abuse.</description></item>
                /// <item><description><b>porn</b>: Pornographic content.</description></item>
                /// <item><description><b>flood</b>: Flooding.</description></item>
                /// <item><description><b>contraband</b>: Contraband.</description></item>
                /// <item><description><b>meaningless</b>: Meaningless content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The moderation scenario. Fixed value: <b>antispam</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The confidence score for the matched label in the audio. Valid values: <c>[0, 100]</c>. The score indicates the probability that the audio belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.91</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The moderation suggestion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: The content is blocked.</description></item>
                /// <item><description><b>review</b>: The content requires manual review.</description></item>
                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <para>The image moderation result.</para>
            /// </summary>
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                /// <summary>
                /// <para>The category of the image moderation result. Multiple values are separated by commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: Pornographic content.</description></item>
                /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
                /// <item><description><b>ad</b>: Image and text violations.</description></item>
                /// <item><description><b>live</b>: Inappropriate scenes.</description></item>
                /// <item><description><b>logo</b>: Image logos.</description></item>
                /// <item><description><b>normal</b>: Normal content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The details of the image moderation result.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult> Result { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult : TeaModel {
                    /// <summary>
                    /// <para>The category of the moderation result.</para>
                    /// <para>When the scene is <b>porn</b>, valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: Pornographic content.</description></item>
                    /// <item><description><b>sexy</b>: Sexy content.</description></item>
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// </list>
                    /// <para>When the scene is <b>terrorism</b>, valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>bloody</b>: Bloody content.</description></item>
                    /// <item><description><b>explosion</b>: Explosions and smoke.</description></item>
                    /// <item><description><b>outfit</b>: Special outfits.</description></item>
                    /// <item><description><b>logo</b>: Special logos.</description></item>
                    /// <item><description><b>weapon</b>: Weapons.</description></item>
                    /// <item><description><b>politics</b>: Political content.</description></item>
                    /// <item><description><b>violence</b>: Violence.</description></item>
                    /// <item><description><b>crowd</b>: Crowds.</description></item>
                    /// <item><description><b>parade</b>: Parades.</description></item>
                    /// <item><description><b>carcrash</b>: Car crashes.</description></item>
                    /// <item><description><b>flag</b>: Flags.</description></item>
                    /// <item><description><b>location</b>: Landmarks.</description></item>
                    /// <item><description><b>others</b>: Others.</description></item>
                    /// </list>
                    /// <para>When the scene is <b>ad</b>, valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>ad</b>: Other ads.</description></item>
                    /// <item><description><b>politics</b>: Text containing political content.</description></item>
                    /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                    /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                    /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                    /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                    /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                    /// <item><description><b>npx</b>: Intrusive ads.</description></item>
                    /// <item><description><b>qrcode</b>: QR codes.</description></item>
                    /// <item><description><b>programCode</b>: Mini program codes.</description></item>
                    /// </list>
                    /// <para>When the scene is <b>live</b>, valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                    /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                    /// <item><description><b>smoking</b>: Smoking.</description></item>
                    /// <item><description><b>drivelive</b>: Live streaming in a car.</description></item>
                    /// </list>
                    /// <para>When the scene is <b>logo</b>, valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>TV</b>: Regulated logos.</description></item>
                    /// <item><description><b>trademark</b>: Trademarks.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The moderation scenario. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: Pornography detection.</description></item>
                    /// <item><description><b>terrorism</b>: Terrorist and political content detection.</description></item>
                    /// <item><description><b>ad</b>: Image and text violation detection.</description></item>
                    /// <item><description><b>live</b>: Inappropriate scene detection.</description></item>
                    /// <item><description><b>logo</b>: Image logo detection.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The confidence score for the matched label in the image. Valid values: <c>[0, 100]</c>. The score indicates the probability that the image belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00000</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The moderation suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The moderation suggestion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: The content is blocked.</description></item>
                /// <item><description><b>review</b>: The content requires manual review.</description></item>
                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The image category. Valid value: <b>cover</b> (thumbnail).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cover</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.test.com/****.jpg">http://www.test.com/****.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The category of the moderation result. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>porn</b>: Pornographic content.</description></item>
            /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
            /// <item><description><b>ad</b>: Image and text violations.</description></item>
            /// <item><description><b>live</b>: Inappropriate scenes.</description></item>
            /// <item><description><b>logo</b>: Image logos.</description></item>
            /// <item><description><b>audio</b>: Audio anti-spam.</description></item>
            /// <item><description><b>normal</b>: Normal content.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>porn</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The moderation suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block</b>: The content is blocked.</description></item>
            /// <item><description><b>review</b>: The content requires manual review.</description></item>
            /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The text moderation result.</para>
            /// </summary>
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                /// <summary>
                /// <para>The moderated text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline 123****</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The category of the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>spam</b>: Spam.</description></item>
                /// <item><description><b>ad</b>: Ads.</description></item>
                /// <item><description><b>abuse</b>: Abuse.</description></item>
                /// <item><description><b>flood</b>: Flooding.</description></item>
                /// <item><description><b>contraband</b>: Contraband.</description></item>
                /// <item><description><b>meaningless</b>: Meaningless content.</description></item>
                /// <item><description><b>normal</b>: Normal content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ad</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The moderation scenario. Fixed value: <b>antispam</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The confidence score for the matched label in the text snapshot. Valid values: <c>[0, 100]</c>. The score indicates the probability that the text belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00000</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The moderation suggestion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: The content is blocked.</description></item>
                /// <item><description><b>review</b>: The content requires manual review.</description></item>
                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The text categorization. Valid value: <b>title</b> (title).</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The video moderation result.</para>
            /// </summary>
            [NameInMap("VideoResult")]
            [Validation(Required=false)]
            public GetMediaAuditResultResponseBodyMediaAuditResultVideoResult VideoResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResult : TeaModel {
                /// <summary>
                /// <para>The ad moderation result.</para>
                /// </summary>
                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each category in the moderation result.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The category of the ad moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>ad</b>: Other ads.</description></item>
                        /// <item><description><b>politics</b>: Text containing political content.</description></item>
                        /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                        /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: Intrusive ads.</description></item>
                        /// <item><description><b>qrcode</b>: QR codes.</description></item>
                        /// <item><description><b>programCode</b>: Mini program codes.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The category of the ad moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>ad</b>: Other ads.</description></item>
                    /// <item><description><b>politics</b>: Text containing political content.</description></item>
                    /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                    /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                    /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                    /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                    /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                    /// <item><description><b>npx</b>: Intrusive ads.</description></item>
                    /// <item><description><b>qrcode</b>: QR codes.</description></item>
                    /// <item><description><b>programCode</b>: Mini program codes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The moderation suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the video snapshots with the highest scores for the matched label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the ad moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>ad</b>: Other ads.</description></item>
                        /// <item><description><b>politics</b>: Text containing political content.</description></item>
                        /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                        /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: Intrusive ads.</description></item>
                        /// <item><description><b>qrcode</b>: QR codes.</description></item>
                        /// <item><description><b>programCode</b>: Mini program codes.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the matched label in the video snapshot. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position of the video snapshot in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
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

                }

                /// <summary>
                /// <para>The GreenEnhanced moderation result.</para>
                /// </summary>
                [NameInMap("GreenEnhancedResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResult GreenEnhancedResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score of the matched frames. This parameter is not returned if no frames are matched.</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The aggregation of violation label counts, including Label for the Green label and Count for the number of matched frames for the label.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots for the corresponding label.</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The moderation result label.</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The union of matched native Green labels, separated by commas, such as pornographic_adultContent_tii. If no labels are matched, the value is normal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score of the matched frames. This parameter is not returned if no frames are matched.</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The image moderation conclusion, which is mapped from frameResult.riskLevel: high is mapped to block, medium or low is mapped to review, and none is mapped to pass.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The details of the matched frames, sorted in descending order of confidence score.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The moderation result category.</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score of the video snapshot that matches the label.</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The timestamp of the video snapshot in the video.</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public string Timestamp { get; set; }

                        /// <summary>
                        /// <para>The URL of the video snapshot.</para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// <para>The category of the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: Pornographic content.</description></item>
                /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
                /// <item><description><b>ad</b>: Image and text violations.</description></item>
                /// <item><description><b>live</b>: Inappropriate scenes.</description></item>
                /// <item><description><b>logo</b>: Image logos.</description></item>
                /// <item><description><b>normal</b>: Normal content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The inappropriate content moderation result.</para>
                /// </summary>
                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each inappropriate content category in the moderation result.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The category of the moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                        /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                        /// <item><description><b>smoking</b>: Smoking.</description></item>
                        /// <item><description><b>drivelive</b>: Live streaming in a car.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>smoking</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The category of the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                    /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                    /// <item><description><b>smoking</b>: Smoking.</description></item>
                    /// <item><description><b>drivelive</b>: Live streaming in a car.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>smoking</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The moderation suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the video snapshots with the highest scores for the matched label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                        /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                        /// <item><description><b>smoking</b>: Smoking.</description></item>
                        /// <item><description><b>drivelive</b>: Live streaming in a car.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>smoking</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the matched label in the video snapshot. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position of the video snapshot in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
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

                }

                /// <summary>
                /// <para>The logo moderation result.</para>
                /// </summary>
                [NameInMap("LogoResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult LogoResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each category in the moderation result.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The category of the logo moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>TV</b>: Regulated logos.</description></item>
                        /// <item><description><b>trademark</b>: Trademarks.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The category of the logo moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// <item><description><b>TV</b>: Regulated logos.</description></item>
                    /// <item><description><b>trademark</b>: Trademarks.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TV</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The moderation suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the video snapshots with the highest scores for the matched label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the logo moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// <item><description><b>TV</b>: Regulated logos.</description></item>
                        /// <item><description><b>trademark</b>: Trademarks.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the matched label in the video snapshot. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position of the video snapshot in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16</para>
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

                }

                /// <summary>
                /// <para>The pornography moderation result.</para>
                /// </summary>
                [NameInMap("PornResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult PornResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each category in the moderation result.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The pornography moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: Pornographic content.</description></item>
                        /// <item><description><b>sexy</b>: Sexy content.</description></item>
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The pornography moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: Pornographic content.</description></item>
                    /// <item><description><b>sexy</b>: Sexy content.</description></item>
                    /// <item><description><b>normal</b>: Normal content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The pornography moderation suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the video snapshots with the highest scores for the matched label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The pornography moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: Pornographic content.</description></item>
                        /// <item><description><b>sexy</b>: Sexy content.</description></item>
                        /// <item><description><b>normal</b>: Normal content.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the matched label in the video snapshot. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.0000</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

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

                }

                /// <summary>
                /// <para>The moderation suggestion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: The content is blocked.</description></item>
                /// <item><description><b>review</b>: The content requires manual review.</description></item>
                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The moderation result for terrorism and political content.</para>
                /// </summary>
                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of terrorism and political content moderation results and the number of video snapshots for each category.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots for the terrorism and political content moderation result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The moderation label for terrorism and political content. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: The content is normal.</description></item>
                        /// <item><description><b>bloody</b>: The content contains bloody scenes.</description></item>
                        /// <item><description><b>explosion</b>: The content contains explosions and smoke.</description></item>
                        /// <item><description><b>outfit</b>: The content contains special outfits.</description></item>
                        /// <item><description><b>logo</b>: The content contains special logos.</description></item>
                        /// <item><description><b>weapon</b>: The content contains weapons.</description></item>
                        /// <item><description><b>politics</b>: The content contains political elements.</description></item>
                        /// <item><description><b>violence</b>: The content contains violence.</description></item>
                        /// <item><description><b>crowd</b>: The content contains crowd gatherings.</description></item>
                        /// <item><description><b>parade</b>: The content contains parades.</description></item>
                        /// <item><description><b>carcrash</b>: The content contains car crash scenes.</description></item>
                        /// <item><description><b>flag</b>: The content contains flags.</description></item>
                        /// <item><description><b>location</b>: The content contains landmarks.</description></item>
                        /// <item><description><b>others</b>: The content contains other elements.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>outfit</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The moderation label for terrorism and political content. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: The content is normal.</description></item>
                    /// <item><description><b>bloody</b>: The content contains bloody scenes.</description></item>
                    /// <item><description><b>explosion</b>: The content contains explosions and smoke.</description></item>
                    /// <item><description><b>outfit</b>: The content contains special outfits.</description></item>
                    /// <item><description><b>logo</b>: The content contains special logos.</description></item>
                    /// <item><description><b>weapon</b>: The content contains weapons.</description></item>
                    /// <item><description><b>politics</b>: The content contains political elements.</description></item>
                    /// <item><description><b>violence</b>: The content contains violence.</description></item>
                    /// <item><description><b>crowd</b>: The content contains crowd gatherings.</description></item>
                    /// <item><description><b>parade</b>: The content contains parades.</description></item>
                    /// <item><description><b>carcrash</b>: The content contains car crash scenes.</description></item>
                    /// <item><description><b>flag</b>: The content contains flags.</description></item>
                    /// <item><description><b>location</b>: The content contains landmarks.</description></item>
                    /// <item><description><b>others</b>: The content contains other elements.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The maximum confidence score for the matched label in the video snapshots. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The moderation suggestion for terrorism and political content. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: The content is blocked.</description></item>
                    /// <item><description><b>review</b>: The content requires manual review.</description></item>
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the video snapshots with the highest scores for the matched label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The moderation label for terrorism and political content. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: The content is normal.</description></item>
                        /// <item><description><b>bloody</b>: The content contains bloody scenes.</description></item>
                        /// <item><description><b>explosion</b>: The content contains explosions and smoke.</description></item>
                        /// <item><description><b>outfit</b>: The content contains special outfits.</description></item>
                        /// <item><description><b>logo</b>: The content contains special logos.</description></item>
                        /// <item><description><b>weapon</b>: The content contains weapons.</description></item>
                        /// <item><description><b>politics</b>: The content contains political elements.</description></item>
                        /// <item><description><b>violence</b>: The content contains violence.</description></item>
                        /// <item><description><b>crowd</b>: The content contains crowd gatherings.</description></item>
                        /// <item><description><b>parade</b>: The content contains parades.</description></item>
                        /// <item><description><b>carcrash</b>: The content contains car crash scenes.</description></item>
                        /// <item><description><b>flag</b>: The content contains flags.</description></item>
                        /// <item><description><b>location</b>: The content contains landmarks.</description></item>
                        /// <item><description><b>others</b>: The content contains other elements.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>normal</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confidence score for the matched label in the video snapshot. Valid values: <c>[0, 100]</c>. The score is accurate to 10 decimal places. The score indicates the probability that the video snapshot belongs to the corresponding category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.000</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

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

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB7D7232-1AB2-40FE-B8D5-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
