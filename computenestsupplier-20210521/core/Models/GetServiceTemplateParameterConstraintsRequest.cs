// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceTemplateParameterConstraintsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the region in which the service instance is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the private connection feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnablePrivateVpcConnection")]
        [Validation(Required=false)]
        public bool? EnablePrivateVpcConnection { get; set; }

        /// <summary>
        /// The parameters in the template.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsRequestParameters> Parameters { get; set; }
        public class GetServiceTemplateParameterConstraintsRequestParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The parameter value.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The ID of the service instance.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The template name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
