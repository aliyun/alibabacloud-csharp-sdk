// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <para>The constraints of the parameters.</para>
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            /// <summary>
            /// <para>The values of the parameter.</para>
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
            /// <item><description>NoLimit: No limit is imposed on the value of this parameter.</description></item>
            /// <item><description>NotSupport: The value of this parameter cannot be queried.</description></item>
            /// <item><description>QueryError: This parameter failed to be queried.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If AllowedValues is not returned, Behavior and BehaviorReason are returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NoLimit</para>
            /// </summary>
            [NameInMap("Behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            /// <summary>
            /// <para>The reason why the behavior of the parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No resource property refer to the parameter</para>
            /// </summary>
            [NameInMap("BehaviorReason")]
            [Validation(Required=false)]
            public string BehaviorReason { get; set; }

            /// <summary>
            /// <para>The values that do not conform to the parameter constraints.</para>
            /// <remarks>
            /// <para>If AllowedValues is returned, IllegalValueByParameterConstraints and IllegalValueByRules are returned at the same time.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IllegalValueByParameterConstraints")]
            [Validation(Required=false)]
            public List<object> IllegalValueByParameterConstraints { get; set; }

            /// <summary>
            /// <para>The values that do not match the rules in the template.</para>
            /// <remarks>
            /// <para>If AllowedValues is returned, IllegalValueByParameterConstraints and IllegalValueByRules are returned at the same time.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IllegalValueByRules")]
            [Validation(Required=false)]
            public List<object> IllegalValueByRules { get; set; }

            /// <summary>
            /// <para>The unsupported resource in the template.</para>
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
            /// <para>The original constraint information.</para>
            /// </summary>
            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                /// <summary>
                /// <para>The values of the parameter.</para>
                /// </summary>
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<object> AllowedValues { get; set; }

                /// <summary>
                /// <para>Behavior of the parameter</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueryError</para>
                /// </summary>
                [NameInMap("Behavior")]
                [Validation(Required=false)]
                public string Behavior { get; set; }

                /// <summary>
                /// <para>The reason for the parameter behavior</para>
                /// 
                /// <b>Example:</b>
                /// <para>No resource property refer to the parameter</para>
                /// </summary>
                [NameInMap("BehaviorReason")]
                [Validation(Required=false)]
                public string BehaviorReason { get; set; }

                /// <summary>
                /// <para>The name of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZoneId</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

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
            /// <para>The error that is returned when the request fails.</para>
            /// </summary>
            [NameInMap("QueryErrors")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors> QueryErrors { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::ECS::InstanceGroup</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
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
            /// <para>Query the details of timeout.</para>
            /// </summary>
            [NameInMap("QueryTimeoutDetails")]
            [Validation(Required=false)]
            public List<GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryTimeoutDetails> QueryTimeoutDetails { get; set; }
            public class GetTemplateParameterConstraintsResponseBodyParameterConstraintsQueryTimeoutDetails : TeaModel {
                /// <summary>
                /// <para>Error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>query property SlaveZoneIds.* in resource rds error, error message: query 8 seconds timeout</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>Resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>Resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN::RDS::DBInstance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The data type of the parameter.</para>
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
