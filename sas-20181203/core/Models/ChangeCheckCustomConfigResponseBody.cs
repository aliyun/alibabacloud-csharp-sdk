// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigResponseBody : TeaModel {
        [NameInMap("IllegalCustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs> IllegalCustomConfigs { get; set; }
        public class ChangeCheckCustomConfigResponseBodyIllegalCustomConfigs : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
