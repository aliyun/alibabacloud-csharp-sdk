// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetModuleResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public GetModuleResponseBodyModule Module { get; set; }
        public class GetModuleResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-06T06:11:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-4267dcfbf1b6d14625614ddbe15</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("outputPath")]
            [Validation(Required=false)]
            public string OutputPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS：
            /// &quot;oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a>&quot;
            /// Registry：
            /// &quot;alibaba/security-group/alicloud:2.1.0&quot;</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("versionStrategy")]
            [Validation(Required=false)]
            public string VersionStrategy { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E7BA3EB-B0EF-53F5-9999-07CAD6D9F8A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
