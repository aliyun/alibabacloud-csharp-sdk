// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListArtifactBuildTaskLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log entries of the artifact build task.</para>
        /// </summary>
        [NameInMap("BuildTaskLogs")]
        [Validation(Required=false)]
        public List<ListArtifactBuildTaskLogResponseBodyBuildTaskLogs> BuildTaskLogs { get; set; }
        public class ListArtifactBuildTaskLogResponseBodyBuildTaskLogs : TeaModel {
            /// <summary>
            /// <para>The row number of the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LineNumber")]
            [Validation(Required=false)]
            public int? LineNumber { get; set; }

            /// <summary>
            /// <para>The log data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Start Build</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: successful</description></item>
        /// <item><description><c>false</c>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4C7DD0C-C9D6-437A-A7EE-121EFD70D002</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of log entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
