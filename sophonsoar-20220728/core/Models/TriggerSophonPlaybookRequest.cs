// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the command that you want to trigger.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSophonCommands~~">DescribeSophonCommands</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>waf_process_command</para>
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// <para>The input parameters for triggering the command or playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;param1&quot;: &quot;xx.xx.xx.xx&quot;,
        ///     &quot;param2&quot;: &quot;7d&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        /// <summary>
        /// <para>The custom ID of the task. If you do not specify this parameter when triggering a playbook, a random ID is generated. This ID is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f916b93e-e814-459f-9662-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>command</b>: Triggers a command task.</description></item>
        /// <item><description><b>playbook</b>: Triggers a playbook task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>playbook</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f916b93e-e814-459f-9662-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
