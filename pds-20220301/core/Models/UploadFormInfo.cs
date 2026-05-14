// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UploadFormInfo : TeaModel {
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("form_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> FormData { get; set; }

    }

}
