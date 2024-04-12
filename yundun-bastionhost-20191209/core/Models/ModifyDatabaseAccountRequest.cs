// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyDatabaseAccountRequest : TeaModel {
        [NameInMap("DatabaseAccountId")]
        [Validation(Required=false)]
        public string DatabaseAccountId { get; set; }

        [NameInMap("DatabaseAccountName")]
        [Validation(Required=false)]
        public string DatabaseAccountName { get; set; }

        [NameInMap("DatabaseSchema")]
        [Validation(Required=false)]
        public string DatabaseSchema { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
