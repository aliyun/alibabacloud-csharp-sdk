// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileEventsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the event on web tamper proofing is handled. Valid values:
        /// 
        /// *   **n**: no
        /// *   **y**: yes
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// The name of the asset.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the names of assets.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp.
        /// </summary>
        [NameInMap("TsBegin")]
        [Validation(Required=false)]
        public long? TsBegin { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp.
        /// </summary>
        [NameInMap("TsEnd")]
        [Validation(Required=false)]
        public long? TsEnd { get; set; }

    }

}
