// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreatePropertyRequest : TeaModel {
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<string> PropertyValues { get; set; }

    }

}
