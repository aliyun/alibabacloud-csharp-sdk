// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunDialogAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The time consumed, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RunDialogAnalysisResponseBodyData Data { get; set; }
        public class RunDialogAnalysisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of session analysis results.</para>
            /// </summary>
            [NameInMap("dialogAnalysisRespList")]
            [Validation(Required=false)]
            public List<RunDialogAnalysisResponseBodyDataDialogAnalysisRespList> DialogAnalysisRespList { get; set; }
            public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespList : TeaModel {
                /// <summary>
                /// <para>The result of the session analysis.</para>
                /// </summary>
                [NameInMap("analysisResp")]
                [Validation(Required=false)]
                public RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisResp AnalysisResp { get; set; }
                public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisResp : TeaModel {
                    /// <summary>
                    /// <para>The session execution plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <ol>
                    /// <item><description>核实客户账户信息，确认还款情况。\\n2. 若未收到还款，联系财务部门确认是否到账延迟。\\n3. 若已还款，更新客户记录并致歉。\\n4. 跟进客户，确保问题解决。</description></item>
                    /// </ol>
                    /// </summary>
                    [NameInMap("dialogExecPlan")]
                    [Validation(Required=false)]
                    public string DialogExecPlan { get; set; }

                    /// <summary>
                    /// <para>The list of session labels.</para>
                    /// </summary>
                    [NameInMap("dialogLabels")]
                    [Validation(Required=false)]
                    public List<RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels> DialogLabels { get; set; }
                    public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels : TeaModel {
                        /// <summary>
                        /// <para>The label name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>二级标签</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>协商还款</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The session open analysis.</para>
                    /// </summary>
                    [NameInMap("dialogOpenAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogOpenAnalysis { get; set; }

                    /// <summary>
                    /// <para>The session process analysis.</para>
                    /// </summary>
                    [NameInMap("dialogProcessAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogProcessAnalysis { get; set; }

                    /// <summary>
                    /// <para>The session SOP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>营销</para>
                    /// </summary>
                    [NameInMap("dialogSop")]
                    [Validation(Required=false)]
                    public string DialogSop { get; set; }

                    /// <summary>
                    /// <para>The session summary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>是否有资金需求：否\\n- 是否有意向：否，客户认为自己已经解决，对当前状态表示不解\\n- 是否可营销：否，对话中未表现出对营销信息的兴趣或接受度\\n- 待满足需求：客户希望在三天内解决问题</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("dialogSummary")]
                    [Validation(Required=false)]
                    public string DialogSummary { get; set; }

                }

                /// <summary>
                /// <para>The list of failed nodes.</para>
                /// </summary>
                [NameInMap("failNode")]
                [Validation(Required=false)]
                public List<string> FailNode { get; set; }

                /// <summary>
                /// <para>The time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-24 11:54:34</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1759457905S001vejpvd6vej</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The execution status of the session analysis task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02CD4454-3F2C-57D0-9060-68DEAA1F6993</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
