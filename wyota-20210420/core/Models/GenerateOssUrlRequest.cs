// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GenerateOssUrlRequest : TeaModel {
        [NameInMap("ObjectNameList")]
        [Validation(Required=false)]
        public List<string> ObjectNameList { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
