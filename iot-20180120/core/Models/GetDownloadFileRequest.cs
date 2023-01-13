// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDownloadFileRequest : TeaModel {
        [NameInMap("Context")]
        [Validation(Required=false)]
        public Dictionary<string, object> Context { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("LongJobId")]
        [Validation(Required=true)]
        public string LongJobId { get; set; }

    }

}
