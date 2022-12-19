// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicPreCheckImageScanTaskRequest : TeaModel {
        /// <summary>
        /// The SHA-256 value of the image digest. Separate multiple SHA-256 values with commas (,).
        /// </summary>
        [NameInMap("Digests")]
        [Validation(Required=false)]
        public string Digests { get; set; }

        /// <summary>
        /// The ID of the Container Registry instance in which the image repository is created. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The region ID of the image. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

        /// <summary>
        /// The type of the image repository. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **acr**
        /// *   **harbor**
        /// *   **quay**
        /// </summary>
        [NameInMap("RegistryTypes")]
        [Validation(Required=false)]
        public string RegistryTypes { get; set; }

        /// <summary>
        /// The ID of the image repository. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RepoIds")]
        [Validation(Required=false)]
        public string RepoIds { get; set; }

        /// <summary>
        /// The name of the image repository. Separate multiple names with commas (,).
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNames { get; set; }

        /// <summary>
        /// The namespace to which the image repository belongs. Separate multiple namespaces with commas (,).
        /// </summary>
        [NameInMap("RepoNamespaces")]
        [Validation(Required=false)]
        public string RepoNamespaces { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The tag that is added to the image. Separate multiple tags with commas (,).
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
