// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeFaceConfigResponseBodyItems> Items { get; set; }
        public class DescribeFaceConfigResponseBodyItems : TeaModel {
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("GmtUpdated")]
            [Validation(Required=false)]
            public long? GmtUpdated { get; set; }

        }

    }

}
