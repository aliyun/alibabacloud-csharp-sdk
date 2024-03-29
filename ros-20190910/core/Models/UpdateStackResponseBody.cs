// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackResponseBody : TeaModel {
        /// <summary>
        /// The dry run result. This parameter is returned only if DryRun is set to true.
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public UpdateStackResponseBodyDryRunResult DryRunResult { get; set; }
        public class UpdateStackResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// The parameters that can be modified. If you change only values of the parameters in a stack template and use the template to update the stack, no validation errors are caused.
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions.
            /// > - This parameter is supported only for a small number of resource types.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources.
            /// 
            /// > -  This parameter can be returned only if ReplacementOption is set to Enabled.
            /// > -  This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under specific conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the new values of the parameters determine whether validation errors are caused.
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under specific conditions.
            /// 
            /// > - This parameter is supported only for a small number of resource types.
            /// > -  This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources under specific conditions.
            /// 
            /// > - This parameter can be returned only if ReplacementOption is set to Enabled.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// The parameters that cannot be modified. If you change only values of the parameters in a stack template and use the template to update the stack, validation errors are caused.
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters that can be modified under uncertain conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the actual running environment determines whether validation errors are caused.
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// The parameters whose changes cause service interruptions under uncertain conditions.
            /// 
            /// > - This parameter is supported only for a small number of resource types.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// The parameters whose changes trigger replacement updates for resources under uncertain conditions.
            /// 
            /// > - This parameter can be returned only if ReplacementOption is set to Enabled.
            /// > - This parameter is valid only for updates on ROS stacks.
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

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
