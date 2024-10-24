// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;description&quot;:&quot;这是一个新的pytorchjob模板&quot;}</para>
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;ProfileReport&quot;: { &quot;Name&quot;: &quot;CPUBottleneck&quot;,&quot;Triggered&quot;: 10,&quot;Violations&quot;: 2,&quot;Details&quot;: &quot;{}&quot;}, &quot;LowCPU&quot;: { &quot;Name&quot;: &quot;CPUBottleneck&quot;,&quot;Triggered&quot;: 10,&quot;Violations&quot;: 2,&quot;Details&quot;: &quot;{}&quot;}}</para>
        /// </summary>
        [NameInMap("DebuggerJobIssues")]
        [Validation(Required=false)]
        public string DebuggerJobIssues { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Running&quot;: 1, &quot;Failed&quot;: 1, &quot;Succeeded&quot;: 2}</para>
        /// </summary>
        [NameInMap("DebuggerJobStatus")]
        [Validation(Required=false)]
        public string DebuggerJobStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx.com/debug/report/download/new_xxxx.html">http://xxx.com/debug/report/download/new_xxxx.html</a></para>
        /// </summary>
        [NameInMap("DebuggerReportURL")]
        [Validation(Required=false)]
        public string DebuggerReportURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc debugger test</para>
        /// </summary>
        [NameInMap("JobDisplayName")]
        [Validation(Required=false)]
        public string JobDisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12344556</para>
        /// </summary>
        [NameInMap("JobUserId")]
        [Validation(Required=false)]
        public string JobUserId { get; set; }

    }

}
