// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the deployment package.
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// The properties of the deployment object.
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactPropertyShrink { get; set; }

        /// <summary>
        /// The type of the deployment package. Valid values:
        /// 
        /// *   EcsImage: Elastic Compute Service (ECS) image.
        /// *   AcrImage: container image.
        /// *   File: Object Storage Service (OSS) object.
        /// *   Script: script.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// The description of the deployment package.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the deployment package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The supported regions.
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

        /// <summary>
        /// The custom tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateArtifactShrinkRequestTag> Tag { get; set; }
        public class CreateArtifactShrinkRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The version name of the deployment package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
