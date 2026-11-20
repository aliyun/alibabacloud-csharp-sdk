// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RunAppInstanceCommandRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group, which is used to execute commands in a single delivery group. You can call <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> to obtain the ID. This parameter is required if AppInstanceGroupIds is not specified. Otherwise, a parameter error is returned. This parameter does not take effect if AppInstanceGroupIds is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of delivery group IDs, which is used to issue commands in batches to multiple delivery groups in the same region. The commands are executed on all persistent sessions in each delivery group in the list, and only one command execution ID is returned. A maximum of 100 delivery group IDs are supported, and duplicate IDs are deduplicated. All delivery groups must belong to the same region. Otherwise, InvalidRegion.NotMatch is returned. If any delivery group does not exist, InvalidAppInstanceGroup.NotFound is returned. When this parameter is specified, AppInstanceGroupId and AppInstancePersistentIds do not take effect.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the persistent session, which is used to select a single persistent session in the delivery group specified by AppInstanceGroupId to execute commands. The session must belong to the specified delivery group. Otherwise, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The list of persistent session IDs, which is used to select multiple persistent sessions in the delivery group specified by AppInstanceGroupId to execute commands. A maximum of 100 IDs are supported. This parameter does not take effect when AppInstanceGroupIds is specified, and the commands are executed on all persistent sessions in each delivery group.</para>
        /// </summary>
        [NameInMap("AppInstancePersistentIds")]
        [Validation(Required=false)]
        public List<string> AppInstancePersistentIds { get; set; }

        /// <summary>
        /// <para>The command content, which is the script content executed in the session. It must match the script type specified by RunScriptType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo hello</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The command parameters, which are passed through to the session execution end along with the command content. Whether to pass them and the specific format depend on the command content. You can leave this parameter empty if it is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("CommandParam")]
        [Validation(Required=false)]
        public string CommandParam { get; set; }

        /// <summary>
        /// <para>The command type. Currently, only CloudAssistantCmd (Cloud Assistant command) is supported. Specifying other values returns a parameter error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudAssistantCmd</para>
        /// </summary>
        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        /// <summary>
        /// <para>The command description, which is used to describe the purpose of the issued command for subsequent identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clean up temporary files</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product type. Currently, only WuyingServer (WUYING Workspace) is supported. Specifying other values returns a parameter error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The type of the script to execute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RunBatScript: bat script</description></item>
        /// <item><description>RunPowerShellScript: PowerShell script</description></item>
        /// <item><description>RunShellScript: shell script</description></item>
        /// <item><description>RunAIAgentScript: AI Agent script</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunShellScript</para>
        /// </summary>
        [NameInMap("RunScriptType")]
        [Validation(Required=false)]
        public string RunScriptType { get; set; }

        /// <summary>
        /// <para>The timeout period for command execution, in seconds. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
