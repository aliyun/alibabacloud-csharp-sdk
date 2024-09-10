// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageScanTaskRequest : TeaModel {
        /// <summary>
        /// The digest of the image.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The time when the image was created.
        /// </summary>
        [NameInMap("ImageCreate")]
        [Validation(Required=false)]
        public long? ImageCreate { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The size of the image. Unit: bytes.
        /// </summary>
        [NameInMap("ImageSize")]
        [Validation(Required=false)]
        public long? ImageSize { get; set; }

        /// <summary>
        /// The time when the image was updated.
        /// </summary>
        [NameInMap("ImageUpdate")]
        [Validation(Required=false)]
        public long? ImageUpdate { get; set; }

        /// <summary>
        /// The information about the Jenkins environment.
        /// </summary>
        [NameInMap("JenkinsEnv")]
        [Validation(Required=false)]
        public string JenkinsEnv { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The tag of the image.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The token that is used to access the Jenkins image repository.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The UUID of the image asset.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
