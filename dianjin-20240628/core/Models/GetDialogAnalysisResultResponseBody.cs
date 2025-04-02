// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetDialogAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDialogAnalysisResultResponseBodyData Data { get; set; }
        public class GetDialogAnalysisResultResponseBodyData : TeaModel {
            [NameInMap("dialogAnalysisRespList")]
            [Validation(Required=false)]
            public List<GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespList> DialogAnalysisRespList { get; set; }
            public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespList : TeaModel {
                [NameInMap("analysisResp")]
                [Validation(Required=false)]
                public GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisResp AnalysisResp { get; set; }
                public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisResp : TeaModel {
                    [NameInMap("dialogExecPlan")]
                    [Validation(Required=false)]
                    public string DialogExecPlan { get; set; }

                    [NameInMap("dialogLabels")]
                    [Validation(Required=false)]
                    public List<GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels> DialogLabels { get; set; }
                    public class GetDialogAnalysisResultResponseBodyDataDialogAnalysisRespListAnalysisRespDialogLabels : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-04-24 11:54:34</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx.oss-cn-beijing.aliyuncs.com/dialog-analysis/2024-12-30/2/1826661605606129665">https://xxx.oss-cn-beijing.aliyuncs.com/dialog-analysis/2024-12-30/2/1826661605606129665</a></para>
                /// </summary>
                [NameInMap("ossUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>183764873624</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
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
        /// <para>88A006F0-B565-53BA-B38A-DBDF9D0B2935</para>
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
