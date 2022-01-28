// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        [NameInMap("DataVersion")]
        [Validation(Required=false)]
        public string DataVersion { get; set; }

        [NameInMap("ExpireTimeout")]
        [Validation(Required=false)]
        public long? ExpireTimeout { get; set; }

        [NameInMap("ServerFilterStrategy")]
        [Validation(Required=false)]
        public string ServerFilterStrategy { get; set; }

    }

}
