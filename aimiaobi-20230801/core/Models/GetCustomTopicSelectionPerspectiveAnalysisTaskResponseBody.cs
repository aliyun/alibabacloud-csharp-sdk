// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("CustomViewPointsResult")]
            [Validation(Required=false)]
            public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult CustomViewPointsResult { get; set; }
            public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult : TeaModel {
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints : TeaModel {
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热点主题事件</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FAILED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
