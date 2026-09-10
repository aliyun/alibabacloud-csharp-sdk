// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileModerationResultResponseBodyData Data { get; set; }
        public class DescribeFileModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccountId specified by the caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountIdtest123</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The data ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The document type. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc</para>
            /// </summary>
            [NameInMap("DocType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// <para>The list of detection results.</para>
            /// </summary>
            [NameInMap("PageResult")]
            [Validation(Required=false)]
            public List<DescribeFileModerationResultResponseBodyDataPageResult> PageResult { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageResult : TeaModel {
                /// <summary>
                /// <para>The image detection results.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<DescribeFileModerationResultResponseBodyDataPageResultImageResult> ImageResult { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageResultImageResult : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is a title</para>
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
                        /// <para>The risk score.</para>
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
                        /// <para>This is a title</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>nonlabel</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The location information.</para>
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
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The invoked service.</para>
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
                    /// <para>This is a title</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The label descriptions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Suspected advertising content</para>
                    /// </summary>
                    [NameInMap("Descriptions")]
                    [Validation(Required=false)]
                    public string Descriptions { get; set; }

                    /// <summary>
                    /// <para>The label values.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// <para>The text plus version result.</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageResultTextResultResult> Result { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageResultTextResultResult : TeaModel {
                        /// <summary>
                        /// <para>The label confidence score.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90.50</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The custom vocabulary hit results.</para>
                        /// </summary>
                        [NameInMap("CustomizedHit")]
                        [Validation(Required=false)]
                        public List<DescribeFileModerationResultResponseBodyDataPageResultTextResultResultCustomizedHit> CustomizedHit { get; set; }
                        public class DescribeFileModerationResultResponseBodyDataPageResultTextResultResultCustomizedHit : TeaModel {
                            /// <summary>
                            /// <para>The hit keyword.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Popular among everyone</para>
                            /// </summary>
                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public string KeyWords { get; set; }

                            /// <summary>
                            /// <para>The vocabulary name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TestVocabulary22</para>
                            /// </summary>
                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        /// <summary>
                        /// <para>The description corresponding to the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pornography</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The text label in page results.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Political sensitivity</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The risk level.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("RiskLevel")]
                        [Validation(Required=false)]
                        public string RiskLevel { get; set; }

                        /// <summary>
                        /// <para>The positions of the violation words.</para>
                        /// </summary>
                        [NameInMap("RiskPositions")]
                        [Validation(Required=false)]
                        public List<DescribeFileModerationResultResponseBodyDataPageResultTextResultResultRiskPositions> RiskPositions { get; set; }
                        public class DescribeFileModerationResultResponseBodyDataPageResultTextResultResultRiskPositions : TeaModel {
                            /// <summary>
                            /// <para>The end position.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>21</para>
                            /// </summary>
                            [NameInMap("EndPos")]
                            [Validation(Required=false)]
                            public long? EndPos { get; set; }

                            /// <summary>
                            /// <para>The violation word.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Visit pornographic website</para>
                            /// </summary>
                            [NameInMap("RiskWord")]
                            [Validation(Required=false)]
                            public string RiskWord { get; set; }

                            /// <summary>
                            /// <para>The start position.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>17</para>
                            /// </summary>
                            [NameInMap("StartPos")]
                            [Validation(Required=false)]
                            public long? StartPos { get; set; }

                        }

                        /// <summary>
                        /// <para>The hit violation words.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Popular among everyone</para>
                        /// </summary>
                        [NameInMap("RiskWords")]
                        [Validation(Required=false)]
                        public string RiskWords { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The hit risk details.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("RiskTips")]
                    [Validation(Required=false)]
                    public string RiskTips { get; set; }

                    /// <summary>
                    /// <para>The hit risk keywords.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("RiskWords")]
                    [Validation(Required=false)]
                    public string RiskWords { get; set; }

                    /// <summary>
                    /// <para>The service.</para>
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
                    /// <para>blah blah</para>
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
                /// <para>The URL where the text content is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.txt">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.txt</a></para>
                /// </summary>
                [NameInMap("TextUrl")]
                [Validation(Required=false)]
                public string TextUrl { get; set; }

            }

            /// <summary>
            /// <para>The summary information.</para>
            /// </summary>
            [NameInMap("PageSummary")]
            [Validation(Required=false)]
            public DescribeFileModerationResultResponseBodyDataPageSummary PageSummary { get; set; }
            public class DescribeFileModerationResultResponseBodyDataPageSummary : TeaModel {
                /// <summary>
                /// <para>The image summary information.</para>
                /// </summary>
                [NameInMap("ImageSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary ImageSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummary : TeaModel {
                    /// <summary>
                    /// <para>The image labels.</para>
                    /// </summary>
                    [NameInMap("ImageLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels> ImageLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryImageSummaryImageLabels : TeaModel {
                        /// <summary>
                        /// <para>The label description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contraband</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The number of times the label appears.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LabelSum")]
                        [Validation(Required=false)]
                        public int? LabelSum { get; set; }

                    }

                    /// <summary>
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The total number of pages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageSum")]
                [Validation(Required=false)]
                public int? PageSum { get; set; }

                /// <summary>
                /// <para>The document forgery detection risk summary.</para>
                /// </summary>
                [NameInMap("RiskSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummary RiskSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummary : TeaModel {
                    /// <summary>
                    /// <para>The extended information.</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExt Ext { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExt : TeaModel {
                        /// <summary>
                        /// <para>The details of AI-generated or synthetic content detection.</para>
                        /// </summary>
                        [NameInMap("AigcData")]
                        [Validation(Required=false)]
                        public DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExtAigcData AigcData { get; set; }
                        public class DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExtAigcData : TeaModel {
                            /// <summary>
                            /// <para>The implicit label information of AI-generated or synthetic content.</para>
                            /// </summary>
                            [NameInMap("AIGC")]
                            [Validation(Required=false)]
                            public DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExtAigcDataAIGC AIGC { get; set; }
                            public class DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryExtAigcDataAIGC : TeaModel {
                                /// <summary>
                                /// <para>The content producer code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00119144030008867405X210001</para>
                                /// </summary>
                                [NameInMap("ContentProducer")]
                                [Validation(Required=false)]
                                public string ContentProducer { get; set; }

                                /// <summary>
                                /// <para>The content propagator code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00119144030008867405X220001</para>
                                /// </summary>
                                [NameInMap("ContentPropagator")]
                                [Validation(Required=false)]
                                public string ContentPropagator { get; set; }

                                /// <summary>
                                /// <para>The content attribute declared by the implicit label.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AI-generated or synthetic content</para>
                                /// </summary>
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>The content production ID.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>tos-cn-i-tb4s082cfz/ad88d9b125694f57b2c72235e5c42af1</para>
                                /// </summary>
                                [NameInMap("ProduceID")]
                                [Validation(Required=false)]
                                public string ProduceID { get; set; }

                                /// <summary>
                                /// <para>The content propagation ID.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>tos-cn-i-tb4s082cfz/ad88d9b125694f57b2c72235e5c42af1</para>
                                /// </summary>
                                [NameInMap("PropagateID")]
                                [Validation(Required=false)]
                                public string PropagateID { get; set; }

                                /// <summary>
                                /// <para>Reserved field 1.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>None</para>
                                /// </summary>
                                [NameInMap("ReservedCode1")]
                                [Validation(Required=false)]
                                public string ReservedCode1 { get; set; }

                                /// <summary>
                                /// <para>Reserved field 2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>None</para>
                                /// </summary>
                                [NameInMap("ReservedCode2")]
                                [Validation(Required=false)]
                                public string ReservedCode2 { get; set; }

                            }

                            /// <summary>
                            /// <para>The comprehensive analysis report for forgery detection by the large language model.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <h3>Comprehensive Report for Users</h3>
                            /// <h4>Quick Image Overview</h4>
                            /// <list type="bullet">
                            /// <item><description><b>Image Subject</b>: A scanned document titled &quot;Letter of Authorization&quot;, containing the names of the authorizing and authorized companies and red official seals</description></item>
                            /// </list>
                            /// </summary>
                            [NameInMap("Explain")]
                            [Validation(Required=false)]
                            public string Explain { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The list of matched forgery detection risk labels.</para>
                    /// </summary>
                    [NameInMap("RiskLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryRiskLabels> RiskLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryRiskSummaryRiskLabels : TeaModel {
                        /// <summary>
                        /// <para>The confidence score of the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>95.96</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <para>The description of the risk label in Chinese.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>疑似AI生成合成内容</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The risk label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tamper_aigc</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The overall risk level of the document, which is the highest level among all matched labels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                }

                /// <summary>
                /// <para>The text summary information.</para>
                /// </summary>
                [NameInMap("TextSummary")]
                [Validation(Required=false)]
                public DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary TextSummary { get; set; }
                public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummary : TeaModel {
                    /// <summary>
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    /// <summary>
                    /// <para>The text labels.</para>
                    /// </summary>
                    [NameInMap("TextLabels")]
                    [Validation(Required=false)]
                    public List<DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels> TextLabels { get; set; }
                    public class DescribeFileModerationResultResponseBodyDataPageSummaryTextSummaryTextLabels : TeaModel {
                        /// <summary>
                        /// <para>The label descriptions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>No risk detected</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contraband</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The number of times the label appears.</para>
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
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The URL for downloading the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
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
