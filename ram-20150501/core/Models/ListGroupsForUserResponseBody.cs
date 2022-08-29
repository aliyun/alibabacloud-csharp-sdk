// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
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
                public string Comments { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string JoinDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
