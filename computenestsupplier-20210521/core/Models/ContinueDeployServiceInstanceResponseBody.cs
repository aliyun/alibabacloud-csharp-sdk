// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ContinueDeployServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// The dry run result.
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public ContinueDeployServiceInstanceResponseBodyDryRunResult DryRunResult { get; set; }
        public class ContinueDeployServiceInstanceResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// The parameters that can be modified. The operation that is performed to modify the parameters does not cause a validation error.
            /// 
            /// >  This parameter is returned only if DryRun is set to true.
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under specific conditions. The new values of the parameters determine whether the operation that is performed to modify the parameters causes a validation error.
            /// 
            /// >  This parameter is returned only if DryRun is set to true.
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that cannot be modified. The operation that is performed to modify the parameters causes a validation error.
            /// 
            /// >  This parameter is returned only if DryRun is set to true.
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the service instance.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
