// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitsForApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the organizations that are allowed to access the application.</para>
        /// </summary>
        [NameInMap("OrganizationalUnits")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits : TeaModel {
            /// <summary>
            /// <para>应用角色列表。</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnitsApplicationRoles> ApplicationRoles { get; set; }
            public class ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnitsApplicationRoles : TeaModel {
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

            /// <summary>
            /// <para>The ID of the organization that is allowed to access the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

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
