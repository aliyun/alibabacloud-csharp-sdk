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

        /// <summary>
        /// <para>The information about the roles.</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListRolesResponseBodyRoles Roles { get; set; }
        public class ListRolesResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyRolesRole> Role { get; set; }
            public class ListRolesResponseBodyRolesRole : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::123456789012****:role/ECSAdmin</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The time when the role was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The description of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS administrator</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the role is a service-linked role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsServiceLinkedRole")]
                [Validation(Required=false)]
                public bool? IsServiceLinkedRole { get; set; }

                /// <summary>
                /// <para>The information of the most recent deletion task.</para>
                /// </summary>
                [NameInMap("LatestDeletionTask")]
                [Validation(Required=false)]
                public ListRolesResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseBodyRolesRoleLatestDeletionTask : TeaModel {
                    /// <summary>
                    /// <para>The time when the deletion task was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-10-23T12:33:18Z</para>
                    /// </summary>
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    /// <summary>
                    /// <para>The ID of the deletion task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECSAdmin/cc61514b-26eb-4453-ab53-b142eb70****</para>
                    /// </summary>
                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=false)]
                    public string DeletionTaskId { get; set; }

                }

                /// <summary>
                /// <para>The maximum session duration of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("MaxSessionDuration")]
                [Validation(Required=false)]
                public long? MaxSessionDuration { get; set; }

                /// <summary>
                /// <para>The ID of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90123456789****</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The name of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECSAdmin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The name of the role after authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:ECSAdmin@role.123456.onaliyunservice.com">ECSAdmin@role.123456.onaliyunservice.com</a></para>
                /// </summary>
                [NameInMap("RolePrincipalName")]
                [Validation(Required=false)]
                public string RolePrincipalName { get; set; }

                /// <summary>
                /// <para>The time when the role was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-01-23T12:33:18Z</para>
                /// </summary>
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
