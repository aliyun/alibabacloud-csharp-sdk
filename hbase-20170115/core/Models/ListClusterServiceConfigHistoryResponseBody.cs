// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Effective")]
                [Validation(Required=false)]
                public string Effective { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
