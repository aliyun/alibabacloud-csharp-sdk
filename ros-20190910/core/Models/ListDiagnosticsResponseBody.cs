// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListDiagnosticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The items that are diagnosed.</para>
        /// </summary>
        [NameInMap("Diagnostics")]
        [Validation(Required=false)]
        public List<ListDiagnosticsResponseBodyDiagnostics> Diagnostics { get; set; }
        public class ListDiagnosticsResponseBodyDiagnostics : TeaModel {
            /// <summary>
            /// <para>The time when the diagnostic report was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01T02:23:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The keyword in the diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>047D84D9-D3EB-5DA8-87F1-9A7DD5598A5D</para>
            /// </summary>
            [NameInMap("DiagnosticKey")]
            [Validation(Required=false)]
            public string DiagnosticKey { get; set; }

            /// <summary>
            /// <para>The product that is diagnosed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ros</para>
            /// </summary>
            [NameInMap("DiagnosticProduct")]
            [Validation(Required=false)]
            public string DiagnosticProduct { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-2963bfbcac834f1a****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The diagnosis status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned. The value 200 indicates that the request was successful.</para>
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
        /// <para>You are not authorized to complete this action.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f01****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1983D1C4-88EA-5D7D-90AB-467D01867A5D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
