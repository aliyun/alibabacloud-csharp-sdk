// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIMediaAuditJobResponseBody : TeaModel {
        /// <summary>
        /// The information about the intelligent review job.
        /// </summary>
        [NameInMap("MediaAuditJob")]
        [Validation(Required=false)]
        public GetAIMediaAuditJobResponseBodyMediaAuditJob MediaAuditJob { get; set; }
        public class GetAIMediaAuditJobResponseBodyMediaAuditJob : TeaModel {
            /// <summary>
            /// The error code. This parameter is returned if the value of Status is fail.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The time when the job is complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// The time when the job started to run. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The job result data.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetAIMediaAuditJobResponseBodyMediaAuditJobData Data { get; set; }
            public class GetAIMediaAuditJobResponseBodyMediaAuditJobData : TeaModel {
                /// <summary>
                /// The content that violates the regulations. Separate multiple values with commas (,). Valid values:
                /// 
                /// *   **video**: the video.
                /// *   **image-cover**: the cover.
                /// *   **text-title**: the title.
                /// </summary>
                [NameInMap("AbnormalModules")]
                [Validation(Required=false)]
                public string AbnormalModules { get; set; }

                /// <summary>
                /// The results of audio review.
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult> AudioResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataAudioResult : TeaModel {
                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// *   **normal**
                    /// *   **spam**
                    /// *   **ad**
                    /// *   **politics**
                    /// *   **terrorism**
                    /// *   **abuse**
                    /// *   **porn**
                    /// *   **flood**: spam posts
                    /// *   **contraband**
                    /// *   **meaningless**
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The review scenario. Valid value: **antispam**.
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The score.
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// The recommendation for review results. Valid values:
                    /// 
                    /// *   **block**: The content violates the regulations.
                    /// *   **review**: The content may violate the regulations.
                    /// *   **pass**: The content passes the review.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The results of image review.
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult> ImageResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResult : TeaModel {
                    /// <summary>
                    /// The category of the review result. Separate multiple values with commas (,). Valid values:
                    /// 
                    /// *   **porn**
                    /// *   **terrorism**
                    /// *   **ad**
                    /// *   **live**: undesirable scenes
                    /// *   **logo**
                    /// *   **audio**: audio anti-spam
                    /// *   **normal**
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// Details of image review results.
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult> Result { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataImageResultResult : TeaModel {
                        /// <summary>
                        /// The category of the review result.
                        /// 
                        /// Valid values if scene is **porn**:
                        /// 
                        /// *   **porn**
                        /// *   **sexy**
                        /// *   **normal**
                        /// 
                        /// Valid values if scene is **terrorism**:
                        /// 
                        /// *   **normal**
                        /// *   **bloody**
                        /// *   **explosion**
                        /// *   **outfit**
                        /// *   **logo**
                        /// *   **weapon**
                        /// *   **politics**
                        /// *   **violence**
                        /// *   **crowd**
                        /// *   **parade**
                        /// *   **carcrash**
                        /// *   **flag**
                        /// *   **location**
                        /// *   **others**
                        /// 
                        /// Valid values if scene is **ad**:
                        /// 
                        /// *   **normal**
                        /// *   **ad**
                        /// *   **politics**
                        /// *   **porn**
                        /// *   **abuse**
                        /// *   **terrorism**
                        /// *   **contraband**
                        /// *   **spam**
                        /// *   **npx**: illegal ad
                        /// *   **qrcode**: QR code
                        /// *   **programCode**
                        /// 
                        /// Valid values if scene is **live**:
                        /// 
                        /// *   **normal**
                        /// *   **meaningless**
                        /// *   **PIP**
                        /// *   **smoking**
                        /// *   **drivelive**
                        /// 
                        /// Valid values if scene is **logo**:
                        /// 
                        /// *   **normal**
                        /// *   **TV**
                        /// *   **trademark**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The review scenario. Valid values:
                        /// 
                        /// *   **porn**
                        /// *   **terrorism**
                        /// *   **ad**
                        /// *   **live**: undesirable scenes
                        /// *   **logo**
                        /// </summary>
                        [NameInMap("Scene")]
                        [Validation(Required=false)]
                        public string Scene { get; set; }

                        /// <summary>
                        /// The score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                    }

                    /// <summary>
                    /// The recommendation for review results. Valid values:
                    /// 
                    /// *   **block**: The content violates the regulations.
                    /// *   **review**: The content may violate the regulations.
                    /// *   **pass**: The content passes the review.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The type of the image. Valid value: **cover**.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The URL of the image.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// The category of the review result. Separate multiple values with commas (,). Valid values:
                /// 
                /// *   **porn**
                /// *   **terrorism**
                /// *   **ad**
                /// *   **live**: undesirable scenes
                /// *   **logo**
                /// *   **audio**: audio anti-spam
                /// *   **normal**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The recommendation for review results. Valid values:
                /// 
                /// *   **block**: The content violates the regulations.
                /// *   **review**: The content may violate the regulations.
                /// *   **pass**: The content passes the review.
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// The results of text review.
                /// </summary>
                [NameInMap("TextResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult> TextResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult : TeaModel {
                    /// <summary>
                    /// The text.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// *   **spam**
                    /// *   **ad**
                    /// *   **abuse**
                    /// *   **flood**: spam posts
                    /// *   **contraband**
                    /// *   **meaningless**
                    /// *   **normal**
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The review scenario. Valid value: **antispam**.
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The score is representative of the confidence.
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    /// <summary>
                    /// The recommendation for review results. Valid values:
                    /// 
                    /// *   **block**: The content violates the regulations.
                    /// *   **review**: The content may violate the regulations.
                    /// *   **pass**: The content passes the review.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The type of the text. The value is **title**.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The results of video review.
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult VideoResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResult : TeaModel {
                    /// <summary>
                    /// The results of ad review.
                    /// </summary>
                    [NameInMap("AdResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult AdResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResult : TeaModel {
                        /// <summary>
                        /// The average score of the review results.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The statistics about tag frames.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of images.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **ad**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **ad**
                        /// *   **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest review score.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the image with the highest score of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **ad**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the image of the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The position in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the image.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// *   **ad**
                    /// *   **normal**
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The results of undesired content review.
                    /// </summary>
                    [NameInMap("LiveResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult LiveResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResult : TeaModel {
                        /// <summary>
                        /// The average score of the review results.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of the review results and the number of images.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of images.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **live**: The content contains undesirable scenes.
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **live**: The content contains undesirable scenes.
                        /// *   **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest review score.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the image with the highest score of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **live**: The content contains undesirable scenes.
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the image of the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The position in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the image.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The results of logo review.
                    /// </summary>
                    [NameInMap("LogoResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult LogoResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResult : TeaModel {
                        /// <summary>
                        /// The average score of the images of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of the review results and the number of images.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of images.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **logo**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **logo**
                        /// *   **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest score of the image of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the image with the highest score of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **logo**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the image of the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The position in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the image.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The results of pornography content review.
                    /// </summary>
                    [NameInMap("PornResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult PornResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult : TeaModel {
                        /// <summary>
                        /// The average score of the images of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of the review results and the number of images.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of images.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **porn**
                            /// *   **sexy**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **porn**
                        /// *   **sexy**
                        /// *   **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the image with the highest score of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **porn**
                            /// *   **sexy**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The position in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the image.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The recommendation for review results. Valid values:
                    /// 
                    /// *   **block**: The content violates the regulations.
                    /// *   **review**: The content may violate the regulations.
                    /// *   **pass**: The content passes the review.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The results of terrorism content review.
                    /// </summary>
                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult TerrorismResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult : TeaModel {
                        /// <summary>
                        /// The average score of the images of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of the review results and the number of images.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of images.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **terrorism**
                            /// *   **outfit**
                            /// *   **logo**
                            /// *   **weapon**
                            /// *   **politics**
                            /// *   **others**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **normal**
                        /// *   **bloody**
                        /// *   **explosion**
                        /// *   **outfit**
                        /// *   **logo**
                        /// *   **weapon**
                        /// *   **politics**
                        /// *   **violence**
                        /// *   **crowd**
                        /// *   **parade**
                        /// *   **carcrash**
                        /// *   **flag**
                        /// *   **location**
                        /// *   **others**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for review results. Valid values:
                        /// 
                        /// *   **block**: The content violates the regulations.
                        /// *   **review**: The content may violate the regulations.
                        /// *   **pass**: The content passes the review.
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the image with the highest score of the category that is indicated by Label.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **normal**
                            /// *   **bloody**
                            /// *   **explosion**
                            /// *   **outfit**
                            /// *   **logo**
                            /// *   **weapon**
                            /// *   **politics**
                            /// *   **violence**
                            /// *   **crowd**
                            /// *   **parade**
                            /// *   **carcrash**
                            /// *   **flag**
                            /// *   **location**
                            /// *   **others**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the image of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The position in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the image.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The error message. This parameter is returned if the value of Status is fail.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   **success**: The job is successful.
            /// *   **fail**: The job failed.
            /// *   **init**: The job is being initialized.
            /// *   **Processing**: The job is in progress.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// Only the job type is supported.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
