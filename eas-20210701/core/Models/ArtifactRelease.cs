// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ArtifactRelease : TeaModel {
        /// <summary>
        /// <para>The artifact reference name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python-env</para>
        /// </summary>
        [NameInMap("ArtifactRef")]
        [Validation(Required=false)]
        public string ArtifactRef { get; set; }

        /// <summary>
        /// <para>The creation time of the artifact release record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15T10:30:00Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The artifact description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Container image for model inference</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The container image address used by the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/eas/echo_cn-shanghai:v0.0.1-20210129111320</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The artifact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
