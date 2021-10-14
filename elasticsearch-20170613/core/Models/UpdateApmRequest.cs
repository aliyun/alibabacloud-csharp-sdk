// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateApmRequest : TeaModel {
        [NameInMap("outputES")]
        [Validation(Required=false)]
        public string OutputES { get; set; }

        [NameInMap("outputESPassword")]
        [Validation(Required=false)]
        public string OutputESPassword { get; set; }

        [NameInMap("outputESUserName")]
        [Validation(Required=false)]
        public string OutputESUserName { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("yml")]
        [Validation(Required=false)]
        public string Yml { get; set; }

    }

}
