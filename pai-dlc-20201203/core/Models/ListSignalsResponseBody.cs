// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListSignalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-...</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of signal records for the job. Each element has the same structure as the response of GetSignal.</para>
        /// </summary>
        [NameInMap("Signals")]
        [Validation(Required=false)]
        public List<ListSignalsResponseBodySignals> Signals { get; set; }
        public class ListSignalsResponseBodySignals : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T14:07:38+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-30T14:07:38+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The message returned with the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>signal delivered to 1 pods</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The list of pod names.</para>
            /// </summary>
            [NameInMap("PodNames")]
            [Validation(Required=false)]
            public List<string> PodNames { get; set; }

            /// <summary>
            /// <para>The reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Completed</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The list of role types.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>The delivery scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pods</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The signal code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIGUSR1</para>
            /// </summary>
            [NameInMap("Signal")]
            [Validation(Required=false)]
            public string Signal { get; set; }

            /// <summary>
            /// <para>The signal ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oper*********</para>
            /// </summary>
            [NameInMap("SignalId")]
            [Validation(Required=false)]
            public string SignalId { get; set; }

            /// <summary>
            /// <para>The signal status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stopped</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
