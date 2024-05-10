// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The queried resource groups.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApsResourceGroupsResponseBodyData Data { get; set; }
        public class DescribeApsResourceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The queried resource groups.
            /// </summary>
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeApsResourceGroupsResponseBodyDataResourceGroups> ResourceGroups { get; set; }
            public class DescribeApsResourceGroupsResponseBodyDataResourceGroups : TeaModel {
                /// <summary>
                /// Indicates whether the resource group is available. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("CuOptions")]
                [Validation(Required=false)]
                public List<long?> CuOptions { get; set; }

                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the resource group. Valid values:
                /// 
                /// *   **Interactive**
                /// *   **Job**
                /// 
                /// >  For more information about resource groups, see [Resource groups](https://help.aliyun.com/document_detail/428610.html).
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// The amount of remaining computing resources. Unit: ACUs.
                /// </summary>
                [NameInMap("LeftComputeResource")]
                [Validation(Required=false)]
                public int? LeftComputeResource { get; set; }

                /// <summary>
                /// The maximum amount of reserved computing resources. Unit: ACUs.
                /// 
                /// *   If the value of GroupType is **Interactive**, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 16 ACUs.
                /// *   If the value of GroupType is **Job**, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 8 ACUs.
                /// </summary>
                [NameInMap("MaxComputeResource")]
                [Validation(Required=false)]
                public int? MaxComputeResource { get; set; }

                /// <summary>
                /// The minimum amount of reserved computing resources. Unit: ACUs.
                /// 
                /// *   If the value of GroupType is **Interactive**, 16 is returned.
                /// *   If the value of GroupType is **Job**, 0 is returned.
                /// </summary>
                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public int? MinComputeResource { get; set; }

            }

            /// <summary>
            /// The step size of resources. Unit: AnalyticDB compute units (ACUs).
            /// 
            /// *   If the value of GroupType is **Interactive**, 16 is returned.
            /// *   If the value of GroupType is **Job**, 8 is returned.
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public long? Step { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the request was successful, a success message is returned.
        /// *   If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
