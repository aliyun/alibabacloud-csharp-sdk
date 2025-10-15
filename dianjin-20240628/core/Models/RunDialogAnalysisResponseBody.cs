// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunDialogAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunDialogAnalysisResponseBodyData Data { get; set; }
        public class RunDialogAnalysisResponseBodyData : TeaModel {
            [NameInMap("dialogAnalysisRespList")]
            [Validation(Required=false)]
            public List<RunDialogAnalysisResponseBodyDataDialogAnalysisRespList> DialogAnalysisRespList { get; set; }
            public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespList : TeaModel {
                [NameInMap("analysisResp")]
                [Validation(Required=false)]
                public RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisResp AnalysisResp { get; set; }
                public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisResp : TeaModel {
                    [NameInMap("dialogExecPlan")]
                    [Validation(Required=false)]
                    public string DialogExecPlan { get; set; }

                    [NameInMap("dialogLabels")]
                    [Validation(Required=false)]
                    public List<RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels> DialogLabels { get; set; }
                    public class RunDialogAnalysisResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("dialogOpenAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogOpenAnalysis { get; set; }

                    [NameInMap("dialogProcessAnalysis")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> DialogProcessAnalysis { get; set; }

                    [NameInMap("dialogSop")]
                    [Validation(Required=false)]
                    public string DialogSop { get; set; }

                    [NameInMap("dialogSummary")]
                    [Validation(Required=false)]
                    public string DialogSummary { get; set; }

                }

                [NameInMap("failNode")]
                [Validation(Required=false)]
                public List<string> FailNode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-04-24 11:54:34</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1759457905S001vejpvd6vej</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>02CD4454-3F2C-57D0-9060-68DEAA1F6993</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
