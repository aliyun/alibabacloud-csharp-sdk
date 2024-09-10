// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreIdcProbeScanResultRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Valid values:
        /// 
        /// *   **1**: adds the scan result to the whitelist.
        /// *   **2**: ignores the scan result.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IgnoreAction")]
        [Validation(Required=false)]
        public int? IgnoreAction { get; set; }

        /// <summary>
        /// The ID of the scan result. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeIdcProbeScanResultList](~~DescribeIdcProbeScanResultList~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScanResultIds")]
        [Validation(Required=false)]
        public string ScanResultIds { get; set; }

    }

}
