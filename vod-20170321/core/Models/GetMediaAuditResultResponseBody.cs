// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultResponseBody : TeaModel {
        /// <summary>
        /// The review results.
        /// </summary>
        [NameInMap("MediaAuditResult")]
        [Validation(Required=false)]
        public GetMediaAuditResultResponseBodyMediaAuditResult MediaAuditResult { get; set; }
        public class GetMediaAuditResultResponseBodyMediaAuditResult : TeaModel {
            /// <summary>
            /// The content that violates the regulations. Separate multiple values with commas (,). Valid values:
            /// 
            /// *   **video**
            /// *   **image-cover**
            /// *   **text-title**
            /// </summary>
            [NameInMap("AbnormalModules")]
            [Validation(Required=false)]
            public string AbnormalModules { get; set; }

            /// <summary>
            /// The results of audio review.
            /// </summary>
            [NameInMap("AudioResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultAudioResult> AudioResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultAudioResult : TeaModel {
                /// <summary>
                /// The category of the review result.
                /// 
                /// *   **normal**
                /// *   **spam**
                /// *   **ad**
                /// *   **politics**
                /// *   **terrorism**
                /// *   **abuse**
                /// *   **porn**
                /// *   **flood**
                /// *   **contraband**
                /// *   **meaningless**
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
            public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResult> ImageResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultImageResult : TeaModel {
                /// <summary>
                /// The category of the review result. Separate multiple values with commas (,). Valid values:
                /// 
                /// *   **porn**
                /// *   **terrorism**
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
                public List<GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult> Result { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultImageResultResult : TeaModel {
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
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The review scenario. Valid values:
                    /// 
                    /// *   **terrorism**
                    /// *   **porn**
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The score of the image of the category that is indicated by Label.
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
                /// The type of the image. The value is **cover**.
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
            /// *   **normal**
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

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
            /// The results of text review.
            /// </summary>
            [NameInMap("TextResult")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultResponseBodyMediaAuditResultTextResult> TextResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultTextResult : TeaModel {
                /// <summary>
                /// The text content for review.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// - **spam**
                /// - **ad**
                /// - **abuse**
                /// - **flood**
                /// - **contraband**
                /// - **meaningless**
                /// - **normal**
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
                /// The score of the image of the category that is indicated by Label.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// The recommendation for review results. Valid values:
                /// 
                /// - **block**
                /// - **review**
                /// - **pass**
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
            public GetMediaAuditResultResponseBodyMediaAuditResultVideoResult VideoResult { get; set; }
            public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResult : TeaModel {
                /// <summary>
                /// The results of ad review.
                /// </summary>
                [NameInMap("AdResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult AdResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResult : TeaModel {
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
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultCounterList : TeaModel {
                        /// <summary>
                        /// The number of frames.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **ad**
                        /// - **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// - **ad**
                    /// - **normal**
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
                    /// - **block**
                    /// - **review**
                    /// - **pass**
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The information about the image with the highest score of the category that is indicated by Label.
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultAdResultTopList : TeaModel {
                        /// <summary>
                        /// The category of the review result. 
                        /// 
                        /// - **ad**
                        /// - **normal**
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
                /// The category of the review result. Separate multiple values with commas (,). Valid values: 
                /// 
                /// - **porn**
                /// - **terrorism**
                /// - **normal**
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The results of undesired content review.
                /// </summary>
                [NameInMap("LiveResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult LiveResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResult : TeaModel {
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
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultCounterList : TeaModel {
                        /// <summary>
                        /// The number of frames.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **live**: The content contains undesirable scenes.
                        /// - **normal**: normal content.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// - **live**: The content contains undesirable scenes.
                    /// - **normal**: normal content.
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
                    /// - **block**
                    /// - **review**
                    /// - **pass**
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The information about the image with the highest score of the category that is indicated by Label.
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLiveResultTopList : TeaModel {
                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **live**: The content contains undesirable scenes.
                        /// - **normal**: normal content.
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
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult LogoResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResult : TeaModel {
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
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultCounterList : TeaModel {
                        /// <summary>
                        /// The number of frames.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **logo**
                        /// - **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// - **logo**
                    /// - **normal**
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
                    /// - **block**
                    /// - **review**
                    /// - **pass**
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The information about the image with the highest score of the category that is indicated by Label.
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultLogoResultTopList : TeaModel {
                        /// <summary>
                        /// The category of the review result.
                        /// 
                        /// - **logo**
                        /// - **normal**
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
                /// The results of pornographic content review.
                /// </summary>
                [NameInMap("PornResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult PornResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResult : TeaModel {
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
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultCounterList : TeaModel {
                        /// <summary>
                        /// The number of frames.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **porn**
                        /// - **sexy**
                        /// - **normal**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// - **porn**
                    /// - **sexy**
                    /// - **normal**
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
                    /// The recommendation for review results.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The information about the image with the highest score of the category that is indicated by Label.
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultPornResultTopList : TeaModel {
                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **porn**
                        /// - **sexy**
                        /// - **normal**
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
                /// The recommendation for review results. Valid values:
                /// 
                /// - **block**
                /// - **review**
                /// - **pass**
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// The results of terrorist content review.
                /// </summary>
                [NameInMap("TerrorismResult")]
                [Validation(Required=false)]
                public GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult TerrorismResult { get; set; }
                public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResult : TeaModel {
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
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList> CounterList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultCounterList : TeaModel {
                        /// <summary>
                        /// The number of frames.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **normal**
                        /// - **bloody**
                        /// - **explosion**
                        /// - **outfit**
                        /// - **logo**
                        /// - **weapon**
                        /// - **politics**
                        /// - **violence**
                        /// - **crowd**
                        /// - **parade**
                        /// - **carcrash**
                        /// - **flag**
                        /// - **location**
                        /// - **others**
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The category of the review result. Valid values:
                    /// 
                    /// - **normal**
                    /// - **bloody**
                    /// - **explosion**
                    /// - **outfit**
                    /// - **logo**
                    /// - **weapon**
                    /// - **politics**
                    /// - **violence**
                    /// - **crowd**
                    /// - **parade**
                    /// - **carcrash**
                    /// - **flag**
                    /// - **location**
                    /// - **others**
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
                    /// - **block**
                    /// - **review**
                    /// - **pass**
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// The information about the image with the highest score of the category that is indicated by Label.
                    /// </summary>
                    [NameInMap("TopList")]
                    [Validation(Required=false)]
                    public List<GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList> TopList { get; set; }
                    public class GetMediaAuditResultResponseBodyMediaAuditResultVideoResultTerrorismResultTopList : TeaModel {
                        /// <summary>
                        /// The category of the review result. Valid values:
                        /// 
                        /// - **normal**
                        /// - **bloody**
                        /// - **explosion**
                        /// - **outfit**
                        /// - **logo**
                        /// - **weapon**
                        /// - **politics**
                        /// - **violence**
                        /// - **crowd**
                        /// - **parade**
                        /// - **carcrash**
                        /// - **flag**
                        /// - **location**
                        /// - **others**
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

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
