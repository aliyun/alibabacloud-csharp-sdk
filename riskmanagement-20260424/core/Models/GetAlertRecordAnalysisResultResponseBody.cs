// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlertRecordAnalysisResultResponseBodyData Data { get; set; }
        public class GetAlertRecordAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AnalysisCode")]
            [Validation(Required=false)]
            public string AnalysisCode { get; set; }

            [NameInMap("UniqueTagList")]
            [Validation(Required=false)]
            public List<GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList> UniqueTagList { get; set; }
            public class GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>179deb12f25baac9b1e2909c419bcb1f</para>
                /// </summary>
                [NameInMap("AlarmUniqueInfo")]
                [Validation(Required=false)]
                public string AlarmUniqueInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1248751055158884</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_code</para>
                /// </summary>
                [NameInMap("AnalysisCode")]
                [Validation(Required=false)]
                public string AnalysisCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exception_alert</para>
                /// </summary>
                [NameInMap("AnalysisResult")]
                [Validation(Required=false)]
                public string AnalysisResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChooseLike")]
                [Validation(Required=false)]
                public bool? ChooseLike { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110.22.*8.111</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-adadasd-a**</para>
                /// </summary>
                [NameInMap("MachineInstanceId")]
                [Validation(Required=false)]
                public string MachineInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>auto_breaking</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>390317ce81d28bbbd83c05a90b39cd6c</para>
                /// </summary>
                [NameInMap("UniqueInfo")]
                [Validation(Required=false)]
                public string UniqueInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bb3051ca-c0dd-4da2-91be-ea5c80926132</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99D93ED4-D462-5FC5-8518-9BC1C49C7B6C</para>
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
