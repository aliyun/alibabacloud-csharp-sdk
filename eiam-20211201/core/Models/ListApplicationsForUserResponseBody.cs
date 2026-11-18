// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of applications that the account is authorized to access.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsForUserResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsForUserResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The list of application roles. No roles are returned for SAML applications.</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListApplicationsForUserResponseBodyApplicationsApplicationRoles> ApplicationRoles { get; set; }
            public class ListApplicationsForUserResponseBodyApplicationsApplicationRoles : TeaModel {
                /// <summary>
                /// <para>The application role ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ApplicationRoleId")]
                [Validation(Required=false)]
                public string ApplicationRoleId { get; set; }

                /// <summary>
                /// <para>Indicates whether direct authorization exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDirectAuthorization")]
                [Validation(Required=false)]
                public bool? HasDirectAuthorization { get; set; }

                /// <summary>
                /// <para>Indicates whether inherited authorization exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasInheritAuthorization")]
                [Validation(Required=false)]
                public bool? HasInheritAuthorization { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether direct authorization exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: A direct authorization record exists between the application and the account.</description></item>
            /// <item><description>false: No direct authorization record exists between the application and the account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasDirectAuthorization")]
            [Validation(Required=false)]
            public bool? HasDirectAuthorization { get; set; }

            /// <summary>
            /// <para>Indicates whether inherited authorization exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: A direct authorization record exists between the application and at least one parent organization of the account or a group to which the account belongs.</description></item>
            /// <item><description>false: No direct authorization record exists between the application and any parent organization of the account or any group to which the account belongs.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
