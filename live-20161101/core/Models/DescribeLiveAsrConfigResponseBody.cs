// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAsrConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveAsrConfig")]
        [Validation(Required=false)]
        public DescribeLiveAsrConfigResponseBodyLiveAsrConfig LiveAsrConfig { get; set; }
        public class DescribeLiveAsrConfigResponseBodyLiveAsrConfig : TeaModel {
            [NameInMap("LiveAsrConfigList")]
            [Validation(Required=false)]
            public List<DescribeLiveAsrConfigResponseBodyLiveAsrConfigLiveAsrConfigList> LiveAsrConfigList { get; set; }
            public class DescribeLiveAsrConfigResponseBodyLiveAsrConfigLiveAsrConfigList : TeaModel {
                public string AppName { get; set; }
                public string MnsRegion { get; set; }
                public string StreamName { get; set; }
                public string HttpCallbackURL { get; set; }
                public int? DomainName { get; set; }
                public int? Period { get; set; }
                public string MnsTopic { get; set; }
            }
        };

    }

}
