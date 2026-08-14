// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetProjectAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the project authorization.</para>
        /// </summary>
        [NameInMap("ProjectAuthorization")]
        [Validation(Required=false)]
        public GetProjectAuthorizationResponseBodyProjectAuthorization ProjectAuthorization { get; set; }
        public class GetProjectAuthorizationResponseBodyProjectAuthorization : TeaModel {
            /// <summary>
            /// <para>The project authorization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthorizationId")]
            [Validation(Required=false)]
            public long? AuthorizationId { get; set; }

            /// <summary>
            /// <para>The description of the project authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project authorization name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about the project administrators specified in the project authorization.</para>
            /// </summary>
            [NameInMap("Principals")]
            [Validation(Required=false)]
            public List<GetProjectAuthorizationResponseBodyProjectAuthorizationPrincipals> Principals { get; set; }
            public class GetProjectAuthorizationResponseBodyProjectAuthorizationPrincipals : TeaModel {
                /// <summary>
                /// <para>The ID of the RAM user specified as the project administrator when PrincipalType is RamUser. The ARN of the RAM role specified as the project administrator when PrincipalType is RamRole.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2036****6767</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The display name of the RAM user or RAM role of the project administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// <para>The type of the project administrator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>RamUser</b>: Resource Access Management (RAM) user.</para>
                /// </description></item>
                /// <item><description><para><b>RamRole</b>: RAM role.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RamRole</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            /// <summary>
            /// <para>The list of project IDs associated with the project authorization.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<long?> ProjectIds { get; set; }

            /// <summary>
            /// <para>The information about the projects associated with the project authorization.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<GetProjectAuthorizationResponseBodyProjectAuthorizationProjects> Projects { get; set; }
            public class GetProjectAuthorizationResponseBodyProjectAuthorizationProjects : TeaModel {
                /// <summary>
                /// <para>The description of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>comment</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the project is the default project. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The scope of manageable assets associated with the authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: All projects.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Specified projects.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

        }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
