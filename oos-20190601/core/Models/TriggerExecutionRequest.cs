// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class TriggerExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dswe2-3i0-029</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The message body to be sent to the trigger task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;eventTime&quot;: &quot;20181226T220114.058+0800&quot;, &quot;id&quot;: &quot;9435EAD6-3CF6-4494-8F7A-3A<b><b><b><b>77&quot;,&quot;level&quot;: &quot;INFO&quot;,&quot;name&quot;: &quot;Instance:StateChange&quot;,&quot;product&quot;: &quot;ECS&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;resourceId&quot;: &quot;acs:ecs:cn-hangzhou:169070</b></b></b></b>30:instance/i-bp1ecr<b><b><b><b>5go2go&quot;,&quot;userId&quot;: &quot;169070</b></b></b></b>30&quot;,&quot;ver&quot;: &quot;1.0&quot;,&quot;content&quot;: {&quot;resourceId&quot;: &quot;i-bp1ecr********5go2go&quot;, &quot;resourceType&quot;: &quot;ALIYUN::ECS::Instance&quot;,&quot;state&quot;: &quot;Stopping&quot;} }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the event-, alert-, or timer-triggered execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-sadw3f23rsad</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

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

        /// <summary>
        /// <para>The type of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Event</description></item>
        /// <item><description>Alarm</description></item>
        /// <item><description>Timer</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Event</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
