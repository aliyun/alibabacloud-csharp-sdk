// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetUserLoginInfoRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountPrincipalName")]
        [Validation(Required=false)]
        public string AccountPrincipalName { get; set; }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("CurrentPk")]
        [Validation(Required=false)]
        public string CurrentPk { get; set; }

        [NameInMap("MainAccountPk")]
        [Validation(Required=false)]
        public string MainAccountPk { get; set; }

    }

}
