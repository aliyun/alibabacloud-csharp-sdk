// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Stores : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("project")]
        [Validation(Required=false)]
        [Obsolete]
        public string Project { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        [NameInMap("store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
