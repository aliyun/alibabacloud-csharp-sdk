// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLSkewedInfo : TeaModel {
        [NameInMap("SkewedColNames")]
        [Validation(Required=false)]
        public List<string> SkewedColNames { get; set; }

        [NameInMap("SkewedColValueLocationMaps")]
        [Validation(Required=false)]
        public Dictionary<string, object> SkewedColValueLocationMaps { get; set; }

        [NameInMap("SkewedColValues")]
        [Validation(Required=false)]
        public List<List<string>> SkewedColValues { get; set; }

    }

}
