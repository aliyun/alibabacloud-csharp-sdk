// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7070EC3-DF66-58BA-A1DD-A8574FF53143</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack information.</para>
        /// </summary>
        [NameInMap("stack")]
        [Validation(Required=false)]
        public GetStackResponseBodyStack Stack { get; set; }
        public class GetStackResponseBodyStack : TeaModel {
            /// <summary>
            /// <para>The stack configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetStackResponseBodyStackConfig Config { get; set; }
            public class GetStackResponseBodyStackConfig : TeaModel {
                /// <summary>
                /// <para>The component configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB\nupstream_input:\n  - name: stack_network\n ...</para>
                /// </summary>
                [NameInMap("componentContent")]
                [Validation(Required=false)]
                public string ComponentContent { get; set; }

                /// <summary>
                /// <para>The deployment configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB \nvariable:\n  - name: region\n    type: string\n ...</para>
                /// </summary>
                [NameInMap("deploymentContent")]
                [Validation(Required=false)]
                public string DeploymentContent { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-24T02:58:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The current configuration version number, such as v1. The initial value is v1. The version number increments each time the stack is updated or refreshed and the configuration changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("currentConfigVersion")]
            [Validation(Required=false)]
            public string CurrentConfigVersion { get; set; }

            /// <summary>
            /// <para>The description of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>the description of stack</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The stack name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The RAM role assumed by the system to perform resource change operations during stack deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestIacRole</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <para>The configuration source of the stack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: a template stored in Object Storage Service (OSS).</description></item>
            /// <item><description>IAC_SERVICE_MODULE: a template created in the automation service console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The path value of the configuration source. The value cannot exceed 1000 characters.</para>
            /// <list type="bullet">
            /// <item><description>If the source is OSS, the value is in the format of oss::<file link>. The file must be a ZIP file. Example: oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>.</description></item>
            /// <item><description>If the source is IAC_SERVICE_MODULE, the value is a template ID. Example: mod-xxxxx.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <para>The unique identifier of the stack, which is generated after the stack is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stack-as1d4vld898ppnqxxxxxx</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The stack status.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Name</th>
            /// <th>Description</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>Creating</td>
            /// <td>The stack is being created.</td>
            /// </tr>
            /// <tr>
            /// <td>Created</td>
            /// <td>The stack is created.</td>
            /// </tr>
            /// <tr>
            /// <td>Waiting</td>
            /// <td>The stack is waiting for deployment.</td>
            /// </tr>
            /// <tr>
            /// <td>Deploying</td>
            /// <td>The stack is being deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deployed</td>
            /// <td>The stack is deployed.</td>
            /// </tr>
            /// <tr>
            /// <td>Errored</td>
            /// <td>The deployment failed.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleting</td>
            /// <td>The stack is being deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>Deleted</td>
            /// <td>The stack is deleted.</td>
            /// </tr>
            /// <tr>
            /// <td>DeleteFailed</td>
            /// <td>The deletion failed.</td>
            /// </tr>
            /// <tr>
            /// <td>DetectTriggered</td>
            /// <td>Drift detection is triggered.</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The deployment trigger method of the stack. This field is not publicly available.</para>
            /// <list type="bullet">
            /// <item><description>SetUpdated: triggered by file changes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SetUpdated</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            /// <summary>
            /// <para>The directory where the deployment and component configuration files of the stack are located. Set this parameter to / for the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("workingDirectory")]
            [Validation(Required=false)]
            public string WorkingDirectory { get; set; }

        }

    }

}
