// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClearLogstoreStorageRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserLogStore")]
        [Validation(Required=false)]
        public string UserLogStore { get; set; }

        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
