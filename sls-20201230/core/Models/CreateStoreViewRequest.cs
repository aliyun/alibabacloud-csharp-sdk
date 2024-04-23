// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateStoreViewRequest : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<StoreViewStore> Stores { get; set; }

    }

}
