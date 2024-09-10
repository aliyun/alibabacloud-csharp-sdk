// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// The status of the IP address. Valid values:
        /// 
        /// *   **0**: The IP address is valid.
        /// *   **1**: The IP address is ignored.
        /// *   *2*: The IP address is invalid.
        /// *   *3*: The IP address is expired.
        /// *   *4*: The probe that is used to scan the IP address does not exist.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The keyword that is used to match assets in fuzzy mode.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
