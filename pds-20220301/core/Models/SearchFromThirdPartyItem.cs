// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchFromThirdPartyItem : TeaModel {
        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("others")]
        [Validation(Required=false)]
        public Dictionary<string, object> Others { get; set; }

    }

}
