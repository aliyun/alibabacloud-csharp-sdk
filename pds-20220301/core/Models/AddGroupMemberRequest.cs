// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AddGroupMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the destination group to which the member is added.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The member ID. If member_type is set to user, set this parameter to a user ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("member_id")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// The type of the member. Set the value to user. When you create a group, you can directly add the group to a parent group.
        /// 
        /// * user
        /// 
        /// Note: A group can be added to only one group. A user can be added to multiple groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("member_type")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

    }

}
