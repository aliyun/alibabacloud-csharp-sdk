// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutUsergetbyaccountlistRequest : TeaModel {
        [NameInMap("AccountListRepeatList")]
        [Validation(Required=false)]
        public List<string> AccountListRepeatList { get; set; }

        [NameInMap("TenantPath")]
        [Validation(Required=false)]
        public string TenantPath { get; set; }

    }

}
