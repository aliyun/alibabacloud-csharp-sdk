// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run for the request to check information such as the permissions and instance status. Valid values:
        /// 
        /// *   true: performs a dry run for the request, but does not create a service instance.
        /// *   false: performs a dry run for the request, and creates a service instance if the request passes the dry run.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The time when the service instance was released.
        /// 
        /// >  This parameter is available only for the service instances that are managed by service providers.
        /// 
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the service instance. The value must meet the following requirements:
        /// 
        /// *   The name cannot exceed 64 characters in length.
        /// *   It can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The parameters that are specified for service instance deployment.
        /// 
        /// >  If you want to specify the region in which the service instance is deployed, you must specify the information in Parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// The region ID. Valid values:
        /// 
        /// *   cn-hangzhou: China (Hangzhou)
        /// *   ap-southeast-1: Singapore
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The name of the package specification.
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// The custom tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceInstanceShrinkRequestTag> Tag { get; set; }
        public class CreateServiceInstanceShrinkRequestTag : TeaModel {
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
        /// The template name. You must specify a template name if the service supports multiple templates.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
