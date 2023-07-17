// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
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

            [NameInMap("RetcodeApps")]
            [Validation(Required=false)]
            public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps> RetcodeApps { get; set; }
            public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
