// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListLibraryInstallTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListLibraryInstallTasksResponseBodyItems Items { get; set; }
        public class ListLibraryInstallTasksResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListLibraryInstallTasksResponseBodyItemsItem> Item { get; set; }
            public class ListLibraryInstallTasksResponseBodyItemsItem : TeaModel {
                public string ClusterBizId { get; set; }
                public string Detail { get; set; }
                public long? EndTime { get; set; }
                public long? ExecuteTime { get; set; }
                public string Hostname { get; set; }
                public string LibraryBizId { get; set; }
                public long? StartTime { get; set; }
                public string TaskGroupId { get; set; }
                public string TaskId { get; set; }
                public int? TaskProcess { get; set; }
                public string TaskStatus { get; set; }
                public string TaskType { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
