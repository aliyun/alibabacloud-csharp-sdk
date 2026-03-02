// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListGroupsForUserResponseBodyGroups Groups { get; set; }
        public class ListGroupsForUserResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListGroupsForUserResponseBodyGroupsGroup> Group { get; set; }
            public class ListGroupsForUserResponseBodyGroupsGroup : TeaModel {
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("JoinDate")]
                [Validation(Required=false)]
                public string JoinDate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
