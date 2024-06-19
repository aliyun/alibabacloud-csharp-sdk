/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CommitContainerRequest : TeaModel {
        /// <summary>
        /// The access credential configurations of the Container Registry Enterprise Edition instance.
        /// 
        /// >  If you use a Container Registry Personal Edition instance, you do not need to configure this parameter. If you use a Container Registry Enterprise Edition instance, you must configure this parameter.
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public CommitContainerRequestAcrRegistryInfo AcrRegistryInfo { get; set; }
        public class CommitContainerRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Access (ARN) of the RAM role that is assigned to the user (the authorized account) in cross-account authorization scenarios.
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// The ARN of the RAM role that is assigned to the authorizer in cross-account authorization scenarios.
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// The ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The details about the ARN that is required for authorization.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public CommitContainerRequestArn Arn { get; set; }
        public class CommitContainerRequestArn : TeaModel {
            /// <summary>
            /// The ARN of the authorized role.
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// The authorization type. A value of service indicates that RAM roles are used for authorization.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// The ID of the container group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The name of the container.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The image of the container.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommitContainerRequestImage Image { get; set; }
        public class CommitContainerRequestImage : TeaModel {
            /// <summary>
            /// The authorization of the image.
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// The message about the image.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The image repository.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// The tag of the image. This parameter is empty by default, which indicates that the tag is not modified.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
