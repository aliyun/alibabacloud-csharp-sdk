// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryVideoAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Business status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Video audit result data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryVideoAuditResultResponseBodyData Data { get; set; }
        public class QueryVideoAuditResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Video duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

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
            /// <para>Video frame rate</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.0</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public double? Fps { get; set; }

            /// <summary>
            /// <para>Frames audited</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("FrameAudited")]
            [Validation(Required=false)]
            public int? FrameAudited { get; set; }

            /// <summary>
            /// <para>Video height</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>Image URL list</para>
            /// </summary>
            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<QueryVideoAuditResultResponseBodyDataImageUrls> ImageUrls { get; set; }
            public class QueryVideoAuditResultResponseBodyDataImageUrls : TeaModel {
                /// <summary>
                /// <para>Image ID (Associate with Results[].DataId to get audit result information)</para>
                /// 
                /// <b>Example:</b>
                /// <para>img001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Timestamp (milliseconds)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public double? Timestamp { get; set; }

                /// <summary>
                /// <para>Image URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/image1.jpg">https://example.com/image1.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Audit results list</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryVideoAuditResultResponseBodyDataResults> Results { get; set; }
            public class QueryVideoAuditResultResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Image ID (Associate with ImageUrls[].Id to get image information)</para>
                /// 
                /// <b>Example:</b>
                /// <para>d411ed15e8fc154fd0ef5addabfee04b</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>Request ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>B5D1CF9E-0404-51E3-A28E-A5C7D95B6C71</para>
                /// </summary>
                [NameInMap("ReqId")]
                [Validation(Required=false)]
                public string ReqId { get; set; }

                /// <summary>
                /// <para>Detection results</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<QueryVideoAuditResultResponseBodyDataResultsResult> Result { get; set; }
                public class QueryVideoAuditResultResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <para>From 0 to 100, retained to 2 decimal places. Some labels do not have a confidence score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.5</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>Explanation of the Label field</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Risk label</para>
                    /// <para>The label of the image content review result. For example: nonLabel (no risk detected).</para>
                    /// <para>The label can also be a risk level that is determined by the high-risk and low-risk thresholds that you set. Valid return values are:
                    /// ● high: high risk
                    /// ● medium: medium risk
                    /// ● low: low risk
                    /// ● none: no risk detected</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nonLabel</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>Risk level</para>
                /// <list type="bullet">
                /// <item><description><para>high: High risk</para>
                /// </description></item>
                /// <item><description><para>medium: Medium risk</para>
                /// </description></item>
                /// <item><description><para>low: Low risk</para>
                /// </description></item>
                /// <item><description><para>none: No risk</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>Task status (PENDING: Queued, RUNNING: In progress, SUCCESSED: Successful, FAILED: Failed, CANCELED: Task canceled)</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Reviewed text</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频审核完成</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>Frames to audit</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalFrameAudit")]
            [Validation(Required=false)]
            public int? TotalFrameAudit { get; set; }

            /// <summary>
            /// <para>Total frames</para>
            /// 
            /// <b>Example:</b>
            /// <para>3615</para>
            /// </summary>
            [NameInMap("TotalFrames")]
            [Validation(Required=false)]
            public int? TotalFrames { get; set; }

            /// <summary>
            /// <para>Total shots</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalShots")]
            [Validation(Required=false)]
            public int? TotalShots { get; set; }

            /// <summary>
            /// <para>Video FileKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>video/test.mp4</para>
            /// </summary>
            [NameInMap("VideoFileKey")]
            [Validation(Required=false)]
            public string VideoFileKey { get; set; }

            /// <summary>
            /// <para>Video URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/video.mp4">https://example.com/video.mp4</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            /// <summary>
            /// <para>Video width</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

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
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
