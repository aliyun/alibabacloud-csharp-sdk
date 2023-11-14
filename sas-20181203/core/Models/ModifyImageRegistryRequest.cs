// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyImageRegistryRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
