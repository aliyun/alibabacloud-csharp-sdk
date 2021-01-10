// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutUserproductRequest : TeaModel {
        [NameInMap("UserEmpId")]
        [Validation(Required=false)]
        public string UserEmpId { get; set; }

        [NameInMap("UserProductInfosRepeatList")]
        [Validation(Required=false)]
        public List<string> UserProductInfosRepeatList { get; set; }

    }

}
