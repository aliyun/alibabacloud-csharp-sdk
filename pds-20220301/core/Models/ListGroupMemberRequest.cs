// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListGroupMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the group of which you want to query members.
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The member type. If you do not specify this parameter, both types of members are returned. Valid values:
        /// 
        /// *   user
        /// *   group
        /// 
        /// Note: A group can be a member of only one group. It cannot be a member of multiple groups. A user can be a member of multiple groups.
        /// </summary>
        [NameInMap("member_type")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

    }

}
