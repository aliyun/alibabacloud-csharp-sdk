// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Applications")]
        [Validation(Required=true)]
        public ListApplicationsResponseApplications Applications { get; set; }
        public class ListApplicationsResponseApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=true)]
            public List<ListApplicationsResponseApplicationsApplication> Application { get; set; }
            public class ListApplicationsResponseApplicationsApplication : TeaModel {
                public string ClusterName { get; set; }
                public ListApplicationsResponseApplicationsApplicationAppList AppList { get; set; }
                public class ListApplicationsResponseApplicationsApplicationAppList : TeaModel {
                    [NameInMap("App")]
                    [Validation(Required=true)]
                    public List<ListApplicationsResponseApplicationsApplicationAppListApp> App { get; set; }
                    public class ListApplicationsResponseApplicationsApplicationAppListApp : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=true)]
                        public string AppId { get; set; }

                        [NameInMap("AppInfo")]
                        [Validation(Required=true)]
                        public string AppInfo { get; set; }

                    }

                }
            }
        };

    }

}
