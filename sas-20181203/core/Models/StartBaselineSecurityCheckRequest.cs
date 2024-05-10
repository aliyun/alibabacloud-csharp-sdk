// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartBaselineSecurityCheckRequest : TeaModel {
        /// <summary>
        /// The IDs of the check items.
        /// 
        /// > To perform a check task on cloud service configurations, you must specify the ID of the check item. You can call the [DescribeRiskItemType](~~DescribeRiskItemType~~) operation to query the IDs of check items.
        /// </summary>
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<long?> ItemIds { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the check task. Valid values:
        /// 
        /// *   **check**
        /// *   **verify**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
