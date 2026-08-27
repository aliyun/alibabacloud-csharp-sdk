// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The validation result. This parameter is returned only when DryRun is set to true.</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public UpdateStackResponseBodyDryRunResult DryRunResult { get; set; }
        public class UpdateStackResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// <para>The parameters that are allowed to be modified.</para>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that will definitely cause resource interruption.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Only a small number of resource types are supported.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that will definitely cause resource replacement update.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is returned only when ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that may be allowed to be modified.</para>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that may cause resource interruption.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Only a small number of resource types are supported.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that may cause resource replacement update.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is returned only when ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that are not allowed to be modified.</para>
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that are uncertain to be allowed to be modified.</para>
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that are uncertain to cause resource interruption.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Only a small number of resource types are supported.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that are uncertain to cause resource replacement update.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This is returned only when ReplacementOption is set to Enabled.</description></item>
            /// <item><description>This applies only to updating ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
