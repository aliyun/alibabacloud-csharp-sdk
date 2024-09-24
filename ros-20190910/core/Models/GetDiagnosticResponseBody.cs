// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetDiagnosticResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The keyword in the diagnosis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0938F60C-A2CA-5A2E-9983-03EB1E6D7AE2</para>
        /// </summary>
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        /// <summary>
        /// <para>The name of the diagnostic item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("DiagnosticProduct")]
        [Validation(Required=false)]
        public string DiagnosticProduct { get; set; }

        /// <summary>
        /// <para>The diagnosis result.</para>
        /// </summary>
        [NameInMap("DiagnosticResult")]
        [Validation(Required=false)]
        public GetDiagnosticResponseBodyDiagnosticResult DiagnosticResult { get; set; }
        public class GetDiagnosticResponseBodyDiagnosticResult : TeaModel {
            /// <summary>
            /// <para>The resources that failed to be diagnosed.</para>
            /// </summary>
            [NameInMap("FailedResources")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailedResources { get; set; }

            /// <summary>
            /// <para>The information about Resource Orchestration Service (ROS) calling.</para>
            /// </summary>
            [NameInMap("RosActionMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> RosActionMessages { get; set; }

            /// <summary>
            /// <para>The stack information.</para>
            /// </summary>
            [NameInMap("StackMessages")]
            [Validation(Required=false)]
            public Dictionary<string, object> StackMessages { get; set; }

        }

        /// <summary>
        /// <para>The time when the diagnosis was performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-27T03:32:03Z</para>
        /// </summary>
        [NameInMap("DiagnosticTime")]
        [Validation(Required=false)]
        public string DiagnosticTime { get; set; }

        /// <summary>
        /// <para>The HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter ReportId is invalid, Can not find diagnostic report dr-5f6135782f104b0f****.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The suggestion for the diagnosis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;RosActionMessages\&quot;: {\&quot;Reason\&quot;: \&quot;Fail to delete stack (fc966920-450a-456b-983c-deeaec8e****), as deletion protection is enabled.\&quot;, \&quot;Recommend\&quot;: \&quot;\&quot;}}</para>
        /// </summary>
        [NameInMap("Recommends")]
        [Validation(Required=false)]
        public Dictionary<string, object> Recommends { get; set; }

        /// <summary>
        /// <para>The ID of the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-cc80afc48c8741e9****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96A24844-9603-5E79-BDF4-EFD412FC5D4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The diagnosis status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The diagnosis is in progress.</description></item>
        /// <item><description>Complete: The diagnosis is complete.</description></item>
        /// <item><description>Failed: The diagnosis failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason for the diagnosis status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
