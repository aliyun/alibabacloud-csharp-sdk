// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ParseKeywordsResponseBody : TeaModel {
        [NameInMap("address_line")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<SystemTag> Tags { get; set; }

        [NameInMap("time_range")]
        [Validation(Required=false)]
        public ParseKeywordsResponseBodyTimeRange TimeRange { get; set; }
        public class ParseKeywordsResponseBodyTimeRange : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

    }

}
