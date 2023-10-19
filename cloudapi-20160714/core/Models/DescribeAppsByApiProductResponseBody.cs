// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppsByApiProductResponseBody : TeaModel {
        [NameInMap("AuthorizedApps")]
        [Validation(Required=false)]
        public DescribeAppsByApiProductResponseBodyAuthorizedApps AuthorizedApps { get; set; }
        public class DescribeAppsByApiProductResponseBodyAuthorizedApps : TeaModel {
            [NameInMap("AuthorizedApp")]
            [Validation(Required=false)]
            public List<DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp> AuthorizedApp { get; set; }
            public class DescribeAppsByApiProductResponseBodyAuthorizedAppsAuthorizedApp : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AuthValidTime")]
                [Validation(Required=false)]
                public string AuthValidTime { get; set; }

                [NameInMap("AuthorizedTime")]
                [Validation(Required=false)]
                public string AuthorizedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

            }

        }

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
