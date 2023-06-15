// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLCollectorRetentionResponseBody : TeaModel {
        /// <summary>
        /// The log backup retention duration that is allowed by the SQL explorer feature on the instance. Valid values:
        /// 
        /// *   **30:** 30 days
        /// *   **180:** 180 days
        /// *   **365:** one year
        /// *   **1095:** three years
        /// *   **1825:** five years
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
