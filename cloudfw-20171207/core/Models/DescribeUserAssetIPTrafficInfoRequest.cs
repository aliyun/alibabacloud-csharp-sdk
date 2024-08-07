// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoRequest : TeaModel {
        /// <summary>
        /// The IP address of the asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AssetIP")]
        [Validation(Required=false)]
        public string AssetIP { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public string TrafficTime { get; set; }

    }

}
