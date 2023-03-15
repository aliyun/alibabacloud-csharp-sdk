// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ContinueCreateStackResponseBody : TeaModel {
        /// <summary>
        /// The validation result.
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public ContinueCreateStackResponseBodyDryRunResult DryRunResult { get; set; }
        public class ContinueCreateStackResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// The parameters that can be modified. The operation that is performed to modify the parameters does not cause a validation error.
            /// 
            /// >  This parameter is returned only if the DryRun parameter is set to `true`. The value of the ParametersAllowedToBeModified parameter varies based on the values of the Mode, Template\*, RecreatingResources.N, and RecreatingOptions.N parameters.
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under specific conditions.
            /// 
            /// The new values of the parameters determine whether the operation that is performed to modify the parameters causes a validation error.
            /// 
            /// >  This parameter is returned only if the DryRun parameter is set to `true`. The value of the ParametersConditionallyAllowedToBeModified parameter varies based on the values of the Mode, Template\*, RecreatingResources.N, and RecreatingOptions.N parameters.
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that cannot be modified. The operation that is performed to modify the parameters causes a validation error.
            /// 
            /// >  This parameter is returned only if the DryRun parameter is set to `true`. The value of the ParametersNotAllowedToBeModified parameter varies based on the values of the Mode, Template\*, RecreatingResources.N, and RecreatingOptions.N parameters.
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
