// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricProfilingResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of profiling results.
        /// </summary>
        [NameInMap("SvgUrls")]
        [Validation(Required=false)]
        public GetCloudMetricProfilingResponseBodySvgUrls SvgUrls { get; set; }
        public class GetCloudMetricProfilingResponseBodySvgUrls : TeaModel {
            [NameInMap("SvgInfo")]
            [Validation(Required=false)]
            public List<GetCloudMetricProfilingResponseBodySvgUrlsSvgInfo> SvgInfo { get; set; }
            public class GetCloudMetricProfilingResponseBodySvgUrlsSvgInfo : TeaModel {
                /// <summary>
                /// The name of the SVG file that contains the profiling results.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The size of the SVG file. Unit: bytes.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The type of the SVG file.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The URL of the Object Storage Service (OSS) bucket where the scalable vector graphics (SVG) file is stored.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
