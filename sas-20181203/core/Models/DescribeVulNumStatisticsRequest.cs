// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulNumStatisticsRequest : TeaModel {
        /// <summary>
        /// The source of the request.
        /// 
        /// *   If you want to query Security Center-related data, set the value to **sas**.
        /// *   If you want to query Server Guard-related data, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}
