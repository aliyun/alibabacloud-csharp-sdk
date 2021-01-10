// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetLinkeBahamutWriteflagRequest : TeaModel {
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        [NameInMap("ConfigVal")]
        [Validation(Required=false)]
        public string ConfigVal { get; set; }

        [NameInMap("KeyColumn")]
        [Validation(Required=false)]
        public string KeyColumn { get; set; }

        [NameInMap("KeyVal")]
        [Validation(Required=false)]
        public string KeyVal { get; set; }

    }

}
