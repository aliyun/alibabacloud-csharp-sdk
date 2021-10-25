// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricProfilingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SvgUrls")]
        [Validation(Required=false)]
        public GetCloudMetricProfilingResponseBodySvgUrls SvgUrls { get; set; }
        public class GetCloudMetricProfilingResponseBodySvgUrls : TeaModel {
            [NameInMap("SvgInfo")]
            [Validation(Required=false)]
            public List<GetCloudMetricProfilingResponseBodySvgUrlsSvgInfo> SvgInfo { get; set; }
            public class GetCloudMetricProfilingResponseBodySvgUrlsSvgInfo : TeaModel {
                public string Type { get; set; }
                public string Url { get; set; }
                public string Name { get; set; }
                public int? Size { get; set; }
            }
        };

    }

}
