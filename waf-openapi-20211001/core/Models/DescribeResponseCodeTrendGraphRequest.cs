// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: seconds. If you do not specify this parameter, the current time is used.
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to obtain the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The time interval. Unit: seconds. The value must be an integral multiple of 60.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The ID of the region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou:** the Chinese mainland.
        /// *   **ap-southeast-1:** outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The protected object.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// The type of the error codes. Valid values:
        /// 
        /// *   **waf:** error codes that are returned to clients from WAF.
        /// *   **upstream:** error codes that are returned to WAF from the origin server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
