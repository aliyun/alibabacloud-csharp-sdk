// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ForeignInstanceCredInfo : TeaModel {
        [NameInMap("CredInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> CredInfo { get; set; }

        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

    }

}
