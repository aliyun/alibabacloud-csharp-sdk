// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for the action, in JSON format. For example: <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>recoverMode</b>: The recovery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>timePoint</b>: Executes the task at the time specified by <c>recoverTime</c>.</para>
        /// </description></item>
        /// <item><description><para><b>immediate</b>: Executes the task immediately.</para>
        /// </description></item>
        /// <item><description><para><b>maintainTime</b>: Executes the task during the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>recoverTime</b>: The time to execute the task. This parameter is required when <b>recoverMode</b> is set to <b>timePoint</b>. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
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
        /// <para>The action to perform on the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>archive</b>: Archives the event.</para>
        /// </description></item>
        /// <item><description><para><b>undo</b>: Cancels processing for the event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>archive</para>
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// <para>The ID of the event. You can specify up to 20 event IDs. Separate multiple IDs with commas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5422964</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
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
