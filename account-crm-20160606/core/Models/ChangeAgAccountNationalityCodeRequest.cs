// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class ChangeAgAccountNationalityCodeRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Mpk")]
        [Validation(Required=false)]
        public string Mpk { get; set; }

        [NameInMap("NationalityCode")]
        [Validation(Required=false)]
        public string NationalityCode { get; set; }

        [NameInMap("PK")]
        [Validation(Required=false)]
        public string PK { get; set; }

    }

}
