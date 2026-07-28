// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetModuleVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D298375-F92F-5B65-82E4-EA68F02521F1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version details.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public GetModuleVersionResponseBodyVersion Version { get; set; }
        public class GetModuleVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The time when the version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T18:07:40Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6dfffbc27e218d1b66</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <para>The template version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <para>The version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>versionName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: imported from OSS.</description></item>
            /// <item><description>Registry: created by using a template from the template center.</description></item>
            /// <item><description>ExportTask: exported from a resource export task.</description></item>
            /// <item><description>Upload: uploaded as a file.</description></item>
            /// <item><description>Shared: cloned from a shared source.</description></item>
            /// <item><description>Editor: edited online.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The path of the version source.</para>
            /// <list type="bullet">
            /// <item><description>If the source is Registry, the value is in the format of <workspace name>/<module name>:<module version>. Example: terraform-alicloud-modules/rds:1.0.0.</description></item>
            /// <item><description>If the source is OSS, the value is in the format of oss::<file link>. Example: oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>.</description></item>
            /// <item><description>If the source is ExportTask, the value is in the format of <export task ID>:<exported version>. Example: ex-3b6cb9fa4751afff298da723c24ac:v1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <para>The path of the State file that corresponds to the template. Currently, only OSS paths are supported. The value is in the format of oss::<OSS file path>/terraform.tfstate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate</a></para>
            /// </summary>
            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

            /// <summary>
            /// <para>The Terraform content.</para>
            /// </summary>
            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            /// <summary>
            /// <para>The version generation strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: manually generate a version. This is the default value.</description></item>
            /// <item><description>SourcePathUpdated: a new version is generated when the sourcePath is modified.</description></item>
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

}
