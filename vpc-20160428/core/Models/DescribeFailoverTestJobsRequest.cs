// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The filter information.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeFailoverTestJobsRequestFilter> Filter { get; set; }
        public class DescribeFailoverTestJobsRequestFilter : TeaModel {
            /// <summary>
            /// The filter key. Valid values:
            /// 
            /// *   **JobId**
            /// *   **JobName**
            /// *   **JobStatus**
            /// *   **ResourceId**
            /// *   **ResourceName**
            /// *   **ResourceType**
            /// 
            /// > You can specify at most five different filter keys. If you specify ResourceId or ResourceName, you must also specify ResourceType. The logical operator among the filter keys is AND. Results that meet all specified filter keys are returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter key.
            /// 
            /// > You can specify at most five filter values for each filter key. The logical operator among filter values is OR. If a filter value is matched, the filter key is considered matched.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 100**. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region where you want to perform the failover test.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
