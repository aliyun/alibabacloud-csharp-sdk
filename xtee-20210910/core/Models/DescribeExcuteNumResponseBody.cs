// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExcuteNumResponseBody : TeaModel {
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<string> Data { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
