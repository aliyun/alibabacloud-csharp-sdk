// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckQuaraFileIdRequest : TeaModel {
        [NameInMap("QuaraFileIds")]
        [Validation(Required=false)]
        public List<string> QuaraFileIds { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
