// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The parameters related to the action in JSON format.
        /// When <b>TaskAction</b> is set to <b>modifySwitchTime</b>, set this parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <list type="bullet">
        /// <item><description><b>recoverMode</b>: the task recovery mode. Valid values:<list type="bullet">
        /// <item><description><b>imePoint</b>: executes the task at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: executes the task immediately.</description></item>
        /// <item><description><b>maintainTime</b>: executes the task during the O&amp;M window.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>recoverTime</b>: the specified point in time in UTC. The format is yyyy-MM-ddTHH:mm:ssZ. This parameter is required when <b>recoverMode</b> is set to <b>timePoint</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverTime&quot;:&quot;2023-04-17T14:02:35Z&quot;,&quot;recoverMode&quot;:&quot;timePoint&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The action to process the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>archive</b>: Archives the event.</description></item>
        /// <item><description><b>undo</b>: Does not process the event.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>archive</para>
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// <para>The event IDs. Separate multiple IDs with commas. A maximum of 20 IDs are supported.</para>
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
