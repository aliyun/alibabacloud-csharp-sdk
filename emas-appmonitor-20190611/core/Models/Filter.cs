// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class Filter : TeaModel {
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("SubFilters")]
        [Validation(Required=false)]
        public List<Filter> SubFilters { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public object Values { get; set; }

    }

}
