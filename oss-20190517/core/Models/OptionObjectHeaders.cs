// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class OptionObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("Access-Control-Request-Headers")]
        [Validation(Required=false)]
        public string AccessControlRequestHeaders { get; set; }

        [NameInMap("Access-Control-Request-Method")]
        [Validation(Required=false)]
        public string AccessControlRequestMethod { get; set; }

        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

    }

}
