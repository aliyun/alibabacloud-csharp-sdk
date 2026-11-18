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
            /// <para>The job error code. Check this field when the job status is fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The end time of the job. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T13:00:00Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The start time of the job. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
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
                /// <para>The reviewed content that contains violations. Multiple values are separated by commas (,). Valid values:</para>
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
                /// <para>The audio review result.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult> AudioResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: Normal.</description></item>
                    /// <item><description><b>spam</b>: Spam content.</description></item>
                    /// <item><description><b>ad</b>: Ad.</description></item>
                    /// <item><description><b>politics</b>: Political content.</description></item>
                    /// <item><description><b>terrorism</b>: Terrorist content.</description></item>
                    /// <item><description><b>abuse</b>: Abuse.</description></item>
                    /// <item><description><b>porn</b>: Pornographic content.</description></item>
                    /// <item><description><b>flood</b>: Flooding.</description></item>
                    /// <item><description><b>contraband</b>: Contraband.</description></item>
                    /// <item><description><b>meaningless</b>: Meaningless.</description></item>
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
                    /// <para>The review suggestion. Valid values:</para>
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
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult> ImageResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult : TeaModel {
                    /// <summary>
                    /// <para>The image review result category. Multiple values are separated by commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: Pornographic content.</description></item>
                    /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
                    /// <item><description><b>ad</b>: Image and text violation.</description></item>
                    /// <item><description><b>live</b>: Undesirable scene.</description></item>
                    /// <item><description><b>logo</b>: Image logo.</description></item>
                    /// <item><description><b>normal</b>: Normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The image review result details.</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult> Result { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult : TeaModel {
                        /// <summary>
                        /// <para>The review result category.</para>
                        /// <para>When the scene is <b>porn</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b>: Pornographic.</description></item>
                        /// <item><description><b>sexy</b>: Sexy.</description></item>
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// </list>
                        /// <para>When the scene is <b>terrorism</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>bloody</b>: Bloody.</description></item>
                        /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                        /// <item><description><b>outfit</b>: Special outfit.</description></item>
                        /// <item><description><b>logo</b>: Special logo.</description></item>
                        /// <item><description><b>weapon</b>: Weapon.</description></item>
                        /// <item><description><b>politics</b>: Political content.</description></item>
                        /// <item><description><b>violence</b>: Violence.</description></item>
                        /// <item><description><b>crowd</b>: Crowd.</description></item>
                        /// <item><description><b>parade</b>: Parade.</description></item>
                        /// <item><description><b>carcrash</b>: Car crash.</description></item>
                        /// <item><description><b>flag</b>: Flag.</description></item>
                        /// <item><description><b>location</b>: Landmark.</description></item>
                        /// <item><description><b>others</b>: Others.</description></item>
                        /// </list>
                        /// <para>When the scene is <b>ad</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>ad</b>: Other ads.</description></item>
                        /// <item><description><b>politics</b>: Text containing political content.</description></item>
                        /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                        /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: Nuisance ad.</description></item>
                        /// <item><description><b>qrcode</b>: QR code included.</description></item>
                        /// <item><description><b>programCode</b>: Mini program code included.</description></item>
                        /// </list>
                        /// <para>When the scene is <b>live</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>meaningless</b>: No content in the image, such as a black or white screen.</description></item>
                        /// <item><description><b>PIP</b>: Picture-in-Picture (PiP).</description></item>
                        /// <item><description><b>smoking</b>: Smoking.</description></item>
                        /// <item><description><b>drivelive</b>: In-car live streaming.</description></item>
                        /// </list>
                        /// <para>When the scene is <b>logo</b>, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>TV</b>: Regulated logo included.</description></item>
                        /// <item><description><b>trademark</b>: Trademark included.</description></item>
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
                        /// <item><description><b>porn</b>: Pornography detection.</description></item>
                        /// <item><description><b>terrorism</b>: Terrorist and political content detection.</description></item>
                        /// <item><description><b>ad</b>: Image and text violation detection.</description></item>
                        /// <item><description><b>live</b>: Undesirable scene detection.</description></item>
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
                        /// <para>The score of the image that hits the label. Valid values: <c>[0, 100]</c>. The score indicates the probability that the image belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The review suggestion. Valid values:</para>
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
                    /// <para>The review suggestion. Valid values:</para>
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
                /// <para>The review result category. Multiple values are separated by commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b>: Pornographic content.</description></item>
                /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
                /// <item><description><b>ad</b>: Image and text violation.</description></item>
                /// <item><description><b>live</b>: Undesirable scene.</description></item>
                /// <item><description><b>logo</b>: Image logo.</description></item>
                /// <item><description><b>audio</b>: Audio anti-spam.</description></item>
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The review suggestion. Valid values:</para>
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
                    /// <para>The review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>spam</b>: Spam content.</description></item>
                    /// <item><description><b>ad</b>: Ad.</description></item>
                    /// <item><description><b>abuse</b>: Abuse.</description></item>
                    /// <item><description><b>flood</b>: Flooding.</description></item>
                    /// <item><description><b>contraband</b>: Contraband.</description></item>
                    /// <item><description><b>meaningless</b>: Meaningless.</description></item>
                    /// <item><description><b>normal</b>: Normal.</description></item>
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
                    /// <para>The score of the image that hits the label. Valid values: <c>[0, 100]</c>. The score indicates the probability that the image belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The review suggestion. Valid values:</para>
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
                /// <para>The video review result.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult VideoResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The ad review result.</para>
                    /// </summary>
                    [NameInMap("AdResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult AdResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the ad review result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of the review results and the number of video snapshots for each category.</para>
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
                            /// <para>The ad review result category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>ad</b>: Other ads.</description></item>
                            /// <item><description><b>politics</b>: Text containing political content.</description></item>
                            /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                            /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                            /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                            /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                            /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                            /// <item><description><b>npx</b>: Nuisance ad.</description></item>
                            /// <item><description><b>qrcode</b>: QR code included.</description></item>
                            /// <item><description><b>programCode</b>: Mini program code included.</description></item>
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
                        /// <para>The ad review result category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>ad</b>: Other ads.</description></item>
                        /// <item><description><b>politics</b>: Text containing political content.</description></item>
                        /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                        /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                        /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                        /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                        /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                        /// <item><description><b>npx</b>: Nuisance ad.</description></item>
                        /// <item><description><b>qrcode</b>: QR code included.</description></item>
                        /// <item><description><b>programCode</b>: Mini program code included.</description></item>
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
                        /// <para>The review suggestion. Valid values:</para>
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
                        /// <para>The information about the video snapshots with the highest scores for the hit label.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The ad review result category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>ad</b>: Other ads.</description></item>
                            /// <item><description><b>politics</b>: Text containing political content.</description></item>
                            /// <item><description><b>porn</b>: Text containing pornographic content.</description></item>
                            /// <item><description><b>abuse</b>: Text containing abusive content.</description></item>
                            /// <item><description><b>terrorism</b>: Text containing terrorist content.</description></item>
                            /// <item><description><b>contraband</b>: Text containing contraband content.</description></item>
                            /// <item><description><b>spam</b>: Text containing other spam content.</description></item>
                            /// <item><description><b>npx</b>: Nuisance ad.</description></item>
                            /// <item><description><b>qrcode</b>: QR code included.</description></item>
                            /// <item><description><b>programCode</b>: Mini program code included.</description></item>
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
                    /// <para>The GreenEnhanced moderation result.</para>
                    /// </summary>
                    [NameInMap("GreenEnhancedResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResult GreenEnhancedResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResult : TeaModel {
                        /// <summary>
                        /// <para>The average confidence score of the hit frames. This parameter is not returned if no frames are hit.</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The aggregated count of violation labels, including Label (the Green label) and Count (the number of frames that hit the label).</para>
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultCounterList : TeaModel {
                            /// <summary>
                            /// <para>The number of video frames that correspond to the label.</para>
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
                        /// <para>The union of hit Green native labels, separated by commas, such as pornographic_adultContent_tii. If no labels are hit, the value is normal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>normal</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest confidence score of the hit frames. This parameter is not returned if no frames are hit.</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The image moderation conclusion, which is mapped from frameResult.riskLevel: high to block, medium or low to review, and none to pass.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pass</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The details of the hit frames, sorted in descending order of confidence score.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultGreenEnhancedResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The moderation category.</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The confidence score of the video snapshot that hits the label.</para>
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
                    /// <para>The review result category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: Pornographic content.</description></item>
                    /// <item><description><b>terrorism</b>: Terrorist and political content.</description></item>
                    /// <item><description><b>ad</b>: Image and text violation.</description></item>
                    /// <item><description><b>live</b>: Undesirable scene.</description></item>
                    /// <item><description><b>logo</b>: Image logo.</description></item>
                    /// <item><description><b>normal</b>: Normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The harmful content moderation result.</para>
                    /// </summary>
                    [NameInMap("LiveResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult LiveResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the moderation result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The moderation categories and the number of video snapshots for each category.</para>
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
                            /// <para>The moderation category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal</description></item>
                            /// <item><description><b>meaningless</b>: the image contains no content, such as a black or white screen</description></item>
                            /// <item><description><b>PIP</b>: Picture-in-Picture (PiP)</description></item>
                            /// <item><description><b>smoking</b>: smoking</description></item>
                            /// <item><description><b>drivelive</b>: live streaming inside a vehicle</description></item>
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
                        /// <para>The moderation category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal</description></item>
                        /// <item><description><b>meaningless</b>: the image contains no content, such as a black or white screen</description></item>
                        /// <item><description><b>PIP</b>: Picture-in-Picture (PiP)</description></item>
                        /// <item><description><b>smoking</b>: smoking</description></item>
                        /// <item><description><b>drivelive</b>: live streaming inside a vehicle</description></item>
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
                        /// <para>The moderation suggestion. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates regulations.</description></item>
                        /// <item><description><b>review</b>: The content is suspected of violating regulations.</description></item>
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
                        /// <para>The information about the video snapshots with the highest scores for the hit label.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The moderation category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal</description></item>
                            /// <item><description><b>meaningless</b>: the image contains no content, such as a black or white screen</description></item>
                            /// <item><description><b>PIP</b>: Picture-in-Picture (PiP)</description></item>
                            /// <item><description><b>smoking</b>: smoking</description></item>
                            /// <item><description><b>drivelive</b>: live streaming inside a vehicle</description></item>
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
                    /// <para>The logo moderation result.</para>
                    /// </summary>
                    [NameInMap("LogoResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult LogoResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the video snapshots that hit the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The moderation categories and the number of video snapshots for each category.</para>
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
                            /// <para>The logo moderation category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal</description></item>
                            /// <item><description><b>TV</b>: the image contains a regulated logo</description></item>
                            /// <item><description><b>trademark</b>: the image contains a trademark</description></item>
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
                        /// <para>The logo moderation category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal</description></item>
                        /// <item><description><b>TV</b>: the image contains a regulated logo</description></item>
                        /// <item><description><b>trademark</b>: the image contains a trademark</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest score of the video snapshots that hit the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The logo moderation suggestion. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates regulations.</description></item>
                        /// <item><description><b>review</b>: The content is suspected of violating regulations.</description></item>
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
                        /// <para>The information about the video snapshots with the highest scores for the hit label.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The logo moderation category. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal</description></item>
                            /// <item><description><b>TV</b>: the image contains a regulated logo</description></item>
                            /// <item><description><b>trademark</b>: the image contains a trademark</description></item>
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
                        /// <para>The average score of the video snapshots that hit the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of the review results and the number of video snapshots for each category.</para>
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
                            /// <item><description><b>porn</b>: Pornographic.</description></item>
                            /// <item><description><b>sexy</b>: Sexy.</description></item>
                            /// <item><description><b>normal</b>: Normal.</description></item>
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
                        /// <item><description><b>porn</b>: Pornographic.</description></item>
                        /// <item><description><b>sexy</b>: Sexy.</description></item>
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest score of the video snapshots that hit the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
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
                        /// <para>The information about the video snapshots with the highest scores for the hit label.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The pornography detection result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>porn</b>: Pornographic.</description></item>
                            /// <item><description><b>sexy</b>: Sexy.</description></item>
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>porn</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the video snapshot that hits the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
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
                    /// <para>The video review suggestion. Valid values:</para>
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
                    /// <para>The terrorist and political content review result.</para>
                    /// </summary>
                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult TerrorismResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the video snapshots that hit the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of the terrorist and political content review results and the number of video snapshots for each category.</para>
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
                            /// <para>The terrorist and political content review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>bloody</b>: Bloody.</description></item>
                            /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                            /// <item><description><b>outfit</b>: Special outfit.</description></item>
                            /// <item><description><b>logo</b>: Special logo.</description></item>
                            /// <item><description><b>weapon</b>: Weapon.</description></item>
                            /// <item><description><b>politics</b>: Political content.</description></item>
                            /// <item><description><b>violence</b>: Violence.</description></item>
                            /// <item><description><b>crowd</b>: Crowd.</description></item>
                            /// <item><description><b>parade</b>: Parade.</description></item>
                            /// <item><description><b>carcrash</b>: Car crash.</description></item>
                            /// <item><description><b>flag</b>: Flag.</description></item>
                            /// <item><description><b>location</b>: Landmark.</description></item>
                            /// <item><description><b>others</b>: Others.</description></item>
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
                        /// <para>The terrorist and political content review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: Normal.</description></item>
                        /// <item><description><b>bloody</b>: Bloody.</description></item>
                        /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                        /// <item><description><b>outfit</b>: Special outfit.</description></item>
                        /// <item><description><b>logo</b>: Special logo.</description></item>
                        /// <item><description><b>weapon</b>: Weapon.</description></item>
                        /// <item><description><b>politics</b>: Political content.</description></item>
                        /// <item><description><b>violence</b>: Violence.</description></item>
                        /// <item><description><b>crowd</b>: Crowd.</description></item>
                        /// <item><description><b>parade</b>: Parade.</description></item>
                        /// <item><description><b>carcrash</b>: Car crash.</description></item>
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
                        /// <para>The highest score of the video snapshots that hit the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The terrorist and political content review suggestion. Valid values:</para>
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
                        /// <para>The information about the video snapshots with the highest scores for the hit label.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The terrorist and political content review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: Normal.</description></item>
                            /// <item><description><b>bloody</b>: Bloody.</description></item>
                            /// <item><description><b>explosion</b>: Explosion and smoke.</description></item>
                            /// <item><description><b>outfit</b>: Special outfit.</description></item>
                            /// <item><description><b>logo</b>: Special logo.</description></item>
                            /// <item><description><b>weapon</b>: Weapon.</description></item>
                            /// <item><description><b>politics</b>: Political content.</description></item>
                            /// <item><description><b>violence</b>: Violence.</description></item>
                            /// <item><description><b>crowd</b>: Crowd.</description></item>
                            /// <item><description><b>parade</b>: Parade.</description></item>
                            /// <item><description><b>carcrash</b>: Car crash.</description></item>
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
                            /// <para>The score of the video snapshot that hits the label. Valid values: <c>[0, 100]</c>. The precision is 10 decimal places. The score indicates the probability that the snapshot belongs to the corresponding label category. A higher score indicates higher accuracy.</para>
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
            /// <para>The job error message. Check this field when the job status is fail.</para>
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
            /// <item><description><b>success</b>: Succeeded.</description></item>
            /// <item><description><b>fail</b>: Failed.</description></item>
            /// <item><description><b>init</b>: Initialized.</description></item>
            /// <item><description><b>processing</b>: Processing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job type. Currently, only automated review is supported.</para>
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
