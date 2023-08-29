// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdateRegisteredLocationRequest : TeaModel {
        [NameInMap("InventoryCollectEnabled")]
        [Validation(Required=false)]
        public bool? InventoryCollectEnabled { get; set; }

        [NameInMap("LocationId")]
        [Validation(Required=false)]
        public string LocationId { get; set; }

        [NameInMap("OssLogCollectEnabled")]
        [Validation(Required=false)]
        public bool? OssLogCollectEnabled { get; set; }

    }

}
