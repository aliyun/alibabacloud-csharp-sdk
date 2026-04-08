// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkConfigSearchEngine : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("contentMode")]
        [Validation(Required=false)]
        public string ContentMode { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("optionArgs")]
        [Validation(Required=false)]
        public Dictionary<string, string> OptionArgs { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

        [NameInMap("timeoutMillisecond")]
        [Validation(Required=false)]
        public int? TimeoutMillisecond { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
