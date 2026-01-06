// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsForApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The group IDs.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsForApplicationResponseBodyGroups> Groups { get; set; }
        public class ListGroupsForApplicationResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>应用角色列表。</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListGroupsForApplicationResponseBodyGroupsApplicationRoles> ApplicationRoles { get; set; }
            public class ListGroupsForApplicationResponseBodyGroupsApplicationRoles : TeaModel {
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
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_miu8e4t4d7i4u7uwezgr54xxxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
