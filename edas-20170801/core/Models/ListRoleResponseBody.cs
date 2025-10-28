// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57609587-DFA2-41EC-<b><b>-</b></b>*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The roles.</para>
        /// </summary>
        [NameInMap("RoleList")]
        [Validation(Required=false)]
        public ListRoleResponseBodyRoleList RoleList { get; set; }
        public class ListRoleResponseBodyRoleList : TeaModel {
            [NameInMap("RoleItem")]
            [Validation(Required=false)]
            public List<ListRoleResponseBodyRoleListRoleItem> RoleItem { get; set; }
            public class ListRoleResponseBodyRoleListRoleItem : TeaModel {
                /// <summary>
                /// <para>The set of permissions to be granted to the role.</para>
                /// </summary>
                [NameInMap("ActionList")]
                [Validation(Required=false)]
                public ListRoleResponseBodyRoleListRoleItemActionList ActionList { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListRoleResponseBodyRoleListRoleItemActionListAction> Action { get; set; }
                    public class ListRoleResponseBodyRoleListRoleItemActionListAction : TeaModel {
                        /// <summary>
                        /// <para>The serial number of the permission that is granted to the role.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The description of the permission to be granted to the role.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Operations in operation records</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The ID of the permission group to which the permission that is granted to the role belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>31</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// <para>The name of the permission to be granted to the role.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Operation records</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The roles.</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public ListRoleResponseBodyRoleListRoleItemRole Role { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemRole : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test**@aliyun.com</para>
                    /// </summary>
                    [NameInMap("AdminUserId")]
                    [Validation(Required=false)]
                    public string AdminUserId { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the role was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1542717260156</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the role is a default role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <para>The name of the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Super Admin(All privileges)</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the role was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1542717260156</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

        }

    }

}
