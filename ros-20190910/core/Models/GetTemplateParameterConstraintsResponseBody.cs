// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the parameter constraints.</para>
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            /// <summary>
            /// <para>The list of valid values of the parameter.</para>
            /// </summary>
            [NameInMap("AllowedValues")]
            [Validation(Required=false)]
            public List<string> AllowedValues { get; set; }

            /// <summary>
            /// <para>The names of the associated parameters.</para>
            /// </summary>
            [NameInMap("AssociationParameterNames")]
            [Validation(Required=false)]
            public List<string> AssociationParameterNames { get; set; }

            /// <summary>
            /// <para>The behavior of the parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoLimit: The parameter has no limit on its valid values.</para>
            /// </description></item>
            /// <item><description><para>NotSupport: The valid values of the parameter cannot be queried.</para>
            /// </description></item>
            /// <item><description><para>QueryError: The query failed.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If AllowedValues is not returned, Behavior and BehaviorReason are returned to indicate the behavior of the parameter and the reason for the behavior.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NoLimit</para>
            /// </summary>
            [NameInMap("Behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            /// <summary>
            /// <para>The reason for the behavior of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No resource property refer to the parameter</para>
            /// </summary>
            [NameInMap("BehaviorReason")]
            [Validation(Required=false)]
            public string BehaviorReason { get; set; }

            /// <summary>
            /// <para>The values that do not match the parameter constraints.</para>
            /// <remarks>
            /// <para>If AllowedValues is returned, IllegalValueByParameterConstraints and IllegalValueByRules are returned to indicate the invalid values that are filtered out by the parameter constraints and template rules.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IllegalValueByParameterConstraints")]
            [Validation(Required=false)]
            public List<object> IllegalValueByParameterConstraints { get; set; }

            /// <summary>
            /// <para>The values that do not match the template rules.</para>
            /// <remarks>
            /// <para>If AllowedValues is returned, IllegalValueByParameterConstraints and IllegalValueByRules are returned to indicate the invalid values that are filtered out by the parameter constraints and template rules.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IllegalValueByRules")]
            [Validation(Required=false)]
            public List<object> IllegalValueByRules { get; set; }

            /// <summary>
            /// <para>The details of the unsupported resources.</para>
            /// </summary>
            [NameInMap("NotSupportResources")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsNotSupportResources> NotSupportResources { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsNotSupportResources : TeaModel {
                /// <summary>
                /// <para>The name of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceName</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::InstanceGroup</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The information about the original constraints.</para>
            /// </summary>
            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                /// <summary>
                /// <para>The list of valid values of the parameter.</para>
                /// </summary>
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<object> AllowedValues { get; set; }

                /// <summary>
                /// <para>The behavior of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueryError</para>
                /// </summary>
                [NameInMap("Behavior")]
                [Validation(Required=false)]
                public string Behavior { get; set; }

                /// <summary>
                /// <para>The reason for the behavior of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No resource property refer to the parameter</para>
                /// </summary>
                [NameInMap("BehaviorReason")]
                [Validation(Required=false)]
                public string BehaviorReason { get; set; }

                /// <summary>
                /// <para>The query parameters that are used during the query of parameter constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;ZoneId&quot;:&quot;cn-hangzhou-h&quot;,
                ///     &quot;SystemDiskCategory&quot;:&quot;cloud_essd&quot;
                /// }</para>
                /// </summary>
                [NameInMap("PropertiesData")]
                [Validation(Required=false)]
                public string PropertiesData { get; set; }

                /// <summary>
                /// <para>The name of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZoneId</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <para>The request information of the operation that is called to query the parameter constraints of a cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs:2014-05-26:DescribeAvailableResource:4C5B6929-EB64-5086-A821-9CCB553A5AE9</para>
                /// </summary>
                [NameInMap("RequestInfo")]
                [Validation(Required=false)]
                public string RequestInfo { get; set; }

                /// <summary>
                /// <para>The name of the resource that is defined in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyECS</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::InstanceGroup</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZoneInfo</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The details of the query failure.</para>
            /// </summary>
            [NameInMap("QueryErrors")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors> QueryErrors { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors : TeaModel {
                /// <summary>
                /// <para>The error details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::InstanceGroup</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyECS</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceType is needed while query DataDisk</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The details of the query timeout.</para>
            /// </summary>
            [NameInMap("QueryTimeoutDetails")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryTimeoutDetails> QueryTimeoutDetails { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryTimeoutDetails : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query property SlaveZoneIds.* in resource rds error, error message: query 8 seconds timeout</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::RDS::DBInstance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The type of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9816785B-BCF8-514D-8B76-C1EC2BC954FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
