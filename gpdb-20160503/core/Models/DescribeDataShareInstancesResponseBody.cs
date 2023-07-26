// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataShareInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details of the instances.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDataShareInstancesResponseBodyItems Items { get; set; }
        public class DescribeDataShareInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDataShareInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDataShareInstancesResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The resource type of the instance. Valid values:
                /// 
                /// *   **Serverless**: Serverless mode
                /// *   **StorageElasic**: elastic storage mode
                /// *   **Classic**: reserved storage mode
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// The state of data sharing. Valid values:
                /// 
                /// *   **opening**: Data sharing is being enabled.
                /// *   **opened**: Data sharing is enabled.
                /// *   **closing**: Data sharing is being disabled.
                /// *   **closed**: Data sharing is disabled.
                /// </summary>
                [NameInMap("DataShareStatus")]
                [Validation(Required=false)]
                public string DataShareStatus { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
