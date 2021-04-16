// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCityMapAoisRequest : TeaModel {
        [NameInMap("Radius")]
        [Validation(Required=false)]
        public int? Radius { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

    }

}
