// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetImportantRequest : TeaModel {
        /// <summary>
        /// The importance of the asset. Valid values:
        /// 
        /// *   **0**: test
        /// *   **1**: normal
        /// *   **2**: important
        /// </summary>
        [NameInMap("ImportantCode")]
        [Validation(Required=false)]
        public int? ImportantCode { get; set; }

        /// <summary>
        /// The UUIDs of servers. Separate multiple UUIDs with commas (,).
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
