// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebTrafficConfig : TeaModel {
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("DisableInternetURL")]
        [Validation(Required=false)]
        public bool? DisableInternetURL { get; set; }

        [NameInMap("RevisionsTrafficWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> RevisionsTrafficWeight { get; set; }

        [NameInMap("WebAclConfig")]
        [Validation(Required=false)]
        public WebAclConfig WebAclConfig { get; set; }

    }

}
