// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ModifyDatabaseInstanceDescriptionRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DatabaseInstanceDescription")]
        [Validation(Required=false)]
        public string DatabaseInstanceDescription { get; set; }

        [NameInMap("DatabaseInstanceId")]
        [Validation(Required=false)]
        public string DatabaseInstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
