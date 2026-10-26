// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The parameters related to the action. You can add extensions based on your business requirements. When the taskAction parameter is set to modifySwitchTime, set the ActionParams parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <para>The recoverMode parameter specifies the task recovery pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: Executes the task at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: Executes the task immediately.</description></item>
        /// </list>
        /// <para>The recoverTime parameter specifies the recovery time. The time must be in UTC+0 and in the yyyy-MM-ddTHH:mm:ssZ format. When the recoverMode parameter is set to timePoint, the recoverTime parameter is required.</para>
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
        /// <item><description><b>undo</b>: Does not process the event.<remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
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
        /// <para>The event IDs. You can call the DescribeEvents operation to query the event IDs. Separate multiple event IDs with commas (,). You can specify up to 20 event IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5422964</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
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
