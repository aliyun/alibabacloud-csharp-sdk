// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListUserCustomLogConfigResponseBody : TeaModel {
        [NameInMap("ConfigIds")]
        [Validation(Required=false)]
        public ListUserCustomLogConfigResponseBodyConfigIds ConfigIds { get; set; }
        public class ListUserCustomLogConfigResponseBodyConfigIds : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public List<string> ConfigId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
