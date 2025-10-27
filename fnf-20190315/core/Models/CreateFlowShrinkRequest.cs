// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class CreateFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The definition of the workflow. The definition must comply with the flow definition language (FDL) syntax. Considering compatibility, the system supports two flow definition specifications.</para>
        /// <remarks>
        /// <para> In the preceding flow definition example, Name:my_flow_name is the workflow name, which must be consistent with the input parameter Name</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version:&nbsp;v1.0<br/>type:&nbsp;flow<br/>steps:<br/>&nbsp;-&nbsp;type:&nbsp;pass<br/>&nbsp;name:&nbsp;mypass</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The description of the flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test flow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string EnvironmentShrink { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values: Express and Standard. Considering compatibility, an empty string is equivalent to the Standard execution mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The path of the external storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/path</para>
        /// </summary>
        [NameInMap("ExternalStorageLocation")]
        [Validation(Required=false)]
        public string ExternalStorageLocation { get; set; }

        /// <summary>
        /// <para>The name of the flow. The name is unique within the same region and cannot be modified after the flow is created. Set this parameter based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource name (ARN) of the authorized role on which the execution of the flow relies. During the execution of the flow, CloudFlow assumes the role to call API operations of relevant services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram:${region}:${accountID}:${role}</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The type of the flow. Set this parameter to <b>FDL</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
