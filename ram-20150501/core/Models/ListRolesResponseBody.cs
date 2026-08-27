// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>This parameter is returned only when <c>IsTruncated</c> is <c>true</c>. If the value of <c>IsTruncated</c> is <c>true</c>, call this operation again and use <c>Marker</c> to retrieve the truncated content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

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
                [NameInMap("AllowConsoleLogin")]
                [Validation(Required=false)]
                public bool? AllowConsoleLogin { get; set; }

                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("MaxSessionDuration")]
                [Validation(Required=false)]
                public long? MaxSessionDuration { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListRolesResponseBodyRolesRoleTags Tags { get; set; }
                public class ListRolesResponseBodyRolesRoleTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyRolesRoleTagsTag> Tag { get; set; }
                    public class ListRolesResponseBodyRolesRoleTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

    }

}
