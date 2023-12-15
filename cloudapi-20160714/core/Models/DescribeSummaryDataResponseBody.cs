// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSummaryDataResponseBody : TeaModel {
        /// <summary>
        /// The number of subscription dedicated instances that expire in 14 days or less.
        /// </summary>
        [NameInMap("ExpireInstanceNum")]
        [Validation(Required=false)]
        public int? ExpireInstanceNum { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of APIs.
        /// </summary>
        [NameInMap("UsageApiNum")]
        [Validation(Required=false)]
        public int? UsageApiNum { get; set; }

        /// <summary>
        /// The number of API groups.
        /// </summary>
        [NameInMap("UsageGroupNum")]
        [Validation(Required=false)]
        public int? UsageGroupNum { get; set; }

        /// <summary>
        /// The number of running dedicated instances.
        /// </summary>
        [NameInMap("UsageInstanceNum")]
        [Validation(Required=false)]
        public int? UsageInstanceNum { get; set; }

    }

}
