// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForOrganizationalUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>The applications that the EIAM organization can access.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsForOrganizationalUnitResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsForOrganizationalUnitResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the application that the EIAM organization can access.</para>
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
            public List<ListApplicationsForOrganizationalUnitResponseBodyApplicationsApplicationRoles> ApplicationRoles { get; set; }
            public class ListApplicationsForOrganizationalUnitResponseBodyApplicationsApplicationRoles : TeaModel {
                /// <summary>
                /// <para>应用角色标识。</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ApplicationRoleId")]
                [Validation(Required=false)]
                public string ApplicationRoleId { get; set; }

            }

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
