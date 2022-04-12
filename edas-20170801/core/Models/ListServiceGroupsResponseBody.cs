// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListServiceGroupsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceGroupsList")]
        [Validation(Required=false)]
        public ListServiceGroupsResponseBodyServiceGroupsList ServiceGroupsList { get; set; }
        public class ListServiceGroupsResponseBodyServiceGroupsList : TeaModel {
            [NameInMap("ListServiceGroups")]
            [Validation(Required=false)]
            public List<ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups> ListServiceGroups { get; set; }
            public class ListServiceGroupsResponseBodyServiceGroupsListListServiceGroups : TeaModel {
                public string CreateTime { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
            }
        };

    }

}
