// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The content moderation result.</para>
        /// </summary>
        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            /// <summary>
            /// <para>The content types that contain violations. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: video.</description></item>
            /// <item><description><b>image-cover</b>: thumbnail.</description></item>
            /// <item><description><b>text-title</b>: title.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }

            /// <summary>
            /// <para>The audio moderation results.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The category of the moderation result:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal.</description></item>
                /// <item><description><b>spam</b>: spam.</description></item>
                /// <item><description><b>ad</b>: advertisement.</description></item>
                /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content.</description></item>
                /// <item><description><b>abuse</b>: abusive content.</description></item>
                /// <item><description><b>porn</b>: pornographic content.</description></item>
                /// <item><description><b>flood</b>: junk content.</description></item>
                /// <item><description><b>contraband</b>: prohibited content.</description></item>
                /// <item><description><b>meaningless</b>: meaningless content.</description></item>
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
                /// <para>The score of the audio that matches the label. Value range: <c>[0, 100]</c>. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.91</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The recommended action based on the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: Blocked.</description></item>
                /// <item><description><b>review</b>: Needs manual review.</description></item>
                /// <item><description><b>pass</b>: Passed.</description></item>
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
            /// <para>The image moderation results.</para>
            /// </summary>
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                /// <summary>
                /// <para>The category of the image moderation result. Multiple values are separated by commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: pornography.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content or politically sensitive content.</description></item>
                /// <item><description><b>ad</b>: image or text violations.</description></item>
                /// <item><description><b>live</b>: undesirable scenes.</description></item>
                /// <item><description><b>logo</b>: image logos.</description></item>
                /// <item><description><b>normal</b>: normal.</description></item>
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
                    /// <para>When scene is <b>porn</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornographic.</description></item>
                    /// <item><description><b>sexy</b>: sexy.</description></item>
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// </list>
                    /// <para>When scene is <b>terrorism</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>bloody</b>: bloody.</description></item>
                    /// <item><description><b>explosion</b>: explosion or smoke.</description></item>
                    /// <item><description><b>outfit</b>: special attire.</description></item>
                    /// <item><description><b>logo</b>: special logo.</description></item>
                    /// <item><description><b>weapon</b>: weapon.</description></item>
                    /// <item><description><b>politics</b>: politically sensitive.</description></item>
                    /// <item><description><b>violence</b>: fighting.</description></item>
                    /// <item><description><b>crowd</b>: crowd gathering.</description></item>
                    /// <item><description><b>parade</b>: parade.</description></item>
                    /// <item><description><b>carcrash</b>: car crash scene.</description></item>
                    /// <item><description><b>flag</b>: flag.</description></item>
                    /// <item><description><b>location</b>: landmark.</description></item>
                    /// <item><description><b>others</b>: others.</description></item>
                    /// </list>
                    /// <para>When scene is <b>ad</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>ad</b>: other advertisement.</description></item>
                    /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                    /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                    /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                    /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                    /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                    /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                    /// <item><description><b>npx</b>: small ads.</description></item>
                    /// <item><description><b>qrcode</b>: contains QR code.</description></item>
                    /// <item><description><b>programCode</b>: contains mini program code.</description></item>
                    /// </list>
                    /// <para>When scene is <b>live</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>meaningless</b>: no content in the image (for example, black screen or white screen).</description></item>
                    /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                    /// <item><description><b>smoking</b>: smoking.</description></item>
                    /// <item><description><b>drivelive</b>: in-car live streaming.</description></item>
                    /// </list>
                    /// <para>When scene is <b>logo</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>TV</b>: contains a regulated logo.</description></item>
                    /// <item><description><b>trademark</b>: contains a trademark.</description></item>
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
                    /// <item><description><b>porn</b>: pornography detection.</description></item>
                    /// <item><description><b>terrorism</b>: terrorist content or politically sensitive content.</description></item>
                    /// <item><description><b>ad</b>: image or text violations.</description></item>
                    /// <item><description><b>live</b>: undesirable scenes.</description></item>
                    /// <item><description><b>logo</b>: image logos.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score of the image that matches the label. Value range: <c>[0, 100]</c>. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00000</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The recommended action based on the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Blocked.</description></item>
                    /// <item><description><b>review</b>: Needs manual review.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                /// <para>The recommended action based on the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: Blocked.</description></item>
                /// <item><description><b>review</b>: Needs manual review.</description></item>
                /// <item><description><b>pass</b>: Passed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The image type. Valid values: <b>cover</b> (thumbnail).</para>
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
            /// <item><description><b>porn</b>: pornography.</description></item>
            /// <item><description><b>terrorism</b>: terrorist content or politically sensitive content.</description></item>
            /// <item><description><b>ad</b>: image or text violations.</description></item>
            /// <item><description><b>live</b>: undesirable scenes.</description></item>
            /// <item><description><b>logo</b>: image logos.</description></item>
            /// <item><description><b>audio</b>: audio anti-spam.</description></item>
            /// <item><description><b>normal</b>: normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>porn</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The recommended action based on the moderation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block</b>: Blocked.</description></item>
            /// <item><description><b>review</b>: Needs manual review.</description></item>
            /// <item><description><b>pass</b>: Passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The text moderation results.</para>
            /// </summary>
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                /// <summary>
                /// <para>The text content that was moderated.</para>
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
                /// <item><description><b>spam</b>: spam.</description></item>
                /// <item><description><b>ad</b>: advertisement.</description></item>
                /// <item><description><b>abuse</b>: abusive content.</description></item>
                /// <item><description><b>flood</b>: junk content.</description></item>
                /// <item><description><b>contraband</b>: prohibited content.</description></item>
                /// <item><description><b>meaningless</b>: meaningless content.</description></item>
                /// <item><description><b>normal</b>: normal.</description></item>
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
                /// <para>The score of the text that matches the label. Value range: <c>[0, 100]</c>. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00000</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The recommended action based on the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: Blocked.</description></item>
                /// <item><description><b>review</b>: Needs manual review.</description></item>
                /// <item><description><b>pass</b>: Passed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The text categorization. Valid values: <b>title</b> (title).</para>
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
                /// <para>The advertisement moderation result.</para>
                /// </summary>
                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each moderation result category.</para>
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
                        /// <para>The category of the advertisement moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisement.</description></item>
                        /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                        /// <item><description><b>npx</b>: small ads.</description></item>
                        /// <item><description><b>qrcode</b>: contains QR code.</description></item>
                        /// <item><description><b>programCode</b>: contains mini program code.</description></item>
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
                    /// <para>The category of the advertisement moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>ad</b>: other advertisement.</description></item>
                    /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                    /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                    /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                    /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                    /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                    /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                    /// <item><description><b>npx</b>: small ads.</description></item>
                    /// <item><description><b>qrcode</b>: contains QR code.</description></item>
                    /// <item><description><b>programCode</b>: contains mini program code.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The highest score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The recommended action based on the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Blocked.</description></item>
                    /// <item><description><b>review</b>: Needs manual review.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                        /// <para>The category of the advertisement moderation result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisement.</description></item>
                        /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                        /// <item><description><b>npx</b>: small ads.</description></item>
                        /// <item><description><b>qrcode</b>: contains QR code.</description></item>
                        /// <item><description><b>programCode</b>: contains mini program code.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the video snapshot that matches the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
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
                /// <para>The review result of the GreenEnhanced route.</para>
                /// </summary>
                [NameInMap("GreenEnhancedResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResult GreenEnhancedResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResult : TeaModel {
                    /// <summary>
                    /// <para>The average confidence score of matched frames. This field is not returned if no frames are matched.</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The aggregated count of violation labels: Label (Green label) / Count (number of matched frames for the label).</para>
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
                        /// <para>The review result category.</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The union of matched Green native labels, comma-separated (such as pornographic_adultContent_tii). The value is normal if no labels are matched.</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The highest confidence score of matched frames. This field is not returned if no frames are matched.</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The frame review conclusion mapped from frameResult.riskLevel: high→block, medium/low→review, none→pass.</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The matched frame details, sorted by confidence score in descending order.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultGreenEnhancedResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The review result category.</para>
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
                        /// <para>The position of the video snapshot in the video.</para>
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
                /// <item><description><b>porn</b>: pornography.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content or politically sensitive content.</description></item>
                /// <item><description><b>ad</b>: image or text violations.</description></item>
                /// <item><description><b>live</b>: undesirable scenes.</description></item>
                /// <item><description><b>logo</b>: image logos.</description></item>
                /// <item><description><b>normal</b>: normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>porn</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The undesirable content moderation result.</para>
                /// </summary>
                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the undesirable content moderation results and the number of video snapshots for each category.</para>
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
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>meaningless</b>: no content in the image (for example, black screen or white screen).</description></item>
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

                    }

                    /// <summary>
                    /// <para>The category of the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>meaningless</b>: no content in the image (for example, black screen or white screen).</description></item>
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
                    /// <para>The highest score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The recommended action based on the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Blocked.</description></item>
                    /// <item><description><b>review</b>: Needs manual review.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>meaningless</b>: no content in the image (for example, black screen or white screen).</description></item>
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
                        /// <para>The score of the video snapshot that matches the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
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
                    /// <para>The average score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each moderation result category.</para>
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
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>TV</b>: contains a regulated logo.</description></item>
                        /// <item><description><b>trademark</b>: contains a trademark.</description></item>
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
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>TV</b>: contains a regulated logo.</description></item>
                    /// <item><description><b>trademark</b>: contains a trademark.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TV</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The highest score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The recommended action based on the moderation result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Blocked.</description></item>
                    /// <item><description><b>review</b>: Needs manual review.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>TV</b>: contains a regulated logo.</description></item>
                        /// <item><description><b>trademark</b>: contains a trademark.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the video snapshot that matches the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
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
                /// <para>The pornography detection result.</para>
                /// </summary>
                [NameInMap("PornResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult PornResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The number of video snapshots for each moderation result category.</para>
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
                        /// <para>The pornography detection result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: pornographic.</description></item>
                        /// <item><description><b>sexy</b>: sexy.</description></item>
                        /// <item><description><b>normal</b>: normal.</description></item>
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
                    /// <para>The pornography detection result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornographic.</description></item>
                    /// <item><description><b>sexy</b>: sexy.</description></item>
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The highest score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The recommended action based on the pornography detection result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Blocked.</description></item>
                    /// <item><description><b>review</b>: Needs manual review.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                        /// <para>The pornography detection result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: pornographic.</description></item>
                        /// <item><description><b>sexy</b>: sexy.</description></item>
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the video snapshot that matches the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
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
                /// <para>The recommended action based on the moderation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: Blocked.</description></item>
                /// <item><description><b>review</b>: Needs manual review.</description></item>
                /// <item><description><b>pass</b>: Passed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The terrorism and political content review result.</para>
                /// </summary>
                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of terrorism and political content review results and the number of video snapshots in each category.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots that contain terrorism and political content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The review result label for terrorism and political content. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>bloody</b>: Bloody content.</description></item>
                        /// <item><description><b>explosion</b>: Explosion or smoke.</description></item>
                        /// <item><description><b>outfit</b>: Special outfit.</description></item>
                        /// <item><description><b>logo</b>: Special logo.</description></item>
                        /// <item><description><b>weapon</b>: Weapon.</description></item>
                        /// <item><description><b>politics</b>: Political content.</description></item>
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
                        /// <para>outfit</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The review result label for terrorism and political content. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal.</description></item>
                    /// <item><description><b>bloody</b>: Bloody content.</description></item>
                    /// <item><description><b>explosion</b>: Explosion or smoke.</description></item>
                    /// <item><description><b>outfit</b>: Special outfit.</description></item>
                    /// <item><description><b>logo</b>: Special logo.</description></item>
                    /// <item><description><b>weapon</b>: Weapon.</description></item>
                    /// <item><description><b>politics</b>: Political content.</description></item>
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
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The highest score of video snapshots that match the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The review suggestion for terrorism and political content. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Violation.</description></item>
                    /// <item><description><b>review</b>: Suspected violation.</description></item>
                    /// <item><description><b>pass</b>: Passed.</description></item>
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
                        /// <para>The review result label for terrorism and political content. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>bloody</b>: Bloody content.</description></item>
                        /// <item><description><b>explosion</b>: Explosion or smoke.</description></item>
                        /// <item><description><b>outfit</b>: Special outfit.</description></item>
                        /// <item><description><b>logo</b>: Special logo.</description></item>
                        /// <item><description><b>weapon</b>: Weapon.</description></item>
                        /// <item><description><b>politics</b>: Political content.</description></item>
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
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the video snapshot that matches the label. Value range: <c>[0, 100]</c>, with precision up to 10 decimal places. The score represents the probability of the corresponding label classification. A higher value indicates higher accuracy.</para>
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
