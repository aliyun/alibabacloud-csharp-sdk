// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData Data { get; set; }
        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Result of the custom topic selection analysis task</para>
            /// </summary>
            [NameInMap("CustomViewPointsResult")]
            [Validation(Required=false)]
            public GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult CustomViewPointsResult { get; set; }
            public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResult : TeaModel {
                /// <summary>
                /// <para>List of custom viewpoints. By default, the system generates one viewpoint based on the prompt input.</para>
                /// </summary>
                [NameInMap("Attitudes")]
                [Validation(Required=false)]
                public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes> Attitudes { get; set; }
                public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudes : TeaModel {
                    /// <summary>
                    /// <para>Current viewpoint</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点</para>
                    /// </summary>
                    [NameInMap("Attitude")]
                    [Validation(Required=false)]
                    public string Attitude { get; set; }

                    /// <summary>
                    /// <para>Viewpoint type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>观点类型</para>
                    /// </summary>
                    [NameInMap("AttitudeType")]
                    [Validation(Required=false)]
                    public string AttitudeType { get; set; }

                    /// <summary>
                    /// <para>Proportion of the current viewpoint</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>当前观点占比</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                    /// <summary>
                    /// <para>List of topic selection perspectives</para>
                    /// </summary>
                    [NameInMap("ViewPoints")]
                    [Validation(Required=false)]
                    public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints> ViewPoints { get; set; }
                    public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPoints : TeaModel {
                        /// <summary>
                        /// <para>Outline</para>
                        /// </summary>
                        [NameInMap("Outlines")]
                        [Validation(Required=false)]
                        public List<GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines> Outlines { get; set; }
                        public class GetCustomTopicSelectionPerspectiveAnalysisTaskResponseBodyDataCustomViewPointsResultAttitudesViewPointsOutlines : TeaModel {
                            /// <summary>
                            /// <para>Outline</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲</para>
                            /// </summary>
                            [NameInMap("Outline")]
                            [Validation(Required=false)]
                            public string Outline { get; set; }

                            /// <summary>
                            /// <para>Outline summary</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>大纲摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                        }

                        /// <summary>
                        /// <para>Generated perspective</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>视角</para>
                        /// </summary>
                        [NameInMap("Point")]
                        [Validation(Required=false)]
                        public string Point { get; set; }

                        /// <summary>
                        /// <para>Summary</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>摘要</para>
                        /// </summary>
                        [NameInMap("Summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                    }

                }

                /// <summary>
                /// <para>Hot topic event</para>
                /// 
                /// <b>Example:</b>
                /// <para>热点主题事件</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Task status (PENDING: pending, RUNNING: running, SUCCESSED: succeeded, SUSPENDED: suspended, FAILED: failed, CANCELED: canceled)</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
