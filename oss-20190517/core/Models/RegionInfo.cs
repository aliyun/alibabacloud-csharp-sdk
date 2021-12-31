// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RegionInfo : TeaModel {
        /// <summary>
        /// accelerate endpoint
        /// </summary>
        [NameInMap("AccelerateEndpoint")]
        [Validation(Required=false)]
        public string AccelerateEndpoint { get; set; }

        /// <summary>
        /// internal endpoint
        /// </summary>
        [NameInMap("InternalEndpoint")]
        [Validation(Required=false)]
        public string InternalEndpoint { get; set; }

        /// <summary>
        /// internet endpoint
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// region
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
