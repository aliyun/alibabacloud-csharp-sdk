// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListProjectAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListProjectAppsResponseBodyResult Result { get; set; }
        public class ListProjectAppsResponseBodyResult : TeaModel {
            [NameInMap("ProjectApps")]
            [Validation(Required=false)]
            public List<ListProjectAppsResponseBodyResultProjectApps> ProjectApps { get; set; }
            public class ListProjectAppsResponseBodyResultProjectApps : TeaModel {
                public int? Status { get; set; }
                public string ProjectId { get; set; }
                public string UserId { get; set; }
                public long? GmtModified { get; set; }
                public string AppPkgName { get; set; }
                public string AppName { get; set; }
                public string AppSecret { get; set; }
                public string AppKey { get; set; }
                public string AppId { get; set; }
                public int? OsType { get; set; }
                public long? GmtCreate { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
