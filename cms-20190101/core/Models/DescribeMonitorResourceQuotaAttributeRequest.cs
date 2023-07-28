// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the instance to be monitored.
        /// </summary>
        [NameInMap("ShowUsed")]
        [Validation(Required=false)]
        public bool? ShowUsed { get; set; }

    }

}
