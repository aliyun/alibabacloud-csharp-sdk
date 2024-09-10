// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the assets.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeGroupedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeGroupedInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The number of assets on which high-risk vulnerabilities are detected.
            /// </summary>
            [NameInMap("AsapVulInstanceCount")]
            [Validation(Required=false)]
            public long? AsapVulInstanceCount { get; set; }

            /// <summary>
            /// The number of assets that are protected by the specified edition.
            /// </summary>
            [NameInMap("AuthVersionCheckCount")]
            [Validation(Required=false)]
            public int? AuthVersionCheckCount { get; set; }

            /// <summary>
            /// The name of the server group.
            /// </summary>
            [NameInMap("FieldAliasName")]
            [Validation(Required=false)]
            public string FieldAliasName { get; set; }

            /// <summary>
            /// The type of the server group. Valid values:
            /// 
            /// *   **0**: the default group
            /// *   **1**: other group
            /// </summary>
            [NameInMap("GroupFlag")]
            [Validation(Required=false)]
            public int? GroupFlag { get; set; }

            /// <summary>
            /// The number of cores of assets in the specified asset type.
            /// 
            /// >  If the **MachineTypes** request parameter is not specified, the value of the InstanceCoreCount parameter indicates the total number of cores of assets within your account.
            /// </summary>
            [NameInMap("InstanceCoreCount")]
            [Validation(Required=false)]
            public long? InstanceCoreCount { get; set; }

            /// <summary>
            /// The total number of assets that belong to the specified type.
            /// 
            /// >  If the **MachineTypes** request parameter is not specified, the value of the InstanceCount parameter is the total number of your assets.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public string InstanceCount { get; set; }

            /// <summary>
            /// The operating system type of the asset. Valid values:
            /// 
            /// * **windows**
            /// * **linux**
            /// 
            /// > This parameter is returned only when Lang is set to zh.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The number of assets that are at risk.
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public string RiskInstanceCount { get; set; }

            /// <summary>
            /// The number of assets that are not protected by Security Center.
            /// </summary>
            [NameInMap("UnProtectedInstanceCount")]
            [Validation(Required=false)]
            public string UnProtectedInstanceCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeGroupedInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeGroupedInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
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
