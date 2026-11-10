// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateModuleRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. Use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the template. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS instance module</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project group information to which the template belongs.</para>
        /// </summary>
        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public CreateModuleRequestGroupInfo GroupInfo { get; set; }
        public class CreateModuleRequestGroupInfo : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-5fd38c9b92d541a7083a86432e2</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-433aead75605713865c386cb9d</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The name of the template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, Chinese characters, hyphens (-), underscores (_), and periods (.). It cannot start or end with a hyphen, underscore, or period.</description></item>
        /// <item><description>The name must be unique among the template resources within the current account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-ecs-module</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Imports a template from a ZIP file stored in OSS.</description></item>
        /// <item><description>Registry: Creates a template by using a module from the template center.</description></item>
        /// <item><description>ExportTask: References a template exported by a resource export task.</description></item>
        /// <item><description>Editor: Creates a blank template that supports online editing.</description></item>
        /// <item><description>Upload: Generates a template by uploading a local template file.</description></item>
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
        /// <para>The path of the template source. This parameter is valid only when source is set to Registry, OSS, or ExportTask.</para>
        /// <list type="bullet">
        /// <item><description>If source is set to Registry, the value is in the <workspace name>/<module name>:<module version> format, such as terraform-alicloud-modules/rds:1.0.0.</description></item>
        /// <item><description>If source is set to OSS, the value is in the oss::<file URL> format. The file must be a ZIP file, such as oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>.</description></item>
        /// <item><description>If source is set to ExportTask, the value is in the <export task ID>:<exported version> format, such as ex-3b6cb9fa4751afff298da723c24ac:v1.</description></item>
        /// <item><description>If source is set to Editor or Upload, leave this parameter empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
        /// </summary>
        [NameInMap("sourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The path of the state file corresponding to the template. This parameter is valid only when source is set to OSS.
        /// The value is in the oss::<OSS path of the file>/terraform.tfstate format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate</a></para>
        /// </summary>
        [NameInMap("statePath")]
        [Validation(Required=false)]
        public string StatePath { get; set; }

        /// <summary>
        /// <para>The list of tags for the template.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateModuleRequestTags> Tags { get; set; }
        public class CreateModuleRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The version generation strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual: Manually generates a version. This is the default value.</description></item>
        /// <item><description>SourcePathUpdated: Generates a new version when sourcePath is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("versionStrategy")]
        [Validation(Required=false)]
        public string VersionStrategy { get; set; }

    }

}
