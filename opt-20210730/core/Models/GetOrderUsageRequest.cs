// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Opt20210730.Models
{
    public class GetOrderUsageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RelService")]
        [Validation(Required=false)]
        public string RelService { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public int? TimeRange { get; set; }

    }

}
