// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class UpdateAccountPasswordRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("IsShort")]
        [Validation(Required=false)]
        public bool? IsShort { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("EnableKMS")]
        [Validation(Required=false)]
        public bool? EnableKMS { get; set; }

        [NameInMap("UseRandomPassword")]
        [Validation(Required=false)]
        public bool? UseRandomPassword { get; set; }

    }

}
