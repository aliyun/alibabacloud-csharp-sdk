// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomGroupsResponseBody : TeaModel {
        [NameInMap("CustomGroups")]
        [Validation(Required=false)]
        public ListCustomGroupsResponseBodyCustomGroups CustomGroups { get; set; }
        public class ListCustomGroupsResponseBodyCustomGroups : TeaModel {
            [NameInMap("CustomGroup")]
            [Validation(Required=false)]
            public List<ListCustomGroupsResponseBodyCustomGroupsCustomGroup> CustomGroup { get; set; }
            public class ListCustomGroupsResponseBodyCustomGroupsCustomGroup : TeaModel {
                [NameInMap("CustomGroupDescription")]
                [Validation(Required=false)]
                public string CustomGroupDescription { get; set; }

                [NameInMap("CustomGroupId")]
                [Validation(Required=false)]
                public string CustomGroupId { get; set; }

                [NameInMap("CustomGroupName")]
                [Validation(Required=false)]
                public string CustomGroupName { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
