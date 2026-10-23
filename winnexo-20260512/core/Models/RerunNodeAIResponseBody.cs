// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RerunNodeAIResponseBody : TeaModel {
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
        /// <para>The physical instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_example</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The key of the node scheduled for rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query.amount</para>
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the rerun request is accepted. A value of true indicates that the rerun is accepted, but does not mean that the AI has completed the task. Failures are returned through the Code and Message fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("rerunAccepted")]
        [Validation(Required=false)]
        public bool? RerunAccepted { get; set; }

        /// <summary>
        /// <para>The state version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

    }

}
