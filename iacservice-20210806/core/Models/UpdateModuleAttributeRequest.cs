// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateModuleAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public UpdateModuleAttributeRequestGroupInfo GroupInfo { get; set; }
        public class UpdateModuleAttributeRequestGroupInfo : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
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
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("versionStrategy")]
        [Validation(Required=false)]
        public string VersionStrategy { get; set; }

    }

}
