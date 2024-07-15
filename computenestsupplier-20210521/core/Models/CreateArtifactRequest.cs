// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactRequest : TeaModel {
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
        public CreateArtifactRequestArtifactProperty ArtifactProperty { get; set; }
        public class CreateArtifactRequestArtifactProperty : TeaModel {
            /// <summary>
            /// The commodity code of the service in Alibaba Cloud Marketplace.
            /// 
            /// >  This parameter is available only if the deployment package is an image.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The commodity version of the service in Alibaba Cloud Marketplace.
            /// 
            /// >  This parameter is available only if the deployment package is an image.
            /// </summary>
            [NameInMap("CommodityVersion")]
            [Validation(Required=false)]
            public string CommodityVersion { get; set; }

            /// <summary>
            /// The script metadata.
            /// </summary>
            [NameInMap("FileScriptMetadata")]
            [Validation(Required=false)]
            public string FileScriptMetadata { get; set; }

            /// <summary>
            /// The image ID.
            /// 
            /// >  This parameter is available only if the deployment package is an image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The region ID.
            /// 
            /// >  This parameter is available only if the deployment package is an image.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the image repository.
            /// 
            /// >  This parameter is available only if the deployment package is a container image or of the Helm chart type.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// 
            /// >  This parameter is available only if the deployment package is a container image or of the Helm chart type.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The script content.
            /// 
            /// >  This parameter is available only if the deployment package is a script.
            /// </summary>
            [NameInMap("ScriptMetadata")]
            [Validation(Required=false)]
            public string ScriptMetadata { get; set; }

            /// <summary>
            /// The version tag of the image repository.
            /// 
            /// >  This parameter is available only if the deployment package is a container image or of the Helm chart type.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The object URL of the deployment package.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
        public List<CreateArtifactRequestTag> Tag { get; set; }
        public class CreateArtifactRequestTag : TeaModel {
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
