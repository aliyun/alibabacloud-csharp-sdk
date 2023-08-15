// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListInstanceServiceConfigHistoriesResponseBody : TeaModel {
        [NameInMap("ConfigureHistoryList")]
        [Validation(Required=false)]
        public ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryList ConfigureHistoryList { get; set; }
        public class ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryListConfig> Config { get; set; }
            public class ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryListConfig : TeaModel {
                [NameInMap("ConfigureName")]
                [Validation(Required=false)]
                public string ConfigureName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Effective")]
                [Validation(Required=false)]
                public string Effective { get; set; }

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
        public long? TotalRecordCount { get; set; }

    }

}
