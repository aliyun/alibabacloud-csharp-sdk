// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AppAccessStrategy : TeaModel {
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("except_app_id_list")]
        [Validation(Required=false)]
        public List<string> ExceptAppIdList { get; set; }

    }

}
