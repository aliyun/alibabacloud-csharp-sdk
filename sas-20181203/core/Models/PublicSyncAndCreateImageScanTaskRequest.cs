// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicSyncAndCreateImageScanTaskRequest : TeaModel {
        /// <summary>
        /// The information about the images. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **RegistryType**: the type of the image repository. Valid values:
        /// 
        ///     *   acr
        ///     *   harbor
        ///     *   quay
        /// 
        /// *   **RepoId**: the ID of the image repository.
        /// 
        /// *   **InstanceId**: the ID of the Container Registry instance to which the image repository belongs.
        /// 
        /// *   **RepoNamespace**: the namespace to which the image repository belongs.
        /// 
        /// *   **RegionId**: the region ID of the image.
        /// 
        /// *   **RepoName**: the name of the image repository.
        /// 
        /// *   **Digest**: the digest of the image.
        /// 
        /// *   **Tag**: the tag that is added to the image.
        /// 
        /// *   **CreateTime**: the timestamp when the image was created. Unit: milliseconds.
        /// 
        /// *   **UpdateTime**: the timestamp when the image was updated. Unit: milliseconds.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
