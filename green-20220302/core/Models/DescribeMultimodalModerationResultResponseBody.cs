// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeMultimodalModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code, which matches the HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMultimodalModerationResultResponseBodyData Data { get; set; }
        public class DescribeMultimodalModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Comment moderation results.</para>
            /// </summary>
            [NameInMap("CommentDatas")]
            [Validation(Required=false)]
            public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatas> CommentDatas { get; set; }
            public class DescribeMultimodalModerationResultResponseBodyDataCommentDatas : TeaModel {
                /// <summary>
                /// <para>Moderation results.</para>
                /// </summary>
                [NameInMap("CommentDatas")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatas> CommentDatas { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatas : TeaModel {
                    /// <summary>
                    /// <para>Comment moderation results.</para>
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatasResults> Results { get; set; }
                    public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasCommentDatasResults : TeaModel {
                        /// <summary>
                        /// <para>Description of the Label field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>疑似含有烟火类内容元素</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Risk label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>violent_explosion</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                }

                /// <summary>
                /// <para>Comment moderation results.</para>
                /// </summary>
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataCommentDatasResults> Results { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataCommentDatasResults : TeaModel {
                    /// <summary>
                    /// <para>Description of the Label field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似含有烟火类内容元素</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Risk label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            /// <summary>
            /// <para>The dataId value passed in the API request. This field is absent if no dataId was provided in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data1234</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Main post moderation results.</para>
            /// </summary>
            [NameInMap("MainData")]
            [Validation(Required=false)]
            public DescribeMultimodalModerationResultResponseBodyDataMainData MainData { get; set; }
            public class DescribeMultimodalModerationResultResponseBodyDataMainData : TeaModel {
                /// <summary>
                /// <para>Main post moderation results.</para>
                /// </summary>
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DescribeMultimodalModerationResultResponseBodyDataMainDataResults> Results { get; set; }
                public class DescribeMultimodalModerationResultResponseBodyDataMainDataResults : TeaModel {
                    /// <summary>
                    /// <para>Description of the Label field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似含有烟火类内容元素</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Risk label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            /// <summary>
            /// <para>The ReqId field returned by the asynchronous moderation API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <para>Risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The response message for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
