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
            /// The job result.
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
                    /// The category of the review result.
                    /// 
                    /// *   **normal**: normal content
                    /// *   **spam**: spam
                    /// *   **ad**: ads
                    /// *   **politics**: political content
                    /// *   **terrorism**: terrorist content
                    /// *   **abuse**: abuse
                    /// *   **porn**: pornographic content.
                    /// *   **flood**: excessive junk content
                    /// *   **contraband**: prohibited content
                    /// *   **meaningless**: meaningless content
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The review scenario. The value is **antispam**.
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
                    /// *   **block**
                    /// *   **review**
                    /// *   **pass**
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
                    /// The categories of the image review results. Multiple values are separated by commas (,). Valid values:
                    /// 
                    /// *   **porn**: pornographic content
                    /// *   **terrorism**: terrorist or politically sensitive content
                    /// *   **ad**: ad violation
                    /// *   **live**: undesirable scene
                    /// *   **logo**: logo
                    /// *   **normal**: normal content
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
                        /// *   **normal**: normal content
                        /// *   **ad**: ads
                        /// *   **politics**: political content
                        /// *   **porn**: pornographic content
                        /// *   **abuse**: verbal abuse
                        /// *   **terrorism**: terrorist content
                        /// *   **contraband**: prohibited content
                        /// *   **spam**: spam content
                        /// *   **npx**: illegal ad
                        /// *   **qrcode**: QR code
                        /// *   **programCode**: mini program code
                        /// 
                        /// Valid values if scene is **live**:
                        /// 
                        /// *   **normal**: normal content
                        /// *   **meaningless**: meaningless content, such as a black or white screen.
                        /// *   **PIP**: picture-in-picture
                        /// *   **smoking**: smoking
                        /// *   **drivelive**: live broadcasting in a running vehicle
                        /// 
                        /// Valid values if scene is **logo**:
                        /// 
                        /// *   **normal**: normal content
                        /// *   **TV**: controlled TV station logo
                        /// *   **trademark**: trademark
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The review scenario. Valid values:
                        /// 
                        /// *   **porn**: pornographic content
                        /// *   **terrorism**: terrorist or politically sensitive content
                        /// *   **ad**: ad violation
                        /// *   **live**: undesirable scene
                        /// *   **logo**: logo
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
                        /// *   **block**
                        /// *   **review**
                        /// *   **pass**
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                    }

                    /// <summary>
                    /// The recommendation for review results. Valid values:
                    /// 
                    /// *   **block**
                    /// *   **review**
                    /// *   **pass**
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
                /// The category of the review result. Multiple values are separated by commas (,). Valid values:
                /// 
                /// *   **porn**: pornographic content
                /// *   **terrorism**: terrorist or politically sensitive content
                /// *   **ad**: ad violation
                /// *   **live**: undesirable scene
                /// *   **logo**: logo
                /// *   **audio**: audio anti-spam
                /// *   **normal**: normal content
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
                /// The text moderation results.
                /// </summary>
                [NameInMap("TextResult")]
                [Validation(Required=false)]
                public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult> TextResult { get; set; }
                public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataTextResult : TeaModel {
                    /// <summary>
                    /// The text content.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// *   **spam**: spam content
                    /// *   **ad**: ads
                    /// *   **abuse**: abuse
                    /// *   **flood**: excessive junk content
                    /// *   **contraband**: prohibited content
                    /// *   **meaningless**: meaningless content
                    /// *   **normal**: normal content
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The review scenario. The value is **antispam**.
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
                    /// *   **block**
                    /// *   **review**
                    /// *   **pass**
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
                        /// The number of snapshots of each category in the review result.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of video snapshots.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The categories of the ad review results. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **ad**: other ads
                            /// *   **politics**: political content
                            /// *   **porn**: pornographic content
                            /// *   **abuse**: abuse
                            /// *   **terrorism**: terrorist content
                            /// *   **contraband**: prohibited content
                            /// *   **spam**: spam content
                            /// *   **npx**: illegal ad
                            /// *   **qrcode**: QR code
                            /// *   **programCode**: mini program code
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The categories of the ad review results. Valid values:
                        /// 
                        /// *   **normal**: normal content
                        /// *   **ad**: other ads
                        /// *   **politics**: political content
                        /// *   **porn**: pornographic content
                        /// *   **abuse**: abuse
                        /// *   **terrorism**: terrorist content
                        /// *   **contraband**: prohibited content
                        /// *   **spam**: spam content
                        /// *   **npx**: illegal ad
                        /// *   **qrcode**: QR code
                        /// *   **programCode**: mini program code
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
                        /// The information about the snapshot that has the highest score in the category.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultAdResultTopList : TeaModel {
                            /// <summary>
                            /// The categories of the ad review results. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **ad**: other ads
                            /// *   **politics**: political content
                            /// *   **porn**: pornographic content
                            /// *   **abuse**: abuse
                            /// *   **terrorism**: terrorist content
                            /// *   **contraband**: prohibited content
                            /// *   **spam**: spam content
                            /// *   **npx**: illegal ad
                            /// *   **qrcode**: QR code
                            /// *   **programCode**: mini program code
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the snapshot in the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The timestamp of the snapshot in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the video snapshot.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// *   **porn**: pornographic content
                    /// *   **terrorism**: terrorist or politically sensitive content
                    /// *   **ad**: ad violation
                    /// *   **live**: undesirable scene
                    /// *   **logo**: logo
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
                        /// The categories of the review results and the number of video snapshots in each category.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of video snapshots.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **meaningless**: meaningless content, such as a black or white screen.
                            /// *   **PIP**: picture-in-picture
                            /// *   **smoking**: smoking
                            /// *   **drivelive**: live broadcasting in a running vehicle
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **normal**: normal content
                        /// *   **meaningless**: meaningless content, such as a black or white screen.
                        /// *   **PIP**: picture-in-picture
                        /// *   **smoking**: smoking
                        /// *   **drivelive**: live broadcasting in a running vehicle
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
                        /// The information about the snapshot that has the highest score in the category.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLiveResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **meaningless**: meaningless content, such as a black or white screen.
                            /// *   **PIP**: picture-in-picture
                            /// *   **smoking**: smoking
                            /// *   **drivelive**: live broadcasting in a running vehicle
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the snapshot in the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The timestamp of the snapshot in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the video snapshot.
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
                        /// The average score of the snapshots in the category indicated by Label.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of the review results and the number of video snapshots in each category.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of video snapshots.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **TV**: controlled TV station logo
                            /// *   **trademark**: trademark
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                        }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// *   **normal**: normal content
                        /// *   **TV**: controlled TV station logo
                        /// *   **trademark**: trademark
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The highest score of the snapshot of the category that is indicated by Label.
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
                        /// The information about the snapshot that has the highest score in the category.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultLogoResultTopList : TeaModel {
                            /// <summary>
                            /// The category of the review result. Valid values:
                            /// 
                            /// *   **normal**: normal content
                            /// *   **TV**: controlled TV station logo
                            /// *   **trademark**: trademark
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the snapshot in the category that is indicated by Label.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The timestamp of the snapshot in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the video snapshot.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The results of pornographic content review.
                    /// </summary>
                    [NameInMap("PornResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult PornResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResult : TeaModel {
                        /// <summary>
                        /// The average score of the snapshots of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The number of snapshots of each category in the review result.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of video snapshots.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The results of pornographic content review. Valid values:
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
                        /// The highest score of the snapshot of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
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
                        /// The information about the snapshot that has the highest score in the category.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultPornResultTopList : TeaModel {
                            /// <summary>
                            /// The results of pornographic content review. Valid values:
                            /// 
                            /// *   **porn**
                            /// *   **sexy**
                            /// *   **normal**
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score of the snapshot in the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The timestamp of the snapshot in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the video snapshot.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                    /// <summary>
                    /// The recommendation for video review results. Valid values:
                    /// 
                    /// *   **block**
                    /// *   **review**
                    /// *   **pass**
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The results of terrorist content review.
                    /// </summary>
                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult TerrorismResult { get; set; }
                    public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResult : TeaModel {
                        /// <summary>
                        /// The average score of the snapshots of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("AverageScore")]
                        [Validation(Required=false)]
                        public string AverageScore { get; set; }

                        /// <summary>
                        /// The categories of terrorist content review results and the number of video snapshots in each category.
                        /// </summary>
                        [NameInMap("CounterList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList> CounterList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultCounterList : TeaModel {
                            /// <summary>
                            /// The number of video snapshots.
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                            /// <summary>
                            /// The results of terrorist content review. Valid values:
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
                        /// The highest score of the snapshot of the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                        /// </summary>
                        [NameInMap("MaxScore")]
                        [Validation(Required=false)]
                        public string MaxScore { get; set; }

                        /// <summary>
                        /// The recommendation for terrorist content review results. Valid values:
                        /// 
                        /// *   **block**
                        /// *   **review**
                        /// *   **pass**
                        /// </summary>
                        [NameInMap("Suggestion")]
                        [Validation(Required=false)]
                        public string Suggestion { get; set; }

                        /// <summary>
                        /// The information about the snapshot that has the highest score in the category.
                        /// </summary>
                        [NameInMap("TopList")]
                        [Validation(Required=false)]
                        public List<GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList> TopList { get; set; }
                        public class GetAIMediaAuditJobResponseBodyMediaAuditJobDataVideoResultTerrorismResultTopList : TeaModel {
                            /// <summary>
                            /// The results of terrorist content review. Valid values:
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
                            /// The score of the snapshot in the category that is indicated by Label. Valid values: `[0, 100]`. The value is accurate to 10 decimal places. The score is representative of the confidence.
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public string Score { get; set; }

                            /// <summary>
                            /// The timestamp of the snapshot in the video. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                            /// <summary>
                            /// The URL of the video snapshot.
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
            /// The type of the job. The value is AIMediaAudit.
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
