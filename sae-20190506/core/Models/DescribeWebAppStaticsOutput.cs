// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeWebAppStaticsOutput : TeaModel {
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("WebAppStatics")]
        [Validation(Required=false)]
        public List<WebStaticsInfo> WebAppStatics { get; set; }

    }

}
