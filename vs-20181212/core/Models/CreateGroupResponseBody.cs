// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateGroupResponseBody : TeaModel {
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        [NameInMap("GbIp")]
        [Validation(Required=false)]
        public string GbIp { get; set; }

        [NameInMap("GbPort")]
        [Validation(Required=false)]
        public long? GbPort { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
