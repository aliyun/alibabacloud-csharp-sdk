// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The template information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public GetModuleResponseBodyModule Module { get; set; }
        public class GetModuleResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T06:11:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The group information.</para>
            /// </summary>
            [NameInMap("groupInfo")]
            [Validation(Required=false)]
            public GetModuleResponseBodyModuleGroupInfo GroupInfo { get; set; }
            public class GetModuleResponseBodyModuleGroupInfo : TeaModel {
                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-fu1a1ol8cob1oni01ekcloi</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>groupName</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p-al1d11jlvlsbvr11lf3pqo</para>
                /// </summary>
                [NameInMap("projectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectName</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>The latest version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6d14625614ddbe15</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModuleName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The storage path of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("outputPath")]
            [Validation(Required=false)]
            public string OutputPath { get; set; }

            /// <summary>
            /// <para>The template source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: Imported from OSS.</description></item>
            /// <item><description>Registry: Created from a template in the template center.</description></item>
            /// <item><description>ExportTask: Exported from a resource export task.</description></item>
            /// <item><description>Upload: Uploaded as a file.</description></item>
            /// <item><description>Shared: Cloned from a shared template.</description></item>
            /// <item><description>Editor: Created by using the online editor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The source path of the template.</para>
            /// <list type="bullet">
            /// <item><description>If the source is Registry, the value is in the format of <workspace name>/<module name>:<module version>, such as terraform-alicloud-modules/rds:1.0.0.</description></item>
            /// <item><description>If the source is OSS, the value is in the format of oss::<file link>, such as oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>.</description></item>
            /// <item><description>If the source is ExportTask, the value is in the format of <export task ID>:<exported version>, such as ex-3b6cb9fa4751afff298da723c24ac:v1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <para>The path of the state file that corresponds to the template. Currently, only OSS paths are supported. The value is in the format of oss::<file OSS path>/terraform.tfstate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate</a></para>
            /// </summary>
            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

            /// <summary>
            /// <para>The template status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The template is being created.</description></item>
            /// <item><description>Created: The template is created.</description></item>
            /// </list>
            /// <para>After the template is created, you can publish a version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the template.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetModuleResponseBodyModuleTags> Tags { get; set; }
            public class GetModuleResponseBodyModuleTags : TeaModel {
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
            /// <item><description>Manual: Versions are generated manually. This is the default value.</description></item>
            /// <item><description>SourcePathUpdated: A new version is generated when the sourcePath is modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("versionStrategy")]
            [Validation(Required=false)]
            public string VersionStrategy { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E7BA3EB-B0EF-53F5-9999-07CAD6D9F8A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
