// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetSignalResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-18T10:02:04+08:00</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-18T10:02:04+08:00</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oper***********</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The status description, which contains a summary for each pod (number of successful deliveries, names of failed or pending pods, etc.).</para>
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
        /// <para>The status reason code, such as <c>Completed</c>, <c>SignalFailed</c>, or <c>StoppedByJobEnded</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Completed</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

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
        /// <para>The list of role objects.</para>
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
        /// <para>The signal.</para>
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
        /// <para>dlc***********</para>
        /// </summary>
        [NameInMap("SignalId")]
        [Validation(Required=false)]
        public string SignalId { get; set; }

        /// <summary>
        /// <para>The signal status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
