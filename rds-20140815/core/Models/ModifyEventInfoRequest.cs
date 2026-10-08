// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The action-related parameters, which can be an extension based on business requirements. When taskAction is set to modifySwitchTime, set ActionParams to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <para>recoverMode specifies the task recovery pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: Executes at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: Executes immediately.</description></item>
        /// </list>
        /// <para>recoverTime specifies the recovery time in UTC+0. Format: yyyy-MM-ddTHH:mm:ssZ. This parameter is required when recoverMode is set to timePoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverTime&quot;:&quot;2023-04-17T14:02:35Z&quot;,&quot;recoverMode&quot;:&quot;timePoint&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The event action. Valid values:</para>
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
        /// <para>The event ID. You can call the DescribeEvents operation to query event IDs. To query multiple events, separate the event IDs with commas (,). A maximum of 20 event IDs are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5422964</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
