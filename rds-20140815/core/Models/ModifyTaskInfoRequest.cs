// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The action-related parameters. You can add action-related parameters based on your business requirements. If you set the TaskAction parameter to modifySwitchTime, you must set this parameter to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <para>The recoverMode field specifies the task restoration mode. valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: The task is executed at a specified point in time.</description></item>
        /// <item><description><b>Immediate</b>: The task is executed immediately.</description></item>
        /// <item><description><b>maintainTime</b>: The task is executed based on the O\&amp;M time.</description></item>
        /// </list>
        /// <para>The recoverTime field specifies restoration time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. If you set the recoverMode field to timePoint, you must also specify the recoverTime field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;recoverTime\&quot;:\&quot;2023-04-12T18:30:00Z\&quot;,\&quot;recoverMode\&quot;:\&quot;timePoint\&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public long? ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The name of the execution step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha_switch</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>The task action. Set the value to modifySwitchTime. The value specifies that you want to change the switching time or restoration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImportImage</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the DescribeTasks operation to query task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-83br18hloum8u3948s</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
