// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call fails. For more information, see error codes.</para>
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
        public GetAlertRecordAnalysisResultResponseBodyData Data { get; set; }
        public class GetAlertRecordAnalysisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The code of the tracing result. (Deprecated)</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AnalysisCode")]
            [Validation(Required=false)]
            public string AnalysisCode { get; set; }

            /// <summary>
            /// <para>The list of tracing results.</para>
            /// </summary>
            [NameInMap("UniqueTagList")]
            [Validation(Required=false)]
            public List<GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList> UniqueTagList { get; set; }
            public class GetAlertRecordAnalysisResultResponseBodyDataUniqueTagList : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>179deb12f25baac9b1e2909c419bcb1f</para>
                /// </summary>
                [NameInMap("AlarmUniqueInfo")]
                [Validation(Required=false)]
                public string AlarmUniqueInfo { get; set; }

                /// <summary>
                /// <para>The 16-digit AliUid of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1248751055158884</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>The code of the tracing result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_code</para>
                /// </summary>
                [NameInMap("AnalysisCode")]
                [Validation(Required=false)]
                public string AnalysisCode { get; set; }

                /// <summary>
                /// <para>The text of the tracing result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exception_alert</para>
                /// </summary>
                [NameInMap("AnalysisResult")]
                [Validation(Required=false)]
                public string AnalysisResult { get; set; }

                /// <summary>
                /// <para>Indicates whether the result is liked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Liked.</description></item>
                /// <item><description><b>false</b>: Not liked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChooseLike")]
                [Validation(Required=false)]
                public bool? ChooseLike { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110.22.*8.111</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The instance ID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-adadasd-a**</para>
                /// </summary>
                [NameInMap("MachineInstanceId")]
                [Validation(Required=false)]
                public string MachineInstanceId { get; set; }

                /// <summary>
                /// <para>The display mode of the exception event details. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>: plain text</description></item>
                /// <item><description><b>html</b>: rich text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto_breaking</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unique ID of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>390317ce81d28bbbd83c05a90b39cd6c</para>
                /// </summary>
                [NameInMap("UniqueInfo")]
                [Validation(Required=false)]
                public string UniqueInfo { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bb3051ca-c0dd-4da2-91be-ea5c80926132</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99D93ED4-D462-5FC5-8518-9BC1C49C7B6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.                               </description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
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
