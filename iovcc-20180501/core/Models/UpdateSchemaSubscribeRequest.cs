// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateSchemaSubscribeRequest : TeaModel {
        [NameInMap("DeviceModel")]
        [Validation(Required=false)]
        public string DeviceModel { get; set; }

        [NameInMap("SubscribeList")]
        [Validation(Required=false)]
        public string SubscribeList { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SchemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

    }

}
