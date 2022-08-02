// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RefererConfiguration : TeaModel {
        [NameInMap("AllowEmptyReferer")]
        [Validation(Required=false)]
        public bool? AllowEmptyReferer { get; set; }

        [NameInMap("AllowTruncateQueryString")]
        [Validation(Required=false)]
        public bool? AllowTruncateQueryString { get; set; }

        [NameInMap("RefererList")]
        [Validation(Required=false)]
        public RefererConfigurationRefererList RefererList { get; set; }
        public class RefererConfigurationRefererList : TeaModel {
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }
        };

    }

}
