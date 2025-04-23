// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetModuleVersionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0D298375-F92F-5B65-82E4-EA68F02521F1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public GetModuleVersionResponseBodyVersion Version { get; set; }
        public class GetModuleVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08T18:07:40Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6dfffbc27e218d1b66</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/terraform.tfstate</a></para>
            /// </summary>
            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("versionStrategy")]
            [Validation(Required=false)]
            public string VersionStrategy { get; set; }

        }

    }

}
