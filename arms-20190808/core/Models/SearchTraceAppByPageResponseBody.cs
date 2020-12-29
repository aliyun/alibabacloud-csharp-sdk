// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTraceAppByPageResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTraceAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTraceAppByPageResponseBodyPageBean : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("TraceApps")]
            [Validation(Required=false)]
            public List<SearchTraceAppByPageResponseBodyPageBeanTraceApps> TraceApps { get; set; }
            public class SearchTraceAppByPageResponseBodyPageBeanTraceApps : TeaModel {
                public string Type { get; set; }
                public string AppName { get; set; }
                public long? UpdateTime { get; set; }
                public List<string> Labels { get; set; }
                public bool? Show { get; set; }
                public long? CreateTime { get; set; }
                public string Pid { get; set; }
                public long? AppId { get; set; }
                public string UserId { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
