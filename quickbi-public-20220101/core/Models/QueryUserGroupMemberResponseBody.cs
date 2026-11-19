// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48C930FF-DFCF-5986-902B-E24C202E2443</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result of the user group member list.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserGroupMemberResponseBodyResult> Result { get; set; }
        public class QueryUserGroupMemberResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the user group or the user group member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the item is a user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The item is a user group.</description></item>
            /// <item><description>false: The item is a user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsUserGroup")]
            [Validation(Required=false)]
            public bool? IsUserGroup { get; set; }

            /// <summary>
            /// <para>The name of the user group or the nickname of the user group member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xiao Liu\&quot;s test user group</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
            /// </summary>
            [NameInMap("ParentUserGroupId")]
            [Validation(Required=false)]
            public string ParentUserGroupId { get; set; }

            /// <summary>
            /// <para>The name of the parent user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finance group</para>
            /// </summary>
            [NameInMap("ParentUserGroupName")]
            [Validation(Required=false)]
            public string ParentUserGroupName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
