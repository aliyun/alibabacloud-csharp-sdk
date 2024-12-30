// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class RemoveGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the group from which you want to remove a member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e5***2c2</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the member. If member_type is set to user, set this parameter to the ID of the corresponding user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e4***1b1</para>
        /// </summary>
        [NameInMap("member_id")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The type of the member that you want to remove from the group. Only common users can be removed. If you want to remove all members from a group, you can directly delete the group. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// </list>
        /// <para>Note: A group can be a member of only one group. It cannot be a member of multiple groups. A user can be a member of multiple groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("member_type")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

    }

}
