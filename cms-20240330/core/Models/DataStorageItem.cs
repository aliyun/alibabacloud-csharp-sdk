// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DataStorageItem : TeaModel {
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("storeName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
