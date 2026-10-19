// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTaskInfoRequest : TeaModel {
        /// <summary>
        /// <para>The parameters related to the action, in JSON format.
        /// If <b>TaskAction</b> is set to <b>modifySwitchTime</b>, the ActionParams value is <c>{&quot;recoverMode&quot;: &quot;xxx&quot;, &quot;recoverTime&quot;: &quot;xxx&quot;}</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>recoverMode</b> specifies the task recovery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>imePoint</b>: Execute at a specified point in time.</description></item>
        /// <item><description><b>immediate</b>: Execute immediately.</description></item>
        /// <item><description><b>maintainTime</b>: Execute during the O&amp;M window.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>recoverTime</b> specifies the point in time, in UTC+0, in the yyyy-MM-ddTHH:mm:ssZ format. This parameter is required when <b>recoverMode</b> is set to <b>timePoint</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;recoverMode&quot;:&quot;immediate&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
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
        /// <para>The name of the current execution step. You can call <a href="https://help.aliyun.com/document_detail/2400077.html">DescribeHistoryTasks</a> to query the current execution step of a specified node ID. A common value is <b>do_pause</b>, which indicates waiting for the preset time to execute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>do_pause</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>The operation name. Currently, the valid value is <b>modifySwitchTime</b>, which indicates modifying the switchover time or recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modifySwitchTime</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// <para>The node ID. To specify multiple IDs, separate them with commas (,). You can specify up to 30 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0mq3kfhn8i1nlt****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
