// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetAgentMJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentMJobInfoResponseBodyData Data { get; set; }
        public class GetAgentMJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the task processing result.</para>
            /// </summary>
            [NameInMap("AgentMDetailResponse")]
            [Validation(Required=false)]
            public GetAgentMJobInfoResponseBodyDataAgentMDetailResponse AgentMDetailResponse { get; set; }
            public class GetAgentMJobInfoResponseBodyDataAgentMDetailResponse : TeaModel {
                /// <summary>
                /// <para>The execution summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This quality inspection analyzed a total of 120 conversations..</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The list of result files. Each item contains complete file fields.</para>
                /// </summary>
                [NameInMap("SummaryUrls")]
                [Validation(Required=false)]
                public List<GetAgentMJobInfoResponseBodyDataAgentMDetailResponseSummaryUrls> SummaryUrls { get; set; }
                public class GetAgentMJobInfoResponseBodyDataAgentMDetailResponseSummaryUrls : TeaModel {
                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SatisfactionAnalysis.xlsx</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xlsx</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>The file URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>http://******.oss-cn-hangzhou.aliyuncs.com/uploadTransfer/17****dline-express.zip</para>
                    /// </summary>
                    [NameInMap("OssUrl")]
                    [Validation(Required=false)]
                    public string OssUrl { get; set; }

                }

            }

            /// <summary>
            /// <para>The end time of the scan range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 20:00:00</para>
            /// </summary>
            [NameInMap("DataEndTime")]
            [Validation(Required=false)]
            public string DataEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the scan range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 19:00:00</para>
            /// </summary>
            [NameInMap("DataStartTime")]
            [Validation(Required=false)]
            public string DataStartTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The error message returned when an error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>queing: queuing.</description></item>
            /// <item><description>readyAnalysis: pending analysis.</description></item>
            /// <item><description>running: running.</description></item>
            /// <item><description>error: failed.</description></item>
            /// <item><description>finish: completed.</description></item>
            /// <item><description>fileUploadUser: user-specified file upload completed.</description></item>
            /// <item><description>fileUploadSystem: system-generated file upload completed.</description></item>
            /// <item><description>expired: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The actual end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 20:00:00</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public string TaskEndTime { get; set; }

            /// <summary>
            /// <para>The scheduled task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A6BEC8D-9A5B-4BE5-8432-4F635E***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The actual start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 19:00:00</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false/null: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
