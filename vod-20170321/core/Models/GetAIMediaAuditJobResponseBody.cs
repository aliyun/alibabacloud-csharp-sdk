// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIMediaAuditJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The automated review job information.</para>
        /// </summary>
        [NameInMap("MediaAuditJob")]
        [Validation(Required=false)]
        public GetAIMediaAuditJobResponseBodyMediaAuditJob MediaAuditJob { get; set; }
        public class GetAIMediaAuditJobResponseBodyMediaAuditJob : TeaModel {
            /// <summary>
            /// <para>The error code of the job. This field is relevant when Status is fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job ended. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T13:00:00Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the job started. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The job result data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetAIMediaAuditJobResponseBodyMediaAuditJobData Data { get; set; }
            public class GetAIMediaAuditJobResponseBodyMediaAuditJobData : TeaModel {
                /// <summary>
                /// <para>The content that violates the moderation rules. Multiple values are separated by commas (,). Valid values:</para>
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
                /// <para>The audio review results.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult> AudioResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The category of the review result:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// <item><description><b>spam</b>: spam.</description></item>
                    /// <item><description><b>ad</b>: advertisement.</description></item>
                    /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                    /// <item><description><b>terrorism</b>: terrorist content.</description></item>
                    /// <item><description><b>abuse</b>: abuse.</description></item>
                    /// <item><description><b>porn</b>: pornographic content.</description></item>
                    /// <item><description><b>flood</b>: flooding.</description></item>
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
                    /// <para>The review scene. Fixed value: <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The result score.</para>
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
                /// <para>The image review results.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult> ImageResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult : TeaModel {
                    /// <summary>
                    /// <para>The category of the image review result. Multiple values are separated by commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornography.</description></item>
                    /// <item><description><b>terrorism</b>: terrorist content and political sensitivity.</description></item>
                    /// <item><description><b>ad</b>: image and text violations.</description></item>
                    /// <item><description><b>live</b>: undesirable scenes.</description></item>
                    /// <item><description><b>logo</b>: logo in images.</description></item>
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The details of the image review result.</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult> Result { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult : TeaModel {
                        /// <summary>
                        /// <para>The category of the review result.</para>
                        /// <para>When scene is <b>porn</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: pornographic content.</description></item>
                        /// <item><description><b>sexy</b>: sexy content.</description></item>
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// </list>
                        /// <para>When scene is <b>terrorism</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>bloody</b>: bloody content.</description></item>
                        /// <item><description><b>explosion</b>: explosions and smoke.</description></item>
                        /// <item><description><b>outfit</b>: special outfits.</description></item>
                        /// <item><description><b>logo</b>: special logos.</description></item>
                        /// <item><description><b>weapon</b>: weapons.</description></item>
                        /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                        /// <item><description><b>violence</b>: fighting.</description></item>
                        /// <item><description><b>crowd</b>: crowds.</description></item>
                        /// <item><description><b>parade</b>: parades.</description></item>
                        /// <item><description><b>carcrash</b>: car accident scenes.</description></item>
                        /// <item><description><b>flag</b>: flags.</description></item>
                        /// <item><description><b>location</b>: landmarks.</description></item>
                        /// <item><description><b>others</b>: others.</description></item>
                        /// </list>
                        /// <para>When scene is <b>ad</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisements.</description></item>
                        /// <item><description><b>politics</b>: text containing politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text containing prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: psoriasis advertisements.</description></item>
                        /// <item><description><b>qrcode</b>: contains QR codes.</description></item>
                        /// <item><description><b>programCode</b>: contains mini program codes.</description></item>
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
                        /// <item><description><b>TV</b>: contains regulated logos.</description></item>
                        /// <item><description><b>trademark</b>: contains trademarks.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The review scene. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: pornography detection.</description></item>
                        /// <item><description><b>terrorism</b>: terrorist content and political sensitivity.</description></item>
                        /// <item><description><b>ad</b>: image and text violations.</description></item>
                        /// <item><description><b>live</b>: undesirable scenes.</description></item>
                        /// <item><description><b>logo</b>: logo in images.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Scene")]
                        [Validation(Required=false)]
                        public string Scene { get; set; }

                        /// <summary>
                        /// <para>The score of the image that hits the label. Value range: <c>[0, 100]</c>. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
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
                /// <para>The category of the review result. Multiple values are separated by commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: pornography.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content and political sensitivity.</description></item>
                /// <item><description><b>ad</b>: image and text violations.</description></item>
                /// <item><description><b>live</b>: undesirable scenes.</description></item>
                /// <item><description><b>logo</b>: logo in images.</description></item>
                /// <item><description><b>audio</b>: audio anti-spam.</description></item>
                /// <item><description><b>normal</b>: normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
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
                /// <para>The text review results.</para>
                /// </summary>
                [NameInMap("TextResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult> TextResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult : TeaModel {
                    /// <summary>
                    /// <para>The text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The category of the review result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>spam</b>: spam.</description></item>
                    /// <item><description><b>ad</b>: advertisement.</description></item>
                    /// <item><description><b>abuse</b>: abuse.</description></item>
                    /// <item><description><b>flood</b>: flooding.</description></item>
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
                    /// <para>The review scene. Fixed value: <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score of the image that hits the label. Value range: <c>[0, 100]</c>. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
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
                /// <para>The video review results.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult VideoResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The advertisement review result.</para>
                    /// </summary>
                    [NameInMap("AdResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult AdResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the advertisement review result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The review result categories and the number of video snapshots for each category.</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of video snapshots.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// <para>The category of the advertisement review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal.</description></item>
                            /// <item><description><b>ad</b>: other advertisements.</description></item>
                            /// <item><description><b>politics</b>: text containing politically sensitive content.</description></item>
                            /// <item><description><b>porn</b>: text containing pornographic content.</description></item>
                            /// <item><description><b>abuse</b>: text containing abusive content.</description></item>
                            /// <item><description><b>terrorism</b>: text containing terrorist content.</description></item>
                            /// <item><description><b>contraband</b>: text containing prohibited content.</description></item>
                            /// <item><description><b>spam</b>: text containing other spam content.</description></item>
                            /// <item><description><b>npx</b>: psoriasis advertisements.</description></item>
                            /// <item><description><b>qrcode</b>: contains QR codes.</description></item>
                            /// <item><description><b>programCode</b>: contains mini program codes.</description></item>
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
                        /// <para>The category of the advertisement review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>ad</b>: other advertisements.</description></item>
                        /// <item><description><b>politics</b>: text containing politically sensitive content.</description></item>
                        /// <item><description><b>porn</b>: text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: text containing prohibited content.</description></item>
                        /// <item><description><b>spam</b>: text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: psoriasis advertisements.</description></item>
                        /// <item><description><b>qrcode</b>: contains QR codes.</description></item>
                        /// <item><description><b>programCode</b>: contains mini program codes.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest review score.</para>
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
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The category of the advertisement review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal.</description></item>
                            /// <item><description><b>ad</b>: other advertisements.</description></item>
                            /// <item><description><b>politics</b>: text containing politically sensitive content.</description></item>
                            /// <item><description><b>porn</b>: text containing pornographic content.</description></item>
                            /// <item><description><b>abuse</b>: text containing abusive content.</description></item>
                            /// <item><description><b>terrorism</b>: text containing terrorist content.</description></item>
                            /// <item><description><b>contraband</b>: text containing prohibited content.</description></item>
                            /// <item><description><b>spam</b>: text containing other spam content.</description></item>
                            /// <item><description><b>npx</b>: psoriasis advertisements.</description></item>
                            /// <item><description><b>qrcode</b>: contains QR codes.</description></item>
                            /// <item><description><b>programCode</b>: contains mini program codes.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ad</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the video snapshot that hits the label.</para>
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
                            /// <para>500</para>
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
                    /// <para>The GreenEnhanced review result.</para>
                    /// </summary>
                    [NameInMap("GreenEnhancedResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResult GreenEnhancedResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResult : TeaModel {
                        /// <summary>
                        /// <para>The average confidence score of hit frames. This field is not returned if no frame is hit.</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The violation label count aggregation: Label (Green label) / Count (number of hit frames for the label).</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of captured video frames for the corresponding label.</para>
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
                        /// <para>The union of hit Green native labels (comma-separated, such as pornographic_adultContent_tii). The value is normal if no label is hit.</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest confidence score of hit frames. This field is not returned if no frame is hit.</para>
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
                        /// <para>The hit frame details (sorted by confidence in descending order).</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The review result category.</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The confidence score of the video snapshot that hit the label.</para>
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
                    /// <para>The category of the review result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornography.</description></item>
                    /// <item><description><b>terrorism</b>: terrorist content and political sensitivity.</description></item>
                    /// <item><description><b>ad</b>: image and text violations.</description></item>
                    /// <item><description><b>live</b>: undesirable scenes.</description></item>
                    /// <item><description><b>logo</b>: logo in images.</description></item>
                    /// <item><description><b>normal</b>: normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The review results for inappropriate content.</para>
                    /// </summary>
                    [NameInMap("LiveResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult LiveResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the review result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of the review results and the number of video snapshots in each category.</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of video snapshots.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>4</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>meaningless</b>: No content in the image (for example, black screen or white screen).</description></item>
                            /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                            /// <item><description><b>smoking</b>: Smoking.</description></item>
                            /// <item><description><b>drivelive</b>: In-car live streaming.</description></item>
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
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>meaningless</b>: No content in the image (for example, black screen or white screen).</description></item>
                        /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                        /// <item><description><b>smoking</b>: Smoking.</description></item>
                        /// <item><description><b>drivelive</b>: In-car live streaming.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>smoking</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest review score.</para>
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
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>meaningless</b>: No content in the image (for example, black screen or white screen).</description></item>
                            /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                            /// <item><description><b>smoking</b>: Smoking.</description></item>
                            /// <item><description><b>drivelive</b>: In-car live streaming.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>smoking</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the video snapshot that hits the label.</para>
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
                            /// <para>500</para>
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
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult LogoResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of video snapshots that hit the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of the review results and the number of video snapshots in each category.</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList : TeaModel {
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
                            /// <para>The category of the logo review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>TV</b>: Contains a regulated logo.</description></item>
                            /// <item><description><b>trademark</b>: Contains a trademark.</description></item>
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
                        /// <para>The category of the logo review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>TV</b>: Contains a regulated logo.</description></item>
                        /// <item><description><b>trademark</b>: Contains a trademark.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest score of video snapshots that hit the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The logo review suggestion. Valid values:</para>
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
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The category of the logo review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>TV</b>: Contains a regulated logo.</description></item>
                            /// <item><description><b>trademark</b>: Contains a trademark.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TV</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the video snapshot that hits the label.</para>
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
                            /// <para>5000</para>
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
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult PornResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The review result categories and the number of video snapshots for each category.</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of video snapshots.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// <para>The pornography detection result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>porn</b>: pornographic content.</description></item>
                            /// <item><description><b>sexy</b>: sexy content.</description></item>
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
                        /// <item><description><b>porn</b>: pornographic content.</description></item>
                        /// <item><description><b>sexy</b>: sexy content.</description></item>
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
                        /// <para>The highest score of video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
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
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The pornography detection result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>porn</b>: pornographic content.</description></item>
                            /// <item><description><b>sexy</b>: sexy content.</description></item>
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
                            /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
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
                    /// <para>The video review result suggestion. Valid values:</para>
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
                    /// <para>The terrorism and political sensitivity review result.</para>
                    /// </summary>
                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult TerrorismResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The terrorism and political sensitivity result categories and the number of video snapshots for each category.</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of video snapshots.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// <para>The terrorism and political sensitivity review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal.</description></item>
                            /// <item><description><b>bloody</b>: bloody content.</description></item>
                            /// <item><description><b>explosion</b>: explosions and smoke.</description></item>
                            /// <item><description><b>outfit</b>: special outfits.</description></item>
                            /// <item><description><b>logo</b>: special logos.</description></item>
                            /// <item><description><b>weapon</b>: weapons.</description></item>
                            /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                            /// <item><description><b>violence</b>: fighting.</description></item>
                            /// <item><description><b>crowd</b>: crowds.</description></item>
                            /// <item><description><b>parade</b>: parades.</description></item>
                            /// <item><description><b>carcrash</b>: car accident scenes.</description></item>
                            /// <item><description><b>flag</b>: flags.</description></item>
                            /// <item><description><b>location</b>: landmarks.</description></item>
                            /// <item><description><b>others</b>: others.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>terrorism</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// <para>The terrorism and political sensitivity review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal.</description></item>
                        /// <item><description><b>bloody</b>: bloody content.</description></item>
                        /// <item><description><b>explosion</b>: explosions and smoke.</description></item>
                        /// <item><description><b>outfit</b>: special outfits.</description></item>
                        /// <item><description><b>logo</b>: special logos.</description></item>
                        /// <item><description><b>weapon</b>: weapons.</description></item>
                        /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                        /// <item><description><b>violence</b>: fighting.</description></item>
                        /// <item><description><b>crowd</b>: crowds.</description></item>
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
                        /// <para>The highest score of video snapshots that hit the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The terrorism and political sensitivity review suggestion. Valid values:</para>
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
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The terrorism and political sensitivity review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal.</description></item>
                            /// <item><description><b>bloody</b>: bloody content.</description></item>
                            /// <item><description><b>explosion</b>: explosions and smoke.</description></item>
                            /// <item><description><b>outfit</b>: special outfits.</description></item>
                            /// <item><description><b>logo</b>: special logos.</description></item>
                            /// <item><description><b>weapon</b>: weapons.</description></item>
                            /// <item><description><b>politics</b>: politically sensitive content.</description></item>
                            /// <item><description><b>violence</b>: fighting.</description></item>
                            /// <item><description><b>crowd</b>: crowds.</description></item>
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
                            /// <para>The score of the video snapshot that hits the label. Value range: <c>[0, 100]</c>, with a precision of 10 decimal places. The score indicates the probability of the corresponding label. A higher value indicates higher accuracy.</para>
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
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// <para>The URL of the video snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://ali*****.com/aivideocensor/yytysursrutyrxuq/****.jpg">http://ali*****.com/aivideocensor/yytysursrutyrxuq/****.jpg</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdbc266af6894*****943a70176d92e9</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe028d09441d*****d1afffb138cd7e</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The error message of the job. This field is relevant when Status is fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: The job is successful.</description></item>
            /// <item><description><b>fail</b>: The job failed.</description></item>
            /// <item><description><b>init</b>: The job is being initialized.</description></item>
            /// <item><description><b>processing</b>: The job is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job type. Only &quot;automated review&quot; is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIMediaAudit</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAA3E96A-02E2-41*****85-08E1D568ED3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
