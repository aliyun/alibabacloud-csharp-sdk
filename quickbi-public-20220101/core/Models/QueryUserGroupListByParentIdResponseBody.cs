// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupListByParentIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72B19D61-B37A-5C7A-9389-0856CD7935B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the sub-user group.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserGroupListByParentIdResponseBodyResult> Result { get; set; }
        public class QueryUserGroupListByParentIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the sub-user group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-30 10:03:09</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the sub-user group. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>136516262323****</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Directory level of the sub-user group.</para>
            /// </summary>
            [NameInMap("IdentifiedPath")]
            [Validation(Required=false)]
            public string IdentifiedPath { get; set; }

            /// <summary>
            /// <para>The time when the sub-user group was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-16 15:49:08</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The user who modified the subgroup. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>136516262323****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The ID of the parent user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
            /// </summary>
            [NameInMap("ParentUserGroupId")]
            [Validation(Required=false)]
            public string ParentUserGroupId { get; set; }

            /// <summary>
            /// <para>The description of the sub-user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User Group for Testing</para>
            /// </summary>
            [NameInMap("UserGroupDescription")]
            [Validation(Required=false)]
            public string UserGroupDescription { get; set; }

            /// <summary>
            /// <para>The ID of the sub-user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f5eeb52e-d9c2-4a8b-80e3-47ab55c2****</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            /// <summary>
            /// <para>The name of the sub-user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>popapi test group</para>
            /// </summary>
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
