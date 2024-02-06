// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the data file.
        /// </summary>
        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        /// <summary>
        /// The version number of the data file.
        /// </summary>
        [NameInMap("DataVersion")]
        [Validation(Required=false)]
        public string DataVersion { get; set; }

        /// <summary>
        /// This parameter is reserved.
        /// </summary>
        [NameInMap("ExpireTimeout")]
        [Validation(Required=false)]
        public long? ExpireTimeout { get; set; }

        /// <summary>
        /// The condition that you want to use to filter file servers. You can specify multiple canary release policies. By default, all resources are queried.
        /// </summary>
        [NameInMap("ServerFilterStrategy")]
        [Validation(Required=false)]
        public string ServerFilterStrategy { get; set; }

    }

}
