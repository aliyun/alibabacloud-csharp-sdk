// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Location : TeaModel {
        [NameInMap("LocationType")]
        [Validation(Required=false)]
        public string LocationType { get; set; }

        [NameInMap("LocationValue")]
        [Validation(Required=false)]
        public Dictionary<string, object> LocationValue { get; set; }

    }

}
