// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20211130.Models
{
    public class CreateYydComputeTaskRequest : TeaModel {
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

    }

}
