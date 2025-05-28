// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListUserGroupsByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2440604-3059-561A-AD68-DEDBC870EB2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the group.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListUserGroupsByUserIdResponseBodyResult> Result { get; set; }
        public class ListUserGroupsByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the user group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15 17:13:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The user group creator. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Directory level of the user group.</para>
            /// </summary>
            [NameInMap("IdentifiedPath")]
            [Validation(Required=false)]
            public string IdentifiedPath { get; set; }

            /// <summary>
            /// <para>The time when the user group was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15 20:36:40</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The user group modifier. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
            /// </summary>
            [NameInMap("ParentUsergroupId")]
            [Validation(Required=false)]
            public string ParentUsergroupId { get; set; }

            /// <summary>
            /// <para>The description of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("UsergroupDesc")]
            [Validation(Required=false)]
            public string UsergroupDesc { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34fd141d-4598-4093-8c33-8e066dcb****</para>
            /// </summary>
            [NameInMap("UsergroupId")]
            [Validation(Required=false)]
            public string UsergroupId { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test user group</para>
            /// </summary>
            [NameInMap("UsergroupName")]
            [Validation(Required=false)]
            public string UsergroupName { get; set; }

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
