// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The action-related parameters, which can be extended as needed. When taskAction is set to modifySwitchTime, set ActionParams to <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <para>recoverMode specifies the task recovery pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timePoint</b>: Execute at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: Execute immediately.</description></item>
        /// </list>
        /// <para>recoverTime specifies the recovery time in UTC+0. Format: yyyy-MM-ddTHH:mm:ssZ. This parameter is required when recoverMode is set to timePoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverTime&quot;:&quot;2023-04-12T18:30:00Z&quot;,&quot;recoverMode&quot;:&quot;timePoint&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> operation to query available region IDs.</para>
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
        public string ResourceOwnerAccount { get; set; }

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
        /// <para>The task action. Set the value to modifySwitchTime, which indicates modifying the switchover time or recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifySwitchTime</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the DescribeTasks operation to obtain the task ID.</para>
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
