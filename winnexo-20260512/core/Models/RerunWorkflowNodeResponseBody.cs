// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RerunWorkflowNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node keys affected by this rerun, which the caller can use to refresh data. This list is always included in a successful response and may be omitted in an error response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;query.amount&quot;]</para>
        /// </summary>
        [NameInMap("affectedNodeKeys")]
        [Validation(Required=false)]
        public List<string> AffectedNodeKeys { get; set; }

        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current physical plan ID after the rerun. Rerunning a fixed planning node may generate a new plan. Use this value for subsequent queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_new</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current plan revision number after the rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>The current workflow run ID. This value remains unchanged when a fixed node generates a new revision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run_20261105_01</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The workflow state version after the rerun is accepted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

    }

}
