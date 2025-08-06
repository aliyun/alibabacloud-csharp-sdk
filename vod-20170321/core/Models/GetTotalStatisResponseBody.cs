// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTotalStatisResponseBody : TeaModel {
        [NameInMap("NetworkOut")]
        [Validation(Required=false)]
        public long? NetworkOut { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageUtilization")]
        [Validation(Required=false)]
        public long? StorageUtilization { get; set; }

        [NameInMap("TranscodeDuration")]
        [Validation(Required=false)]
        public long? TranscodeDuration { get; set; }

    }

}
