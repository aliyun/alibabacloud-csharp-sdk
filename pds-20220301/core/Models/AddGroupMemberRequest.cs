// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AddGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination group to which the member is added.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e5***2c2</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The member ID. If member_type is set to user, set this parameter to a user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e4***1b1</para>
        /// </summary>
        [NameInMap("member_id")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The type of the member. Set the value to user. When you create a group, you can directly add the group to a parent group.</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// </list>
        /// <para>Note: A group can be added to only one group. A user can be added to multiple groups.</para>
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
