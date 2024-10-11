// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The review results.</para>
        /// </summary>
        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            /// <summary>
            /// <para>The content that violates the regulations. Separate multiple values with commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b></description></item>
            /// <item><description><b>image-cover</b></description></item>
            /// <item><description><b>text-title</b></description></item>
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
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                /// <summary>
                /// <para>The category of the review result.</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>spam</b></description></item>
                /// <item><description><b>ad</b></description></item>
                /// <item><description><b>politics</b></description></item>
                /// <item><description><b>terrorism</b></description></item>
                /// <item><description><b>abuse</b></description></item>
                /// <item><description><b>porn</b></description></item>
                /// <item><description><b>flood</b></description></item>
                /// <item><description><b>contraband</b></description></item>
                /// <item><description><b>meaningless</b></description></item>
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
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Separate multiple values with commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>porn</b></description></item>
                /// <item><description><b>terrorism</b></description></item>
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
                /// <para>Details of image review results.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult> Result { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult : TeaModel {
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
                    /// <item><description><b>terrorism</b></description></item>
                    /// <item><description><b>porn</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The score of the image of the category that is indicated by Label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00000</para>
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
                /// <para>The type of the image. The value is <b>cover</b>.</para>
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
            /// <para>The category of the review result. Separate multiple values with commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>porn</b></description></item>
            /// <item><description><b>terrorism</b></description></item>
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
            /// <para>The results of text review.</para>
            /// </summary>
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                /// <summary>
                /// <para>The text content for review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hot line 123****</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>spam</b></description></item>
                /// <item><description><b>ad</b></description></item>
                /// <item><description><b>abuse</b></description></item>
                /// <item><description><b>flood</b></description></item>
                /// <item><description><b>contraband</b></description></item>
                /// <item><description><b>meaningless</b></description></item>
                /// <item><description><b>normal</b></description></item>
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
                /// <para>The score of the image of the category that is indicated by Label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00000</para>
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
            public GetMediaAuditResultResponseBodyMediaAuditResultVideoResult VideoResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResult : TeaModel {
                /// <summary>
                /// <para>The results of ad review.</para>
                /// </summary>
                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
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
                    /// <para>The statistics about tag frames.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ad</b></description></item>
                        /// <item><description><b>normal</b></description></item>
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
                    /// <para>The category of the review result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ad</b></description></item>
                    /// <item><description><b>normal</b></description></item>
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
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the image with the highest score of the category that is indicated by Label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the review result. </para>
                        /// <list type="bullet">
                        /// <item><description><b>ad</b></description></item>
                        /// <item><description><b>normal</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the image of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public string Timestamp { get; set; }

                        /// <summary>
                        /// <para>The URL of the image.</para>
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
                /// <para>The category of the review result. Separate multiple values with commas (,). Valid values: </para>
                /// <list type="bullet">
                /// <item><description><b>porn</b></description></item>
                /// <item><description><b>terrorism</b></description></item>
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
                /// <para>The results of undesired content review.</para>
                /// </summary>
                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
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
                    /// <para>The statistics about tag frames.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of frames.</para>
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
                        /// <item><description><b>live</b>: The content contains undesirable scenes.</description></item>
                        /// <item><description><b>normal</b>: normal content.</description></item>
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
                    /// <item><description><b>live</b>: The content contains undesirable scenes.</description></item>
                    /// <item><description><b>normal</b>: normal content.</description></item>
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
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the image with the highest score of the category that is indicated by Label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>live</b>: The content contains undesirable scenes.</description></item>
                        /// <item><description><b>normal</b>: normal content.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>normal</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the image of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public string Timestamp { get; set; }

                        /// <summary>
                        /// <para>The URL of the image.</para>
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
                /// <para>The results of logo review.</para>
                /// </summary>
                [NameInMap("LogoResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult LogoResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult : TeaModel {
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
                    /// <para>The statistics about tag frames.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>The category of the review result. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>logo</b></description></item>
                        /// <item><description><b>normal</b></description></item>
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
                    /// <item><description><b>logo</b></description></item>
                    /// <item><description><b>normal</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>logo</para>
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
                    /// <item><description><b>block</b></description></item>
                    /// <item><description><b>review</b></description></item>
                    /// <item><description><b>pass</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the image with the highest score of the category that is indicated by Label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList : TeaModel {
                        /// <summary>
                        /// <para>The category of the review result.</para>
                        /// <list type="bullet">
                        /// <item><description><b>logo</b></description></item>
                        /// <item><description><b>normal</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>logo</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The score of the image of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// <para>The position in the video. Unit: milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public string Timestamp { get; set; }

                        /// <summary>
                        /// <para>The URL of the image.</para>
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
                /// <para>The results of pornographic content review.</para>
                /// </summary>
                [NameInMap("PornResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult PornResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult : TeaModel {
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
                    /// <para>The statistics about tag frames.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

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
                    /// <para>The highest review score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    /// <summary>
                    /// <para>The recommendation for review results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>The information about the image with the highest score of the category that is indicated by Label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList : TeaModel {
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
                        /// <para>The score of the image of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.0000</para>
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

                        /// <summary>
                        /// <para>The URL of the image.</para>
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
                /// <para>The results of terrorist content review.</para>
                /// </summary>
                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
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
                    /// <para>The statistics about tag frames.</para>
                    /// </summary>
                    [NameInMap("CounterList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        /// <summary>
                        /// <para>The number of frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

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
                        /// <para>outfit</para>
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
                    /// <para>The information about the image with the highest score of the category that is indicated by Label.</para>
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList : TeaModel {
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
                        /// <para>The score of the image of the category that is indicated by Label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.000</para>
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

                        /// <summary>
                        /// <para>The URL of the image.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB7D7232-1AB2-40FE-B8D5-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
