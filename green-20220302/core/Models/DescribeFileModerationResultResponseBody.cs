// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileModerationResultResponseBodyData Data { get; set; }
        public class DescribeFileModerationResultResponseBodyData : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the moderated object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Optional. The document type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>An array that consists of the moderation results.</para>
            /// </summary>
            [NameInMap("PageResult")]
            [Validation(Required=false)]
            public List<DescribeFileModerationResultResponseBodyDataPageResult> PageResult { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageResult : TeaModel {
                /// <summary>
                /// <para>The image moderation results.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<DescribeFileModerationResultResponseBodyDataPageResultImageResult> ImageResult { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageResultImageResult : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is a title.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label information.</para>
                    /// </summary>
                    [NameInMap("LabelResult")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageResultImageResultLabelResult> LabelResult { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageResultImageResultLabelResult : TeaModel {
                        /// <summary>
                        /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>25.0</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>This is a title.</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The details of the labels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>nonlabel</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The location information</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public DescribeFileModerationResultResponseBodyDataPageResultImageResultLocation Location { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageResultImageResultLocation : TeaModel {
                        /// <summary>
                        /// <para>The H value of the coordinate point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public int? H { get; set; }

                        /// <summary>
                        /// <para>The W value of the coordinate point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>33</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public int? W { get; set; }

                        /// <summary>
                        /// <para>The X value of the coordinate point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        /// <summary>
                        /// <para>The Y value of the coordinate point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>Risk Level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The moderation service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>baselineCheck</para>
                    /// </summary>
                    [NameInMap("Service")]
                    [Validation(Required=false)]
                    public string Service { get; set; }

                }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.jpg">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                /// <summary>
                /// <para>The text moderation results.</para>
                /// </summary>
                [NameInMap("TextResult")]
                [Validation(Required=false)]
                public List<DescribeFileModerationResultResponseBodyDataPageResultTextResult> TextResult { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageResultTextResult : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is a title.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The description of the labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>no risk</para>
                    /// </summary>
                    [NameInMap("Descriptions")]
                    [Validation(Required=false)]
                    public string Descriptions { get; set; }

                    /// <summary>
                    /// <para>The details of the labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// <para>Risk Level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The risk details that are hit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// <para>The risk words that are hit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    /// <summary>
                    /// <para>The moderation service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat_detection</para>
                    /// </summary>
                    [NameInMap("Service")]
                    [Validation(Required=false)]
                    public string Service { get; set; }

                    /// <summary>
                    /// <para>The text content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is a text.</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The text segmentation information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[0,999]</para>
                    /// </summary>
                    [NameInMap("TextSegment")]
                    [Validation(Required=false)]
                    public string TextSegment { get; set; }

                }

                /// <summary>
                /// <para>The text URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.txt">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.txt</a></para>
                /// </summary>
                [NameInMap("TextUrl")]
                [Validation(Required=false)]
                public string TextUrl { get; set; }

            }

            /// <summary>
            /// <para>Summary of results</para>
            /// </summary>
            [NameInMap("PageSummary")]
            [Validation(Required=false)]
            public DescribeFileModerationResultResponseBodyDataPageSummary PageSummary { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageSummary : TeaModel {
                /// <summary>
                /// <para>Image Results Summary</para>
                /// </summary>
                [NameInMap("ImageSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary ImageSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary : TeaModel {
                    /// <summary>
                    /// <para>Image Label</para>
                    /// </summary>
                    [NameInMap("ImageLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels> ImageLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels : TeaModel {
                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The details of the labels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contraband</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The number of times that the label is matched.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LabelSum")]
                        [Validation(Required=false)]
                        public int? LabelSum { get; set; }

                    }

                    /// <summary>
                    /// <para>Risk Level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>Number of pages</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageSum")]
                [Validation(Required=false)]
                public int? PageSum { get; set; }

                /// <summary>
                /// <para>Text Results Summary</para>
                /// </summary>
                [NameInMap("TextSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary TextSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary : TeaModel {
                    /// <summary>
                    /// <para>Risk Level</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>Text Label</para>
                    /// </summary>
                    [NameInMap("TextLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels> TextLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels : TeaModel {
                        /// <summary>
                        /// <para>The description of the labels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>no risk</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The details of the labels.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contraband</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The number of times that the label is matched.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LabelSum")]
                        [Validation(Required=false)]
                        public int? LabelSum { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>Risk Level</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The URL of the moderated object.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
