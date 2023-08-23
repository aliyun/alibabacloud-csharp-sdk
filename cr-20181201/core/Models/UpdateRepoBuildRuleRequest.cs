// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoBuildRuleRequest : TeaModel {
        /// <summary>
        /// Building arguments.
        /// </summary>
        [NameInMap("BuildArgs")]
        [Validation(Required=false)]
        public List<string> BuildArgs { get; set; }

        /// <summary>
        /// The ID of the building rule.
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        /// <summary>
        /// The path of the Dockerfile.
        /// </summary>
        [NameInMap("DockerfileLocation")]
        [Validation(Required=false)]
        public string DockerfileLocation { get; set; }

        /// <summary>
        /// The name of the Dockerfile.
        /// </summary>
        [NameInMap("DockerfileName")]
        [Validation(Required=false)]
        public string DockerfileName { get; set; }

        /// <summary>
        /// The tag of the image.
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Architecture for image building. Valid values:
        /// 
        /// *   `linux/amd64`
        /// *   `linux/arm64`
        /// *   `linux/386`
        /// *   `linux/arm/v7`
        /// *   `linux/arm/v6`
        /// 
        /// Default value: `linux/amd64`
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<string> Platforms { get; set; }

        /// <summary>
        /// The name of the push that triggers the building rule.
        /// </summary>
        [NameInMap("PushName")]
        [Validation(Required=false)]
        public string PushName { get; set; }

        /// <summary>
        /// The type of the push that triggers the building rule. Valid values:
        /// 
        /// *   `GIT_TAG`: tag push
        /// *   `GIT_BRANCH`: branch push
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
