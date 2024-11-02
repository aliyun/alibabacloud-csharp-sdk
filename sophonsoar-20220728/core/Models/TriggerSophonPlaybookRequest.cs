// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The name of the command that you want to trigger.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSophonCommands~~">DescribeSophonCommands</a> operation to query the command name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>waf_process_command</para>
        /// </summary>
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        /// <summary>
        /// <para>The input parameters of the command or playbook that you want to trigger.</para>
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
        /// <para>The custom ID. If you do not specify this parameter when the playbook is triggered, a random ID is generated for fault locating and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f916b93e-e814-459f-9662-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>command</b></description></item>
        /// <item><description><b>playbook</b></description></item>
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
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>operation to query the playbook UUID.</para>
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
