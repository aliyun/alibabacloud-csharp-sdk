// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJobIssue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;: &quot;CPUBottleneck&quot;,  &quot;Triggered&quot;: 10, &quot;Violations&quot;: 2,  &quot;Details&quot;: &quot;{}&quot;}</para>
        /// </summary>
        [NameInMap("DebuggerJobIssue")]
        [Validation(Required=false)]
        public string DebuggerJobIssue_ { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>de-826ca1bcfba30</para>
        /// </summary>
        [NameInMap("JobDebuggerIssueId")]
        [Validation(Required=false)]
        public string JobDebuggerIssueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1002300</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GPU利用率低</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProfileReport</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
