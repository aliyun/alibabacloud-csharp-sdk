// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceIspsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceIspsResponseBodyIsps> Isps { get; set; }
        public class DescribePortViewSourceIspsResponseBodyIsps : TeaModel {
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
