// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetLoginPreferenceResponseBody : TeaModel {
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyLoginPreference LoginPreference { get; set; }
        public class GetLoginPreferenceResponseBodyLoginPreference : TeaModel {
            [NameInMap("LoginNetworkMasks")]
            [Validation(Required=false)]
            public string LoginNetworkMasks { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
