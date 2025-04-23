// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricProfilingResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DD6F715-85EE-4EA6-BDC4-48A75B719068</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of profiling results.</para>
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
                /// <para>The name of the SVG file that contains the profiling results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-hz-faRavbPf6b_i-bdrftgyh890654****_21687_2019-09-09-02-37-40.bottomup.svg</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the SVG file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>648</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The type of the SVG file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL of the Object Storage Service (OSS) bucket where the scalable vector graphics (SVG) file is stored.</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
