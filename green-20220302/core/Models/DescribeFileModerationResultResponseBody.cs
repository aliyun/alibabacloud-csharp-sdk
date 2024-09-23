// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileModerationResultResponseBodyData Data { get; set; }
        public class DescribeFileModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the moderated object.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// Optional. The document type.
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// An array that consists of the moderation results.
            /// </summary>
            [NameInMap("PageResult")]
            [Validation(Required=false)]
            public List<DescribeFileModerationResultResponseBodyDataPageResult> PageResult { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageResult : TeaModel {
                /// <summary>
                /// The image moderation results.
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<DescribeFileModerationResultResponseBodyDataPageResultImageResult> ImageResult { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageResultImageResult : TeaModel {
                    /// <summary>
                    /// The description.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The label information.
                    /// </summary>
                    [NameInMap("LabelResult")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageResultImageResultLabelResult> LabelResult { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageResultImageResultLabelResult : TeaModel {
                        /// <summary>
                        /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// The description.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The details of the labels.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// The location information
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public DescribeFileModerationResultResponseBodyDataPageResultImageResultLocation Location { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageResultImageResultLocation : TeaModel {
                        /// <summary>
                        /// The H value of the coordinate point.
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// The W value of the coordinate point.
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// The X value of the coordinate point.
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// The Y value of the coordinate point.
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// Risk Level
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// The moderation service.
                    /// </summary>
                    [NameInMap("Service")]
                    [Validation(Required=false)]
                    public string Service { get; set; }

                }

                /// <summary>
                /// The image URL.
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// The page number.
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                /// <summary>
                /// The text moderation results.
                /// </summary>
                [NameInMap("TextResult")]
                [Validation(Required=false)]
                public List<DescribeFileModerationResultResponseBodyDataPageResultTextResult> TextResult { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageResultTextResult : TeaModel {
                    /// <summary>
                    /// The description.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The details of the labels.
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// Risk Level
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// The risk details that are hit.
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// The risk words that are hit.
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    /// <summary>
                    /// The moderation service.
                    /// </summary>
                    [NameInMap("Service")]
                    [Validation(Required=false)]
                    public string Service { get; set; }

                    /// <summary>
                    /// The text content.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// The text segmentation information.
                    /// </summary>
                    [NameInMap("TextSegment")]
                    [Validation(Required=false)]
                    public string TextSegment { get; set; }

                }

                /// <summary>
                /// The text URL.
                /// </summary>
                [NameInMap("TextUrl")]
                [Validation(Required=false)]
                public string TextUrl { get; set; }

            }

            /// <summary>
            /// Summary of results
            /// </summary>
            [NameInMap("PageSummary")]
            [Validation(Required=false)]
            public DescribeFileModerationResultResponseBodyDataPageSummary PageSummary { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageSummary : TeaModel {
                /// <summary>
                /// Image Results Summary
                /// </summary>
                [NameInMap("ImageSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary ImageSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary : TeaModel {
                    /// <summary>
                    /// Image Label
                    /// </summary>
                    [NameInMap("ImageLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels> ImageLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels : TeaModel {
                        /// <summary>
                        /// The description.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The details of the labels.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The number of times that the label is matched.
                        /// </summary>
                        [NameInMap("LabelSum")]
                        [Validation(Required=false)]
                        public int? LabelSum { get; set; }

                    }

                    /// <summary>
                    /// Risk Level
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                }

                /// <summary>
                /// Number of pages
                /// </summary>
                [NameInMap("PageSum")]
                [Validation(Required=false)]
                public int? PageSum { get; set; }

                /// <summary>
                /// Text Results Summary
                /// </summary>
                [NameInMap("TextSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary TextSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary : TeaModel {
                    /// <summary>
                    /// Risk Level
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// Text Label
                    /// </summary>
                    [NameInMap("TextLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels> TextLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels : TeaModel {
                        /// <summary>
                        /// The details of the labels.
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The number of times that the label is matched.
                        /// </summary>
                        [NameInMap("LabelSum")]
                        [Validation(Required=false)]
                        public int? LabelSum { get; set; }

                    }

                }

            }

            /// <summary>
            /// Risk Level
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The URL of the moderated object.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
