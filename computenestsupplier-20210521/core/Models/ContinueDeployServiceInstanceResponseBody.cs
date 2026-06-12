// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ContinueDeployServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the dry run.</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public ContinueDeployServiceInstanceResponseBodyDryRunResult DryRunResult { get; set; }
        public class ContinueDeployServiceInstanceResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// <para>The parameters that can be modified. No error is reported if you modify these parameters.</para>
            /// <remarks>
            /// <para>This parameter is returned only when DryRun is set to true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be conditionally modified. Whether an error is reported depends on the new values of these parameters.</para>
            /// <remarks>
            /// <para>This parameter is returned only when DryRun is set to true.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that cannot be modified. An error is reported if you modify these parameters.</para>
            /// <remarks>
            /// <para>This parameter is returned only when DryRun is set to true.</para>
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
