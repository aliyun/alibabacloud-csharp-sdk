// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetServiceLinkedRoleTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service-linked role template.</para>
        /// </summary>
        [NameInMap("ServiceLinkedRoleTemplate")]
        [Validation(Required=false)]
        public GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplate ServiceLinkedRoleTemplate { get; set; }
        public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplate : TeaModel {
            /// <summary>
            /// <para>Indicates whether multiple roles are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Multiple roles are supported.</description></item>
            /// <item><description>false: Multiple roles are not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MultipleRolesAllowed")]
            [Validation(Required=false)]
            public bool? MultipleRolesAllowed { get; set; }

            [NameInMap("RoleDescriptions")]
            [Validation(Required=false)]
            public GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptions RoleDescriptions { get; set; }
            public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptions : TeaModel {
                [NameInMap("RoleDescription")]
                [Validation(Required=false)]
                public List<GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptionsRoleDescription> RoleDescription { get; set; }
                public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptionsRoleDescription : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

            }

            /// <summary>
            /// <para>The prefix of the role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRoleForPolarDB</para>
            /// </summary>
            [NameInMap("RoleNamePrefix")]
            [Validation(Required=false)]
            public string RoleNamePrefix { get; set; }

            /// <summary>
            /// <para>The cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The name of the system policy attached to the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRolePolicyForPolarDB</para>
            /// </summary>
            [NameInMap("SystemPolicyName")]
            [Validation(Required=false)]
            public string SystemPolicyName { get; set; }

        }

    }

}
