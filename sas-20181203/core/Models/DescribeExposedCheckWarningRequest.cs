// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedCheckWarningRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the baseline.
        /// 
        /// >  You can call the [DescribeRiskType](~~DescribeRiskType~~) operation to obtain the types of baselines from the response parameter **TypeName**.
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// The UUID of the server. Separate multiple UUIDs with commas (,).
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
