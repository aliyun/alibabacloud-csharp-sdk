// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The review result.</para>
        /// </summary>
        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            /// <summary>
            /// <para>The content that violates the review rules. Multiple values are separated by commas (,). Valid values:</para>
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
            /// <para>The audio review result.</para>
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The review result category. Valid values:</para>
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
                /// <para>The review scenario. Fixed value: <b>antispam</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The score of the audio that hits the label. Value range: <c>[0, 100]</c>. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.91</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The review result suggestion. Valid values:</para>
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

            }

            /// <summary>
            /// <para>The image review result.</para>
            /// </summary>
            [NameInMap("ImageResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                /// <summary>
                /// <para>The image review result categories. Multiple values are separated by commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: pornographic content.</description></item>
                /// <item><description><b>terrorism</b>: terrorist or politically sensitive content.</description></item>
                /// <item><description><b>ad</b>: image or text violation.</description></item>
                /// <item><description><b>live</b>: undesirable scene.</description></item>
                /// <item><description><b>logo</b>: image logo.</description></item>
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
                /// <para>The details of the image review result.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult> Result { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult : TeaModel {
                    /// <summary>
                    /// <para>The review result category.</para>
                    /// <para>When scene is <b>porn</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornographic.</description></item>
                    /// <item><description><b>sexy</b>: suggestive.</description></item>
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// </list>
                    /// <para>When scene is <b>terrorism</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>bloody</b>: bloody.</description></item>
                    /// <item><description><b>explosion</b>: explosion or smoke.</description></item>
                    /// <item><description><b>outfit</b>: special outfit.</description></item>
                    /// <item><description><b>logo</b>: special logo.</description></item>
                    /// <item><description><b>weapon</b>: weapon.</description></item>
                    /// <item><description><b>politics</b>: politically sensitive.</description></item>
                    /// <item><description><b>violence</b>: violence.</description></item>
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
                    /// <item><description><b>npx</b>: psoriasis advertisement.</description></item>
                    /// <item><description><b>qrcode</b>: contains a QR code.</description></item>
                    /// <item><description><b>programCode</b>: contains a mini program code.</description></item>
                    /// </list>
                    /// <para>When scene is <b>live</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>meaningless</b>: no content in the image (such as a black or white screen).</description></item>
                    /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                    /// <item><description><b>smoking</b>: smoking.</description></item>
                    /// <item><description><b>drivelive</b>: in-car live streaming.</description></item>
                    /// </list>
                    /// <para>When scene is <b>logo</b>, valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>TV</b>: contains a controlled logo.</description></item>
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
                    /// <para>The review scenario. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornography detection.</description></item>
                    /// <item><description><b>terrorism</b>: terrorist or politically sensitive content.</description></item>
                    /// <item><description><b>ad</b>: image or text violation.</description></item>
                    /// <item><description><b>live</b>: undesirable scene.</description></item>
                    /// <item><description><b>logo</b>: image logo.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score of the image that hits the label. Value range: <c>[0, 100]</c>. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00000</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The review result suggestion. Valid values:</para>
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

                }

                /// <summary>
                /// <para>The review result suggestion. Valid values:</para>
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
                /// <para>The image category. Valid values: <b>cover</b> (thumbnail).</para>
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
            /// <para>The review result categories. Multiple values are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>porn</b>: pornographic content.</description></item>
            /// <item><description><b>terrorism</b>: terrorist or politically sensitive content.</description></item>
            /// <item><description><b>ad</b>: image or text violation.</description></item>
            /// <item><description><b>live</b>: undesirable scene.</description></item>
            /// <item><description><b>logo</b>: image logo.</description></item>
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
            /// <para>The review result suggestion. Valid values:</para>
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
            /// <para>The text review result.</para>
            /// </summary>
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                /// <summary>
                /// <para>The reviewed text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline 123****</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The review result category. Valid values:</para>
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
                /// <para>The review scenario. Fixed value: <b>antispam</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>antispam</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The score of the text that hits the label. Value range: <c>[0, 100]</c>. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00000</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The review result suggestion. Valid values:</para>
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
            /// <para>The video review result.</para>
            /// </summary>
            [NameInMap("VideoResult")]
            [Validation(Required=false)]
            public GetMediaAuditResultResponseBodyMediaAuditResultVideoResult VideoResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResult : TeaModel {
                /// <summary>
                /// <para>The advertisement review result.</para>
                /// </summary>
                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the review result and the number of video snapshots for each category.</para>
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
                        /// <para>The advertisement review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisement.</description></item>
                        /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                        /// <item><description><b>npx</b>: psoriasis advertisement.</description></item>
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

                    }

                    /// <summary>
                    /// <para>The advertisement review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>ad</b>: other advertisement.</description></item>
                    /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                    /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                    /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                    /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                    /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                    /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                    /// <item><description><b>npx</b>: psoriasis advertisement.</description></item>
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
                    /// <para>The highest score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The review result suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Violation.</description></item>
                    /// <item><description><b>review</b>: Suspected violation.</description></item>
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
                    /// <para>The information about the video snapshots with the highest scores that hit the label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The advertisement review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisement.</description></item>
                        /// <item><description><b>politics</b>: text contains politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text contains pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text contains abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text contains terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text contains prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text contains other spam content.</description></item>
                        /// <item><description><b>npx</b>: psoriasis advertisement.</description></item>
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
                        /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
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
                /// <para>The review result category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: pornographic content.</description></item>
                /// <item><description><b>terrorism</b>: terrorist or politically sensitive content.</description></item>
                /// <item><description><b>ad</b>: image or text violation.</description></item>
                /// <item><description><b>live</b>: undesirable scene.</description></item>
                /// <item><description><b>logo</b>: image logo.</description></item>
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
                /// <para>The undesirable content review result.</para>
                /// </summary>
                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the undesirable content review result and the number of video snapshots for each category.</para>
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
                        /// <para>The review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>meaningless</b>: no content in the image (such as a black or white screen).</description></item>
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
                    /// <para>The review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>meaningless</b>: no content in the image (such as a black or white screen).</description></item>
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
                    /// <para>The highest score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The review result suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Violation.</description></item>
                    /// <item><description><b>review</b>: Suspected violation.</description></item>
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
                    /// <para>The information about the video snapshots with the highest scores that hit the label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>meaningless</b>: no content in the image (such as a black or white screen).</description></item>
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
                        /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
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
                /// <para>The logo review result.</para>
                /// </summary>
                [NameInMap("LogoResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult LogoResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the review result and the number of video snapshots for each category.</para>
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
                        /// <para>The logo review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>TV</b>: contains a controlled logo.</description></item>
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
                    /// <para>The logo review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>TV</b>: contains a controlled logo.</description></item>
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
                    /// <para>The highest score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The review result suggestion. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b>: Violation.</description></item>
                    /// <item><description><b>review</b>: Suspected violation.</description></item>
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
                    /// <para>The information about the video snapshots with the highest scores that hit the label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The logo review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>TV</b>: contains a controlled logo.</description></item>
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
                        /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
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
                    /// <para>The average score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the review result and the number of video snapshots for each category.</para>
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
                        /// <item><description><b>sexy</b>: suggestive.</description></item>
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
                    /// <item><description><b>sexy</b>: suggestive.</description></item>
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
                    /// <para>The highest score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The pornography detection suggestion. Valid values:</para>
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
                    /// <para>The information about the video snapshots with the highest scores that hit the label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The pornography detection result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: pornographic.</description></item>
                        /// <item><description><b>sexy</b>: suggestive.</description></item>
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
                        /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
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
                /// <para>The review result suggestion. Valid values:</para>
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
                /// <para>The terrorism and politically sensitive content review result.</para>
                /// </summary>
                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
                    /// <summary>
                    /// <para>The average score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    /// <summary>
                    /// <para>The categories of the terrorism and politically sensitive content review result and the number of video snapshots for each category.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of video snapshots that contain terrorism or politically sensitive content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The terrorism and politically sensitive content review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>bloody</b>: bloody.</description></item>
                        /// <item><description><b>explosion</b>: explosion or smoke.</description></item>
                        /// <item><description><b>outfit</b>: special outfit.</description></item>
                        /// <item><description><b>logo</b>: special logo.</description></item>
                        /// <item><description><b>weapon</b>: weapon.</description></item>
                        /// <item><description><b>politics</b>: politically sensitive.</description></item>
                        /// <item><description><b>violence</b>: violence.</description></item>
                        /// <item><description><b>crowd</b>: crowd gathering.</description></item>
                        /// <item><description><b>parade</b>: parade.</description></item>
                        /// <item><description><b>carcrash</b>: car crash scene.</description></item>
                        /// <item><description><b>flag</b>: flag.</description></item>
                        /// <item><description><b>location</b>: landmark.</description></item>
                        /// <item><description><b>others</b>: others.</description></item>
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
                    /// <para>The terrorism and politically sensitive content review result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>bloody</b>: bloody.</description></item>
                    /// <item><description><b>explosion</b>: explosion or smoke.</description></item>
                    /// <item><description><b>outfit</b>: special outfit.</description></item>
                    /// <item><description><b>logo</b>: special logo.</description></item>
                    /// <item><description><b>weapon</b>: weapon.</description></item>
                    /// <item><description><b>politics</b>: politically sensitive.</description></item>
                    /// <item><description><b>violence</b>: violence.</description></item>
                    /// <item><description><b>crowd</b>: crowd gathering.</description></item>
                    /// <item><description><b>parade</b>: parade.</description></item>
                    /// <item><description><b>carcrash</b>: car crash scene.</description></item>
                    /// <item><description><b>flag</b>: flag.</description></item>
                    /// <item><description><b>location</b>: landmark.</description></item>
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
                    /// <para>The highest score of the video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The terrorism and politically sensitive content review suggestion. Valid values:</para>
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
                    /// <para>The information about the video snapshots with the highest scores that hit the label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The terrorism and politically sensitive content review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>bloody</b>: bloody.</description></item>
                        /// <item><description><b>explosion</b>: explosion or smoke.</description></item>
                        /// <item><description><b>outfit</b>: special outfit.</description></item>
                        /// <item><description><b>logo</b>: special logo.</description></item>
                        /// <item><description><b>weapon</b>: weapon.</description></item>
                        /// <item><description><b>politics</b>: politically sensitive.</description></item>
                        /// <item><description><b>violence</b>: violence.</description></item>
                        /// <item><description><b>crowd</b>: crowd gathering.</description></item>
                        /// <item><description><b>parade</b>: parade.</description></item>
                        /// <item><description><b>carcrash</b>: car crash scene.</description></item>
                        /// <item><description><b>flag</b>: flag.</description></item>
                        /// <item><description><b>location</b>: landmark.</description></item>
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
                        /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher score indicates higher accuracy.</para>
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
