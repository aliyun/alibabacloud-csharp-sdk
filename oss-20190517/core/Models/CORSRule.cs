// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CORSRule : TeaModel {
        [NameInMap("AllowedHeader")]
        [Validation(Required=false)]
        public string AllowedHeader { get; set; }

        [NameInMap("AllowedMethod")]
        [Validation(Required=false)]
        public List<string> AllowedMethod { get; set; }

        [NameInMap("AllowedOrigin")]
        [Validation(Required=false)]
        public List<string> AllowedOrigin { get; set; }

        [NameInMap("ExposeHeader")]
        [Validation(Required=false)]
        public List<string> ExposeHeader { get; set; }

        [NameInMap("MaxAgeSeconds")]
        [Validation(Required=false)]
        public long? MaxAgeSeconds { get; set; }

    }

}
