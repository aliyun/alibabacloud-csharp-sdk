// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIMediaAuditJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the intelligent review job.</para>
        /// </summary>
        [NameInMap("MediaAuditJob")]
        [Validation(Required=false)]
        public GetAIMediaAuditJobResponseBodyMediaAuditJob MediaAuditJob { get; set; }
        public class GetAIMediaAuditJobResponseBodyMediaAuditJob : TeaModel {
            /// <summary>
            /// <para>The error code. This parameter is returned if the value of Status is fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job is complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T13:00:00Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the job started to run. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The job result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetAIMediaAuditJobResponseBodyMediaAuditJobData Data { get; set; }
            public class GetAIMediaAuditJobResponseBodyMediaAuditJobData : TeaModel {
                /// <summary>
                /// <para>The content that violates the regulations. Separate multiple values with commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>video</b>: the video.</description></item>
                /// <item><description><b>image-cover</b>: the cover.</description></item>
                /// <item><description><b>text-title</b>: the title.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("AbnormalModules")]
                [Validation(Required=false)]
                public string AbnormalModules { get; set; }

                /// <summary>
                /// <para>The results of audio review.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult> AudioResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The category of the review result.</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal content</description></item>
                    /// <item><description><b>spam</b>: spam</description></item>
                    /// <item><description><b>ad</b>: ads</description></item>
                    /// <item><description><b>politics</b>: political content</description></item>
                    /// <item><description><b>terrorism</b>: terrorist content</description></item>
                    /// <item><description><b>abuse</b>: abuse</description></item>
                    /// <item><description><b>porn</b>: pornographic content.</description></item>
                    /// <item><description><b>flood</b>: excessive junk content</description></item>
                    /// <item><description><b>contraband</b>: prohibited content</description></item>
                    /// <item><description><b>meaningless</b>: meaningless content</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The review scenario. The value is <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The recommendation for review results. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
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
                /// <para>The results of image review.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult> ImageResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult : TeaModel {
                    /// <summary>
                    /// <para>The categories of the image review results. Multiple values are separated by commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornographic content</description></item>
                    /// <item><description><b>terrorism</b>: terrorist or politically sensitive content</description></item>
                    /// <item><description><b>ad</b>: ad violation</description></item>
                    /// <item><description><b>live</b>: undesirable scene</description></item>
                    /// <item><description><b>logo</b>: logo</description></item>
                    /// <item><description><b>normal</b>: normal content</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>Details of image review results.</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult> Result { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult : TeaModel {
                        /// <summary>
                        /// <para>The category of the review result.</para>
                        /// <para>Valid values if scene is <b>porn</b>:</para>
                        /// <list type="bullet">
                        /// <item><description><b>porn</b></description></item>
                        /// <item><description><b>sexy</b></description></item>
                        /// <item><description><b>normal</b></description></item>
                        /// </list>
                        /// <para>Valid values if scene is <b>terrorism</b>:</para>
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
                        /// <para>Valid values if scene is <b>ad</b>:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>ad</b>: ads</description></item>
                        /// <item><description><b>politics</b>: political content</description></item>
                        /// <item><description><b>porn</b>: pornographic content</description></item>
                        /// <item><description><b>abuse</b>: verbal abuse</description></item>
                        /// <item><description><b>terrorism</b>: terrorist content</description></item>
                        /// <item><description><b>contraband</b>: prohibited content</description></item>
                        /// <item><description><b>spam</b>: spam content</description></item>
                        /// <item><description><b>npx</b>: illegal ad</description></item>
                        /// <item><description><b>qrcode</b>: QR code</description></item>
                        /// <item><description><b>programCode</b>: mini program code</description></item>
                        /// </list>
                        /// <para>Valid values if scene is <b>live</b>:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                        /// <item><description><b>PIP</b>: picture-in-picture</description></item>
                        /// <item><description><b>smoking</b>: smoking</description></item>
                        /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle</description></item>
                        /// </list>
                        /// <para>Valid values if scene is <b>logo</b>:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>TV</b>: controlled TV station logo</description></item>
                        /// <item><description><b>trademark</b>: trademark</description></item>
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
                        /// <item><description><b>porn</b>: pornographic content</description></item>
                        /// <item><description><b>terrorism</b>: terrorist or politically sensitive content</description></item>
                        /// <item><description><b>ad</b>: ad violation</description></item>
                        /// <item><description><b>live</b>: undesirable scene</description></item>
                        /// <item><description><b>logo</b>: logo</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Scene")]
                        [Validation(Required=false)]
                        public string Scene { get; set; }

                        /// <summary>
                        /// <para>The score of the image of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The score is representative of the confidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The recommendation for review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b></description></item>
                        /// <item><description><b>review</b></description></item>
                        /// <item><description><b>pass</b></description></item>
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
                    /// <para>The recommendation for review results. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The type of the image. Valid value: <b>cover</b>.</para>
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
                /// <item><description><b>porn</b>: pornographic content</description></item>
                /// <item><description><b>terrorism</b>: terrorist or politically sensitive content</description></item>
                /// <item><description><b>ad</b>: ad violation</description></item>
                /// <item><description><b>live</b>: undesirable scene</description></item>
                /// <item><description><b>logo</b>: logo</description></item>
                /// <item><description><b>audio</b>: audio anti-spam</description></item>
                /// <item><description><b>normal</b>: normal content</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The recommendation for review results. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: The content violates the regulations.</description></item>
                /// <item><description><b>review</b>: The content may violate the regulations.</description></item>
                /// <item><description><b>pass</b>: The content passes the review.</description></item>
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
                    /// <item><description><b>spam</b>: spam content</description></item>
                    /// <item><description><b>ad</b>: ads</description></item>
                    /// <item><description><b>abuse</b>: abuse</description></item>
                    /// <item><description><b>flood</b>: excessive junk content</description></item>
                    /// <item><description><b>contraband</b>: prohibited content</description></item>
                    /// <item><description><b>meaningless</b>: meaningless content</description></item>
                    /// <item><description><b>normal</b>: normal content</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The review scenario. The value is <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score of the image of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The score is representative of the confidence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// <para>The recommendation for review results. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The type of the text. The value is <b>title</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>title</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The results of video review.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult VideoResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The results of ad review.</para>
                    /// </summary>
                    [NameInMap("AdResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult AdResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the review results.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The number of snapshots of each category in the review result.</para>
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
                            /// <para>The categories of the ad review results. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>ad</b>: other ads</description></item>
                            /// <item><description><b>politics</b>: political content</description></item>
                            /// <item><description><b>porn</b>: pornographic content</description></item>
                            /// <item><description><b>abuse</b>: abuse</description></item>
                            /// <item><description><b>terrorism</b>: terrorist content</description></item>
                            /// <item><description><b>contraband</b>: prohibited content</description></item>
                            /// <item><description><b>spam</b>: spam content</description></item>
                            /// <item><description><b>npx</b>: illegal ad</description></item>
                            /// <item><description><b>qrcode</b>: QR code</description></item>
                            /// <item><description><b>programCode</b>: mini program code</description></item>
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
                        /// <para>The categories of the ad review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>ad</b>: other ads</description></item>
                        /// <item><description><b>politics</b>: political content</description></item>
                        /// <item><description><b>porn</b>: pornographic content</description></item>
                        /// <item><description><b>abuse</b>: abuse</description></item>
                        /// <item><description><b>terrorism</b>: terrorist content</description></item>
                        /// <item><description><b>contraband</b>: prohibited content</description></item>
                        /// <item><description><b>spam</b>: spam content</description></item>
                        /// <item><description><b>npx</b>: illegal ad</description></item>
                        /// <item><description><b>qrcode</b>: QR code</description></item>
                        /// <item><description><b>programCode</b>: mini program code</description></item>
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
                        /// <para>The recommendation for review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates the regulations.</description></item>
                        /// <item><description><b>review</b>: The content may violate the regulations.</description></item>
                        /// <item><description><b>pass</b>: The content passes the review.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The information about the snapshot that has the highest score in the category.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The categories of the ad review results. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>ad</b>: other ads</description></item>
                            /// <item><description><b>politics</b>: political content</description></item>
                            /// <item><description><b>porn</b>: pornographic content</description></item>
                            /// <item><description><b>abuse</b>: abuse</description></item>
                            /// <item><description><b>terrorism</b>: terrorist content</description></item>
                            /// <item><description><b>contraband</b>: prohibited content</description></item>
                            /// <item><description><b>spam</b>: spam content</description></item>
                            /// <item><description><b>npx</b>: illegal ad</description></item>
                            /// <item><description><b>qrcode</b>: QR code</description></item>
                            /// <item><description><b>programCode</b>: mini program code</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ad</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the snapshot in the category that is indicated by Label.</para>
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
                            /// <para>500</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// <para>The URL of the video snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The category of the review result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>porn</b>: pornographic content</description></item>
                    /// <item><description><b>terrorism</b>: terrorist or politically sensitive content</description></item>
                    /// <item><description><b>ad</b>: ad violation</description></item>
                    /// <item><description><b>live</b>: undesirable scene</description></item>
                    /// <item><description><b>logo</b>: logo</description></item>
                    /// <item><description><b>normal</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The results of undesired content review.</para>
                    /// </summary>
                    [NameInMap("LiveResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult LiveResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the review results.</para>
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
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                            /// <item><description><b>PIP</b>: picture-in-picture</description></item>
                            /// <item><description><b>smoking</b>: smoking</description></item>
                            /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>live</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                        /// <item><description><b>PIP</b>: picture-in-picture</description></item>
                        /// <item><description><b>smoking</b>: smoking</description></item>
                        /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>live</para>
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
                        /// <para>The recommendation for review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates the regulations.</description></item>
                        /// <item><description><b>review</b>: The content may violate the regulations.</description></item>
                        /// <item><description><b>pass</b>: The content passes the review.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The information about the snapshot that has the highest score in the category.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                            /// <item><description><b>PIP</b>: picture-in-picture</description></item>
                            /// <item><description><b>smoking</b>: smoking</description></item>
                            /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>live</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the snapshot in the category that is indicated by Label.</para>
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
                            /// <para>500</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// <para>The URL of the video snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The results of logo review.</para>
                    /// </summary>
                    [NameInMap("LogoResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult LogoResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the snapshots in the category indicated by Label.</para>
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
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>TV</b>: controlled TV station logo</description></item>
                            /// <item><description><b>trademark</b>: trademark</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>logo</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>normal</b>: normal content</description></item>
                        /// <item><description><b>TV</b>: controlled TV station logo</description></item>
                        /// <item><description><b>trademark</b>: trademark</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>logo</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The highest score of the snapshot of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The recommendation for review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates the regulations.</description></item>
                        /// <item><description><b>review</b>: The content may violate the regulations.</description></item>
                        /// <item><description><b>pass</b>: The content passes the review.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>block</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The information about the snapshot that has the highest score in the category.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The category of the review result. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content</description></item>
                            /// <item><description><b>TV</b>: controlled TV station logo</description></item>
                            /// <item><description><b>trademark</b>: trademark</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>logo</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score of the snapshot in the category that is indicated by Label.</para>
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
                            /// <para>5000</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// <para>The URL of the video snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The results of pornographic content review.</para>
                    /// </summary>
                    [NameInMap("PornResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult PornResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the snapshots of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The number of snapshots of each category in the review result.</para>
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
                            /// <para>The results of pornographic content review. Valid values:</para>
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

                        }

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
                        /// <para>The highest score of the snapshot of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The recommendation for review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b>: The content violates the regulations.</description></item>
                        /// <item><description><b>review</b>: The content may violate the regulations.</description></item>
                        /// <item><description><b>pass</b>: The content passes the review.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pass</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The information about the snapshot that has the highest score in the category.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The results of pornographic content review. Valid values:</para>
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
                            /// <para>The score of the snapshot in the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
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
                            /// <para>3005</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// <para>The URL of the video snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-****bucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The recommendation for video review results. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The results of terrorist content review.</para>
                    /// </summary>
                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult TerrorismResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult : TeaModel {
                        /// <summary>
                        /// <para>The average score of the snapshots of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// <para>The categories of terrorist content review results and the number of video snapshots in each category.</para>
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
                            /// <para>The results of terrorist content review. Valid values:</para>
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
                            /// <para>terrorism</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

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
                        /// <para>The highest score of the snapshot of the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// <para>The recommendation for terrorist content review results. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>block</b></description></item>
                        /// <item><description><b>review</b></description></item>
                        /// <item><description><b>pass</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pass</para>
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// <para>The information about the snapshot that has the highest score in the category.</para>
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList : TeaModel {
                            /// <summary>
                            /// <para>The results of terrorist content review. Valid values:</para>
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
                            /// <para>The score of the snapshot in the category that is indicated by Label. Valid values: <c>[0, 100]</c>. The value is accurate to 10 decimal places. The score is representative of the confidence.</para>
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
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bdbc266af6894*****943a70176d92e9</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe028d09441d*****d1afffb138cd7e</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is returned if the value of Status is fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: The job is successful.</description></item>
            /// <item><description><b>fail</b>: The job failed.</description></item>
            /// <item><description><b>init</b>: The job is being initialized.</description></item>
            /// <item><description><b>Processing</b>: The job is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the job. The value is AIMediaAudit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIMediaAudit</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAA3E96A-02E2-41*****85-08E1D568ED3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
