// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchRetcodeAppByPageResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchRetcodeAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchRetcodeAppByPageResponseBodyPageBean : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("RetcodeApps")]
            [Validation(Required=false)]
            public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps> RetcodeApps { get; set; }
            public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps : TeaModel {
                public string Type { get; set; }
                public string AppName { get; set; }
                public long? UpdateTime { get; set; }
                public long? CreateTime { get; set; }
                public long? AppId { get; set; }
                public string Pid { get; set; }
                public string UserId { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
