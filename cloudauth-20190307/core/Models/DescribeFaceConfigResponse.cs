// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeFaceConfigResponseItems> Items { get; set; }
        public class DescribeFaceConfigResponseItems : TeaModel {
            [NameInMap("BizName")]
            [Validation(Required=true)]
            public string BizName { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("GmtUpdated")]
            [Validation(Required=true)]
            public long? GmtUpdated { get; set; }

        }

    }

}
