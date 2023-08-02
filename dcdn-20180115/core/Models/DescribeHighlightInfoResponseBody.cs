// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeHighlightInfoResponseBody : TeaModel {
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeHighlightInfoResponseBodyDataModule> DataModule { get; set; }
        public class DescribeHighlightInfoResponseBodyDataModule : TeaModel {
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Raw")]
            [Validation(Required=false)]
            public string Raw { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
