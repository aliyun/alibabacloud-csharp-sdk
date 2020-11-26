// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeSdkUrlRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=true)]
        public long Id { get; set; }

        [NameInMap("Debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

    }

}
