// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListRolesResponseBodyRoles Roles { get; set; }
        public class ListRolesResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyRolesRole> Role { get; set; }
            public class ListRolesResponseBodyRolesRole : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IsServiceLinkedRole")]
                [Validation(Required=false)]
                public bool? IsServiceLinkedRole { get; set; }

                [NameInMap("LatestDeletionTask")]
                [Validation(Required=false)]
                public ListRolesResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseBodyRolesRoleLatestDeletionTask : TeaModel {
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=false)]
                    public string DeletionTaskId { get; set; }

                }

                [NameInMap("MaxSessionDuration")]
                [Validation(Required=false)]
                public long? MaxSessionDuration { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("RolePrincipalName")]
                [Validation(Required=false)]
                public string RolePrincipalName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of roles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
