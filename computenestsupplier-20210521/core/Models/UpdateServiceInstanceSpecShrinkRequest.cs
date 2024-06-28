// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceInstanceSpecShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable Prometheus on the customer side. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// The name of the configuration update operation.
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// The configuration parameters of the service instance.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// The name of the specification package.
        /// </summary>
        [NameInMap("PredefinedParametersName")]
        [Validation(Required=false)]
        public string PredefinedParametersName { get; set; }

        /// <summary>
        /// The service instance ID.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
