// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactRequest : TeaModel {
        /// <summary>
        /// The ID of the deployment package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// The properties of the deployment package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public UpdateArtifactRequestArtifactProperty ArtifactProperty { get; set; }
        public class UpdateArtifactRequestArtifactProperty : TeaModel {
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
            /// The metadata of the Object Storage Service (OSS) object.
            /// 
            /// >  This parameter is available only if the deployment package is an OSS object.
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
            /// The script content of the deployment package.
            /// 
            /// >  This parameter is available only if the deployment package is a script.
            /// </summary>
            [NameInMap("ScriptMetadata")]
            [Validation(Required=false)]
            public string ScriptMetadata { get; set; }

            /// <summary>
            /// The URL of the deployment package object.
            /// 
            /// 
            /// > Note This parameter is available only if the deployment package is an file.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The description of the deployment package.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The IDs of the regions that support the deployment package.
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

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
