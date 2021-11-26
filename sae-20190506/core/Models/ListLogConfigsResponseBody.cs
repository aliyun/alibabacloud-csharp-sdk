// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListLogConfigsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLogConfigsResponseBodyData Data { get; set; }
        public class ListLogConfigsResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("LogConfigs")]
            [Validation(Required=false)]
            public List<ListLogConfigsResponseBodyDataLogConfigs> LogConfigs { get; set; }
            public class ListLogConfigsResponseBodyDataLogConfigs : TeaModel {
                public string ConfigName { get; set; }
                public string CreateTime { get; set; }
                public string LogDir { get; set; }
                public string LogType { get; set; }
                public string RegionId { get; set; }
                public string SlsLogStore { get; set; }
                public string SlsProject { get; set; }
                public string StoreType { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
