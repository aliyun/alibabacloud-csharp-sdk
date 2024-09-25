// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ContinueDeployServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The dry run result.</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public ContinueDeployServiceInstanceResponseBodyDryRunResult DryRunResult { get; set; }
        public class ContinueDeployServiceInstanceResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// <para>The parameters that can be modified. The operation that is performed to modify the parameters does not cause a validation error.</para>
            /// <remarks>
            /// <para> This parameter is returned only if DryRun is set to true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be modified under specific conditions. The new values of the parameters determine whether the operation that is performed to modify the parameters causes a validation error.</para>
            /// <remarks>
            /// <para> This parameter is returned only if DryRun is set to true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that cannot be modified. The operation that is performed to modify the parameters causes a validation error.</para>
            /// <remarks>
            /// <para> This parameter is returned only if DryRun is set to true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82DF27ED-E538-5AC0-A11C-39334A873189</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
