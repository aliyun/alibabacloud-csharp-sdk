// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class RepoConfiguration : TeaModel {
        /// <summary>
        /// <para>The default parameters for the image build rule.</para>
        /// </summary>
        [NameInMap("ArtifactBuildRuleParameters")]
        [Validation(Required=false)]
        public RepoConfigurationArtifactBuildRuleParameters ArtifactBuildRuleParameters { get; set; }
        public class RepoConfigurationArtifactBuildRuleParameters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to build only the image index.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ImageIndexOnly")]
            [Validation(Required=false)]
            public bool? ImageIndexOnly { get; set; }

        }

        /// <summary>
        /// <para>The type of the image repository for automatic creation. Valid values: PRIVATE (private repository) and PUBLIC (public repository).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("RepoType")]
        [Validation(Required=false)]
        public string RepoType { get; set; }

        /// <summary>
        /// <para>Specifies whether image version immutability is enabled. After it is enabled, you cannot overwrite image versions other than latest.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagImmutability")]
        [Validation(Required=false)]
        public bool? TagImmutability { get; set; }

    }

}
