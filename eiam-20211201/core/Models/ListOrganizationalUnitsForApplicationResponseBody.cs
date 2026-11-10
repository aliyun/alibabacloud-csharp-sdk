// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitsForApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of organizational unit IDs.</para>
        /// </summary>
        [NameInMap("OrganizationalUnits")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits : TeaModel {
            /// <summary>
            /// <para>The application roles.</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnitsApplicationRoles> ApplicationRoles { get; set; }
            public class ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnitsApplicationRoles : TeaModel {
                /// <summary>
                /// <para>The application role ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ApplicationRoleId")]
                [Validation(Required=false)]
                public string ApplicationRoleId { get; set; }

            }

            /// <summary>
            /// <para>The organizational unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

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
