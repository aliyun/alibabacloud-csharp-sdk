// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackOperationRisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The operations on which the permissions are not granted to the Alibaba Cloud account of the caller.</para>
        /// </summary>
        [NameInMap("MissingPolicyActions")]
        [Validation(Required=false)]
        public List<string> MissingPolicyActions { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72108E7A-E874-4A5E-B22C-A61E94AD12CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources that are at risk.</para>
        /// </summary>
        [NameInMap("RiskResources")]
        [Validation(Required=false)]
        public List<ListStackOperationRisksResponseBodyRiskResources> RiskResources { get; set; }
        public class ListStackOperationRisksResponseBodyRiskResources : TeaModel {
            /// <summary>
            /// <para>The error code that is returned when the risk detection fails.</para>
            /// <remarks>
            /// <para> This parameter is not returned if the risk detection is successful.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NoPermission</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The logical ID of the resource. The logical ID is the resource name that is defined in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySG</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The error message that is returned when the risk detection fails.</para>
            /// <remarks>
            /// <para> This parameter is not returned if the risk detection is successful.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>You are not authorized to complete this action.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The physical ID of the resource. The physical ID is the actual ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1dpioafqphedg9****</para>
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// <para>The cause of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There are some ECS instances (i-bp18el96s4wq635e****) depending on the security group.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the request when the risk detection fails.</para>
            /// <remarks>
            /// <para> This parameter is not returned if the risk detection is successful.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DF4296CF-F45F-4845-A72B-BE617601DB25</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::SecurityGroup</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type of the risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Referenced: The resource is referenced by other resources.</description></item>
            /// <item><description>MaybeReferenced: The resource may be referenced by other resources.</description></item>
            /// <item><description>AdditionalRiskCheckRequired: An additional risk detection is required for a nested stack.</description></item>
            /// <item><description>OperationIgnored: The operation does not take effect for the resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Referenced</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

        }

    }

}
