// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMessageAppRequest : TeaModel {
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> AppConfig { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

    }

}
