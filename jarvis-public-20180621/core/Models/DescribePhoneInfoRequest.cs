// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribePhoneInfoRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("phoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        [NameInMap("sourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

    }

}
