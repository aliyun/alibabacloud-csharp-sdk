// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
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
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
