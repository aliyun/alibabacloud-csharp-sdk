// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateStackRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. We recommend that you use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the resource stack. The value cannot exceed 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stack to create ecs and related resource for multiple enviroments.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The resource stack name. The name must be 2 to 128 characters in length and can contain letters, digits, Chinese characters, hyphens (-), underscores (_), and periods (.). The name cannot start or end with a hyphen, underscore, or period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parameterSetIds")]
        [Validation(Required=false)]
        public List<string> ParameterSetIds { get; set; }

        /// <summary>
        /// <para>The RAM role to be assigned to the task. This role is used to automatically continue the execution of scheduled tasks during automatic triggers or offline scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestIacRole</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The creation source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: a template from OSS.</description></item>
        /// <item><description>IAC_SERVICE_MODULE: a template created in the automation service console.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The path of the configuration source. The value cannot exceed 1000 characters.</para>
        /// <list type="bullet">
        /// <item><description>If the source is OSS, the value is in the format oss::<file link> and must be a zip file. Example: oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></description></item>
        /// <item><description>If the source is IAC_SERVICE_MODULE, the value is a template ID. Example: mod-xxxxx</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
        /// </summary>
        [NameInMap("sourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The working directory where the configuration file is located. Enter / if it is in the root directory. Example: config/ or /</para>
        /// 
        /// <b>Example:</b>
        /// <para>/stack</para>
        /// </summary>
        [NameInMap("workingDirectory")]
        [Validation(Required=false)]
        public string WorkingDirectory { get; set; }

    }

}
