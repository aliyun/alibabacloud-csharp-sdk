// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApproveProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The approval action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Agree: approves the request.</para>
        /// </description></item>
        /// <item><description><para>Deny: rejects the request.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agree</para>
        /// </summary>
        [NameInMap("ApprovalAction")]
        [Validation(Required=false)]
        public string ApprovalAction { get; set; }

        /// <summary>
        /// <para>The approval comment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approve authorization</para>
        /// </summary>
        [NameInMap("ApprovalComment")]
        [Validation(Required=false)]
        public string ApprovalComment { get; set; }

        /// <summary>
        /// <para>The idempotency token. We recommend that you use a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The modified authorization expiration time. The value is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782541464000</para>
        /// </summary>
        [NameInMap("NewExpiration")]
        [Validation(Required=false)]
        public long? NewExpiration { get; set; }

        /// <summary>
        /// <para>The flow instance ID. Both new and legacy Security Center approval orders are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>332066440109224007</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
