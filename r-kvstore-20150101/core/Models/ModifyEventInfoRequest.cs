// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-formatted parameters related to the action. Set this parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c> if the <b>TaskAction</b> parameter is set to <b>modifySwitchTime</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>recoverMode</b>: specifies the restoration mode for the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: performs the task at the specified point in time.</description></item>
        /// <item><description><b>immediate</b>: performs the task immediately.</description></item>
        /// <item><description><b>maintainTime</b>: performs the task within the maintenance window.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>recoverTime</b>: specifies the point in time for restoration. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. This parameter is required if the <b>recoverMode</b> parameter is set to <b>timePoint</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverTime&quot;:&quot;2023-04-17T14:02:35Z&quot;,&quot;recoverMode&quot;:&quot;timePoint&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The event handling action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>archive</b></description></item>
        /// <item><description><b>undo</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>archive</para>
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// <para>The event IDs. Separate multiple event IDs with commas (,). You can specify up to 20 event IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5422964</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
