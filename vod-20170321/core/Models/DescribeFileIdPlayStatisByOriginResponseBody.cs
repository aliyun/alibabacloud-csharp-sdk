// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeFileIdPlayStatisByOriginResponseBody : TeaModel {
        [NameInMap("FilePlayStatisList")]
        [Validation(Required=false)]
        public List<DescribeFileIdPlayStatisByOriginResponseBodyFilePlayStatisList> FilePlayStatisList { get; set; }
        public class DescribeFileIdPlayStatisByOriginResponseBodyFilePlayStatisList : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("Flux")]
            [Validation(Required=false)]
            public long? Flux { get; set; }

            [NameInMap("PlayCount")]
            [Validation(Required=false)]
            public long? PlayCount { get; set; }

            [NameInMap("RequestCount")]
            [Validation(Required=false)]
            public long? RequestCount { get; set; }

            [NameInMap("StatisTime")]
            [Validation(Required=false)]
            public string StatisTime { get; set; }

        }

        [NameInMap("HasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScrollToken")]
        [Validation(Required=false)]
        public string ScrollToken { get; set; }

    }

}
