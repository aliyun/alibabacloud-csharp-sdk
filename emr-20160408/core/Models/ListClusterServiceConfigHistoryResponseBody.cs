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
                [NameInMap("Applied")]
                [Validation(Required=false)]
                public bool? Applied { get; set; }

                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("ConfigFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                [NameInMap("ConfigItemName")]
                [Validation(Required=false)]
                public string ConfigItemName { get; set; }

                [NameInMap("ConfigVersion")]
                [Validation(Required=false)]
                public string ConfigVersion { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

                [NameInMap("HostGroupName")]
                [Validation(Required=false)]
                public string HostGroupName { get; set; }

                [NameInMap("HostInstanceId")]
                [Validation(Required=false)]
                public string HostInstanceId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
