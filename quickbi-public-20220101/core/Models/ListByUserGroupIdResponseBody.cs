// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListByUserGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user group query result is returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListByUserGroupIdResponseBodyResult Result { get; set; }
        public class ListByUserGroupIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of failed user groups.</para>
            /// </summary>
            [NameInMap("FailedUserGroupIds")]
            [Validation(Required=false)]
            public List<string> FailedUserGroupIds { get; set; }

            /// <summary>
            /// <para>The details of the user group that was queried.</para>
            /// </summary>
            [NameInMap("UserGroupModels")]
            [Validation(Required=false)]
            public List<ListByUserGroupIdResponseBodyResultUserGroupModels> UserGroupModels { get; set; }
            public class ListByUserGroupIdResponseBodyResultUserGroupModels : TeaModel {
                /// <summary>
                /// <para>The time when the Secret was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-15 17:13:55</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The UserID of the creator in the Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>46e5*******ee22e2a292704c8</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The path of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fe4fbd8-<b><b>-af083ea/34fd1-</b></b>-dcbc33f</para>
                /// </summary>
                [NameInMap("IdentifiedPath")]
                [Validation(Required=false)]
                public string IdentifiedPath { get; set; }

                /// <summary>
                /// <para>The time when the protection policy was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-15 20:36:40</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The UserID of the modifier in the Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>46e5*******ee22e2a292704c8</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The ID of the parent user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af083ea</para>
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
                /// <para>34fd141d-****-4093-8c33-8e066dcbc33f</para>
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
