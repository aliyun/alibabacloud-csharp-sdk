// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresRequest : TeaModel {
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

    }

}
