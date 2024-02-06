// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// Details about applications.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyApplications Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyApplicationsApplication> Application { get; set; }
            public class ListApplicationsResponseBodyApplicationsApplication : TeaModel {
                /// <summary>
                /// Details about the application.
                /// </summary>
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public ListApplicationsResponseBodyApplicationsApplicationAppList AppList { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationAppList : TeaModel {
                    [NameInMap("App")]
                    [Validation(Required=false)]
                    public List<ListApplicationsResponseBodyApplicationsApplicationAppListApp> App { get; set; }
                    public class ListApplicationsResponseBodyApplicationsApplicationAppListApp : TeaModel {
                        /// <summary>
                        /// The ID of the application.
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// The information about the application, such as the resource specification, parameter configuration, and resources.
                        /// </summary>
                        [NameInMap("AppInfo")]
                        [Validation(Required=false)]
                        public string AppInfo { get; set; }

                    }

                }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
