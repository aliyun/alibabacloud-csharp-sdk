// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class ListUninstallDetailRequest : TeaModel {
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("endDs")]
        [Validation(Required=false)]
        public string EndDs { get; set; }

        [NameInMap("startDs")]
        [Validation(Required=false)]
        public string StartDs { get; set; }

    }

}
