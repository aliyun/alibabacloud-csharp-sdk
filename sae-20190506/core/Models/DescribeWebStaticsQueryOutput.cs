// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeWebStaticsQueryOutput : TeaModel {
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("WebStatics")]
        [Validation(Required=false)]
        public List<WebStaticsInfo> WebStatics { get; set; }

    }

}
