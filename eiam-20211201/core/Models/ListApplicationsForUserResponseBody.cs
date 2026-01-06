// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The applications that the EIAM account can access.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsForUserResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsForUserResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the application that the EIAM account can access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>应用角色列表。</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListApplicationsForUserResponseBodyApplicationsApplicationRoles> ApplicationRoles { get; set; }
            public class ListApplicationsForUserResponseBodyApplicationsApplicationRoles : TeaModel {
                /// <summary>
                /// <para>应用角色标识。</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ApplicationRoleId")]
                [Validation(Required=false)]
                public string ApplicationRoleId { get; set; }

                /// <summary>
                /// <para>直接分配给当前用户的权限，视为直接授权。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDirectAuthorization")]
                [Validation(Required=false)]
                public bool? HasDirectAuthorization { get; set; }

                /// <summary>
                /// <para>通过用户隶属的组织、组获取的权限，视为继承权限。</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasInheritAuthorization")]
                [Validation(Required=false)]
                public bool? HasInheritAuthorization { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the EIAM account has direct permissions on the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The EIAM account has direct permissions on the application.</description></item>
            /// <item><description>false: The EIAM account does not have direct permissions on the application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasDirectAuthorization")]
            [Validation(Required=false)]
            public bool? HasDirectAuthorization { get; set; }

            /// <summary>
            /// <para>Indicates whether the EIAM account has inherited permissions on the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: A parent organization or an organization to which the EIAM account belongs has direct permissions on the application.</description></item>
            /// <item><description>false: A parent organization or an organization to which the EIAM account belongs does not have direct permissions on the application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasInheritAuthorization")]
            [Validation(Required=false)]
            public bool? HasInheritAuthorization { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
