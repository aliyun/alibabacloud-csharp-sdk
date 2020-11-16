// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAsrConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveAsrConfig")]
        [Validation(Required=true)]
        public DescribeLiveAsrConfigResponseLiveAsrConfig LiveAsrConfig { get; set; }
        public class DescribeLiveAsrConfigResponseLiveAsrConfig : TeaModel {
            [NameInMap("LiveAsrConfigList")]
            [Validation(Required=true)]
            public List<DescribeLiveAsrConfigResponseLiveAsrConfigLiveAsrConfigList> LiveAsrConfigList { get; set; }
            public class DescribeLiveAsrConfigResponseLiveAsrConfigLiveAsrConfigList : TeaModel {
                public int? DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public int? Period { get; set; }
                public string MnsTopic { get; set; }
                public string MnsRegion { get; set; }
                public string HttpCallbackURL { get; set; }
            }
        };

    }

}
