// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SkewedInfo : TeaModel {
        [NameInMap("SkewedColNames")]
        [Validation(Required=false)]
        public List<string> SkewedColNames { get; set; }

        [NameInMap("SkewedColValueLocationMaps")]
        [Validation(Required=false)]
        public Dictionary<string, string> SkewedColValueLocationMaps { get; set; }

        [NameInMap("SkewedColValues")]
        [Validation(Required=false)]
        public List<List<string>> SkewedColValues { get; set; }

    }

}
