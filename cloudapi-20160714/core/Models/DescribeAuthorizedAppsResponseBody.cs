// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAuthorizedAppsResponseBody : TeaModel {
        [NameInMap("AuthorizedApps")]
        [Validation(Required=false)]
        public DescribeAuthorizedAppsResponseBodyAuthorizedApps AuthorizedApps { get; set; }
        public class DescribeAuthorizedAppsResponseBodyAuthorizedApps : TeaModel {
            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedApp> AuthorizedApp { get; set; }
            public class DescribeAuthorizedAppsResponseBodyAuthorizedAppsAuthorizedApp : TeaModel {
                public long? AppId { get; set; }
                public string AppName { get; set; }
                public string AuthVaildTime { get; set; }
                public string AuthorizationSource { get; set; }
                public string AuthorizedTime { get; set; }
                public string Description { get; set; }
                public string Operator { get; set; }
                public string StageName { get; set; }
            }
        };

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
