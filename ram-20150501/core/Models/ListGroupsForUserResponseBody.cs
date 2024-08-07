// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// The list of the RAM user groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListGroupsForUserResponseBodyGroups Groups { get; set; }
        public class ListGroupsForUserResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListGroupsForUserResponseBodyGroupsGroup> Group { get; set; }
            public class ListGroupsForUserResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// The description of the RAM user group.
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// The ID of the RAM user group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the RAM user group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The time when the RAM user joined the RAM user group.
                /// </summary>
                [NameInMap("JoinDate")]
                [Validation(Required=false)]
                public string JoinDate { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
