// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class SearchLogResponseBody : TeaModel {
        [NameInMap("SlsLogItemList")]
        [Validation(Required=false)]
        public SearchLogResponseBodySlsLogItemList SlsLogItemList { get; set; }
        public class SearchLogResponseBodySlsLogItemList : TeaModel {
            [NameInMap("SlsLogItem")]
            [Validation(Required=false)]
            public List<SearchLogResponseBodySlsLogItemListSlsLogItem> SlsLogItem { get; set; }
            public class SearchLogResponseBodySlsLogItemListSlsLogItem : TeaModel {
                public string SourceIp { get; set; }
                public string PackId { get; set; }
                public string Path { get; set; }
                public string HostName { get; set; }
                public int? Timestamp { get; set; }
                public string Content { get; set; }
                public string PackMeta { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Completed")]
        [Validation(Required=false)]
        public bool? Completed { get; set; }

    }

}
