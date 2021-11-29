// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterServiceConfigHistoryResponseBody : TeaModel {
        [NameInMap("ConfigHistoryList")]
        [Validation(Required=false)]
        public ListClusterServiceConfigHistoryResponseBodyConfigHistoryList ConfigHistoryList { get; set; }
        public class ListClusterServiceConfigHistoryResponseBodyConfigHistoryList : TeaModel {
            [NameInMap("ConfigHistory")]
            [Validation(Required=false)]
            public List<ListClusterServiceConfigHistoryResponseBodyConfigHistoryListConfigHistory> ConfigHistory { get; set; }
            public class ListClusterServiceConfigHistoryResponseBodyConfigHistoryListConfigHistory : TeaModel {
                public bool? Applied { get; set; }
                public string Author { get; set; }
                public string Comment { get; set; }
                public string ConfigFileName { get; set; }
                public string ConfigItemName { get; set; }
                public string ConfigVersion { get; set; }
                public long? CreateTime { get; set; }
                public string HostGroupId { get; set; }
                public string HostGroupName { get; set; }
                public string HostInstanceId { get; set; }
                public string HostName { get; set; }
                public string NewValue { get; set; }
                public string OldValue { get; set; }
                public string ServiceName { get; set; }
            }
        };

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
