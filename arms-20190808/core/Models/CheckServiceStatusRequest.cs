// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CheckServiceStatusRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service code of an Alibaba Cloud service. The service code of Prometheus Service is prometheus.
        /// </summary>
        [NameInMap("SvcCode")]
        [Validation(Required=false)]
        public string SvcCode { get; set; }

    }

}
