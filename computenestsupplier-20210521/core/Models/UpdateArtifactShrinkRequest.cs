// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactShrinkRequest : TeaModel {
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
        public string ArtifactPropertyShrink { get; set; }

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
