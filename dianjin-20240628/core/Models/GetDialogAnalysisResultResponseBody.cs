// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Processing time in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDialogAnalysisResultResponseBodyData Data { get; set; }
        public class GetDialogAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of session analysis results</para>
            /// </summary>
            [NameInMap("dialogAnalysisRespList")]
            [Validation(Required=false)]
            public List<GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespList> DialogAnalysisRespList { get; set; }
            public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespList : TeaModel {
                /// <summary>
                /// <para>Session analysis result</para>
                /// </summary>
                [NameInMap("analysisResp")]
                [Validation(Required=false)]
                public GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisResp AnalysisResp { get; set; }
                public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisResp : TeaModel {
                    /// <summary>
                    /// <para>Session execution plan</para>
                    /// 
                    /// <b>Example:</b>
                    /// <ol>
                    /// <item><description>客服应再次确认客户的疑问是否已解决，特别是关于额度的具体数额。\n2. 如果客户仍有疑问，提供客服热线电话，建议客户直接拨打以获取更详细的帮助。\n3. 提醒客户检查短信中的链接，以便快速查看和操作。\n4. 记录此次通话中客户表现出的任何不适或不便，确保后续跟进时更加体贴。\n5. 发送一条包含操作指南的短信，确保客户能够轻松找到并使用服务。\n6. 结束通话前，再次感谢客户的支持，并表达希望客户早日康复的愿望。</description></item>
                    /// </ol>
                    /// </summary>
                    [NameInMap("dialogExecPlan")]
                    [Validation(Required=false)]
                    public string DialogExecPlan { get; set; }

                    /// <summary>
                    /// <para>List of session labels</para>
                    /// </summary>
                    [NameInMap("dialogLabels")]
                    [Validation(Required=false)]
                    public List<GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels> DialogLabels { get; set; }
                    public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels : TeaModel {
                        /// <summary>
                        /// <para>Label name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>额度不足</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Label value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Session open analysis</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;dialogues&quot;: [
                    ///         {
                    ///             &quot;round&quot;: 1,
                    ///             &quot;result&quot;: [
                    ///                 {
                    ///                     &quot;key&quot;: &quot;对话主题&quot;,
                    ///                     &quot;value&quot;: &quot;XX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户反应&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户反应分析&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客服话术&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;本轮客服话术修改建议&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 }
                    ///             ]
                    ///         },
                    ///         {
                    ///             &quot;round&quot;: 2,
                    ///             &quot;result&quot;: [
                    ///                 {
                    ///                     &quot;key&quot;: &quot;对话主题&quot;,
                    ///                     &quot;value&quot;: &quot;XX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户反应&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户反应分析&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客服话术&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;本轮客服话术修改建议&quot;,
                    ///                     &quot;value&quot;: &quot;XXX&quot;
                    ///                 }
                    ///             ]
                    ///         }
                    ///     ],
                    ///   &quot;dialogOpenAnalysisStr&quot;:&quot;第一轮对话：对话主题-xx##客户反应-xx##客户反应分析-xx##客服话术-xx##本轮客服话术修改建议-xx
                    /// 第二轮对话：对话主题-xx##客户反应-xx##客户反应分析-xx##客服话术-xx##本轮客服话术修改建议-xx&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("dialogOpenAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogOpenAnalysis { get; set; }

                    /// <summary>
                    /// <para>Session process analysis</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;dialogues&quot;: [
                    ///         {
                    ///             &quot;round&quot;: 1,
                    ///             &quot;result&quot;: [
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客服&quot;,
                    ///                     &quot;value&quot;: &quot;客服回应标签&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户&quot;,
                    ///                     &quot;value&quot;: &quot;客户回应态度标签&quot;
                    ///                 }
                    ///             ]
                    ///         },
                    ///         {
                    ///             &quot;round&quot;: 2,
                    ///             &quot;result&quot;: [
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客服&quot;,
                    ///                     &quot;value&quot;: &quot;客服回应标签&quot;
                    ///                 },
                    ///                 {
                    ///                     &quot;key&quot;: &quot;客户&quot;,
                    ///                     &quot;value&quot;: &quot;客户回应态度标签&quot;
                    ///                 }
                    ///             ]
                    ///         }
                    ///     ],
                    /// &quot;dialogProcessAnalysisStr&quot;:&quot;第一轮对话：客服-客服回应标签，客户-客户回应态度标签
                    /// 第二轮对话：客服-客服回应标签，客户-客户回应态度标签&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("dialogProcessAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogProcessAnalysis { get; set; }

                    /// <summary>
                    /// <para>Session SOP</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>产品介绍</para>
                    /// </summary>
                    [NameInMap("dialogSop")]
                    [Validation(Required=false)]
                    public string DialogSop { get; set; }

                    /// <summary>
                    /// <para>Session summary</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>是否有资金需求：不确定，客户未明确表示有无资金需求。\n- 是否有意向：不确定，客户未明确表达意向。\n- 是否可营销：不可营销，客户对客服的多次询问未表现出兴趣，且对话中提到因不适希望减少联系。\n- 待满足需求：客户希望了解具体的预审额度信息。</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("dialogSummary")]
                    [Validation(Required=false)]
                    public string DialogSummary { get; set; }

                }

                /// <summary>
                /// <para>Session creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-24 11:54:34</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>OSS URL for the session analysis result. The URL expires in one hour.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx.oss-cn-beijing.aliyuncs.com/dialog-analysis/2024-12-30/2/1826661605606129665">https://xxx.oss-cn-beijing.aliyuncs.com/dialog-analysis/2024-12-30/2/1826661605606129665</a></para>
                /// </summary>
                [NameInMap("ossUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <para>Session ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>183764873624</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>Task execution status for session analysis.</para>
                /// <list type="bullet">
                /// <item><description><para>init means the task has not started</para>
                /// </description></item>
                /// <item><description><para>pending means the task is queued</para>
                /// </description></item>
                /// <item><description><para>running means the task is in progress</para>
                /// </description></item>
                /// <item><description><para>error means the task failed</para>
                /// </description></item>
                /// <item><description><para>success means the task completed successfully</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>88A006F0-B565-53BA-B38A-DBDF9D0B2935</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
