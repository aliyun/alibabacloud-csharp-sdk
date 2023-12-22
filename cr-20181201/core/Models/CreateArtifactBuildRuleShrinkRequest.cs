// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateArtifactBuildRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The type of the artifact.
        /// 
        /// *   `ACCELERATED_IMAGE`: accelerated images.
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Additional parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// The ID of the effective range of the rule.
        /// 
        /// *   Set the value to the ID of the image repository.
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// The effective range of the rule. Valid values:
        /// 
        /// *   `REPOSITORY`
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
