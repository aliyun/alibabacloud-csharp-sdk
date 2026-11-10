// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateStackRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. The format is [0-9a-zA-Z-]{1,64}. A UUID is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the stack. The name must be 2 to 128 characters in length, and can contain letters, digits, Chinese characters, hyphens (-), underscores (_), and periods (.). The name cannot start or end with a hyphen, underscore, or period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) role authorized for the task. This role is used to automatically resume the execution of scheduled tasks in auto-triggered or offline scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestIacRole</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the property validation of the provider. Default value: false.</para>
        /// </summary>
        [NameInMap("skipPropertyValidation")]
        [Validation(Required=false)]
        public bool? SkipPropertyValidation { get; set; }

        /// <summary>
        /// <para>The path value of the configuration source. The value cannot exceed 1,000 characters.</para>
        /// <list type="bullet">
        /// <item><description>If the source is OSS, the value is in the oss::<file URL> format. The file must be a ZIP file. Example: oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>.</description></item>
        /// <item><description>If the source is IAC_SERVICE_MODULE, the value is the template ID. Example: mod-xxxxx.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
        /// </summary>
        [NameInMap("sourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The working directory where the configuration file is located. If the file is in the root directory, enter /. Examples: config/ or /.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("workingDirectory")]
        [Validation(Required=false)]
        public string WorkingDirectory { get; set; }

    }

}
