// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryVideoAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>业务处理结果状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>视频审校的详细结果</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryVideoAuditResultResponseBodyData Data { get; set; }
        public class QueryVideoAuditResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>视频总时长（秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.5</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>任务执行失败时的错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>视频帧率（FPS）</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.0</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public double? Fps { get; set; }

            /// <summary>
            /// <para>已经完成审核的帧数</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("FrameAudited")]
            [Validation(Required=false)]
            public int? FrameAudited { get; set; }

            /// <summary>
            /// <para>视频高度（像素）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>抽取的图片URL列表</para>
            /// </summary>
            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<QueryVideoAuditResultResponseBodyDataImageUrls> ImageUrls { get; set; }
            public class QueryVideoAuditResultResponseBodyDataImageUrls : TeaModel {
                /// <summary>
                /// <para>图片ID，与AliyunImageAuditResult中的dataId对应</para>
                /// 
                /// <b>Example:</b>
                /// <para>img001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public double? Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/image1.jpg">https://example.com/image1.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>图片审核结果详情</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryVideoAuditResultResponseBodyDataResults> Results { get; set; }
            public class QueryVideoAuditResultResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>对应图片的ID，与ImageUrl中的id字段对应</para>
                /// 
                /// <b>Example:</b>
                /// <para>d411ed15e8fc154fd0ef5addabfee04b</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>审核请求ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>B5D1CF9E-0404-51E3-A28E-A5C7D95B6C71</para>
                /// </summary>
                [NameInMap("ReqId")]
                [Validation(Required=false)]
                public string ReqId { get; set; }

                /// <summary>
                /// <para>图片检测的风险标签、置信分等参数结果</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<QueryVideoAuditResultResponseBodyDataResultsResult> Result { get; set; }
                public class QueryVideoAuditResultResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <para>0到100分，保留到小数点后2位，部分标签无置信分</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.5</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>Label字段的解释说明</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>图片内容检测运算后返回的标签，如：nonLabel（未检测出风险）</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nonLabel</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>风险等级：high(高风险)、medium(中风险)、low(低风险)、none(未检测到风险)</para>
                /// 
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>任务状态：PENDING(待执行)、RUNNING(执行中)、SUCCESSED(成功)、FAILED(失败)、CANCELED(取消)</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>视频审校的文本结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>视频审核完成</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>需要审核的视频帧总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalFrameAudit")]
            [Validation(Required=false)]
            public int? TotalFrameAudit { get; set; }

            /// <summary>
            /// <para>视频总帧数</para>
            /// 
            /// <b>Example:</b>
            /// <para>3615</para>
            /// </summary>
            [NameInMap("TotalFrames")]
            [Validation(Required=false)]
            public int? TotalFrames { get; set; }

            /// <summary>
            /// <para>检测到的视频分镜总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalShots")]
            [Validation(Required=false)]
            public int? TotalShots { get; set; }

            /// <summary>
            /// <para>被审核的视频文件Key</para>
            /// 
            /// <b>Example:</b>
            /// <para>video/test.mp4</para>
            /// </summary>
            [NameInMap("VideoFileKey")]
            [Validation(Required=false)]
            public string VideoFileKey { get; set; }

            /// <summary>
            /// <para>被审核的视频URL地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/video.mp4">https://example.com/video.mp4</a></para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

            /// <summary>
            /// <para>视频宽度（像素）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>HTTP响应状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>业务处理结果描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>本次API请求的唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>请求是否处理成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
