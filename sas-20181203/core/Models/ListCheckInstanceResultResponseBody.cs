// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// The basic information about the affected instances.
        /// </summary>
        [NameInMap("BasicData")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyBasicData> BasicData { get; set; }
        public class ListCheckInstanceResultResponseBodyBasicData : TeaModel {
            /// <summary>
            /// The check result ID of the instance.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The instance ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the region in which the instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The states of check items. Multiple states are separated with commas (,). Valid values:
            /// 
            /// *   **PASS**: The instance passed the check.
            /// *   **NOT_PASS**: The instance failed to pass the check.
            /// *   **CHECKING**: The instance is being checked.
            /// *   **NOT_CHECK**: The instance is not checked.
            /// *   **WHITELIST**: The instance is in the whitelist.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The information about the exceptions of check items.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// The extended information about the instances.
        /// </summary>
        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Checks { get; set; }

        /// <summary>
        /// The metadata information about the search conditions that can be used to filter instances.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyColumns> Columns { get; set; }
        public class ListCheckInstanceResultResponseBodyColumns : TeaModel {
            /// <summary>
            /// The metadata information about the details of the instance.
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<ListCheckInstanceResultResponseBodyColumnsGrids> Grids { get; set; }
            public class ListCheckInstanceResultResponseBodyColumnsGrids : TeaModel {
                /// <summary>
                /// The search condition.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The display name of the search condition.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// The format of the check results for the instance. Valid values:
                /// 
                /// *   **text**
                /// *   **link**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The search condition.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Indicates whether the search condition is supported. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

            /// <summary>
            /// The value of the search condition.
            /// </summary>
            [NameInMap("SearchKey")]
            [Validation(Required=false)]
            public string SearchKey { get; set; }

            /// <summary>
            /// The display name of the search condition.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// The format of the check result for the instance. Valid values:
            /// 
            /// *   **text**
            /// *   **link**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckInstanceResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckInstanceResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
