// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceTemplateParameterConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <para>The package family constraints.</para>
        /// </summary>
        [NameInMap("FamilyConstraints")]
        [Validation(Required=false)]
        public List<string> FamilyConstraints { get; set; }

        /// <summary>
        /// <para>The constraints on the parameters.</para>
        /// </summary>
        [NameInMap("ParameterConstraints")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints> ParameterConstraints { get; set; }
        public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraints : TeaModel {
            /// <summary>
            /// <para>The valid values of the parameter.</para>
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
            /// <para> If AllowedValues is not returned, Behavior and BehaviorReason are returned, which indicate the behavior of the parameter and the reason for the behavior.</para>
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
            /// <para>The original constraint information.</para>
            /// </summary>
            [NameInMap("OriginalConstraints")]
            [Validation(Required=false)]
            public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints> OriginalConstraints { get; set; }
            public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsOriginalConstraints : TeaModel {
                /// <summary>
                /// <para>The valid values of the parameter.</para>
                /// </summary>
                [NameInMap("AllowedValues")]
                [Validation(Required=false)]
                public List<string> AllowedValues { get; set; }

                /// <summary>
                /// <para>The property name.</para>
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
            /// <para>The error details that are returned if the request fails.</para>
            /// </summary>
            [NameInMap("QueryErrors")]
            [Validation(Required=false)]
            public List<GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors> QueryErrors { get; set; }
            public class GetServiceTemplateParameterConstraintsResponseBodyParameterConstraintsQueryErrors : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>record not exist</para>
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
                /// <para>ALIYUN::ECS::InstanceGroup</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>449DC03D-A039-56A6-8D6F-6EBCCCE0EE2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
