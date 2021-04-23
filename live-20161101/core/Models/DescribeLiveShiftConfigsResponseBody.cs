// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveShiftConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeLiveShiftConfigsResponseBodyContent Content { get; set; }
        public class DescribeLiveShiftConfigsResponseBodyContent : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<DescribeLiveShiftConfigsResponseBodyContentConfig> Config { get; set; }
            public class DescribeLiveShiftConfigsResponseBodyContentConfig : TeaModel {
                public string AppName { get; set; }
                public int? Vision { get; set; }
                public string StreamName { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
