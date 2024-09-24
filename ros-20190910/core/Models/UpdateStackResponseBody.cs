// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The dry run result. This parameter is returned only if DryRun is set to true.</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public UpdateStackResponseBodyDryRunResult DryRunResult { get; set; }
        public class UpdateStackResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// <para>The parameters that can be modified. If you change only values of the parameters in a stack template and use the template to update the stack, no validation errors are caused.</para>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be modified under specific conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the new values of the parameters determine whether validation errors are caused.</para>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions under specific conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources under specific conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that cannot be modified. If you change only values of the parameters in a stack template and use the template to update the stack, validation errors are caused.</para>
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be modified under uncertain conditions. If you change only values of the parameters in a stack template and use the template to update the stack, the actual running environment determines whether validation errors are caused.</para>
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions under uncertain conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources under uncertain conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
