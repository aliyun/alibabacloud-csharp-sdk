// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRangeDataByLocateAndIspServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result. The value is in the JSON format. These parameters indicate the following information in sequence: UNIX time, region, ISP, distribution of HTTP status codes, response time, bandwidth (bit/s), average response rate, page views, cache hit ratio, and request hit ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;1472659200&quot;:{&quot;tianjin&quot;:{&quot;unicom&quot;:{&quot;http_codes&quot;:{&quot;000&quot;:0,&quot;200&quot;:6,&quot;400&quot;:0},&quot;rt&quot;:4183,&quot;bandwidth&quot;:46639,&quot;avg_speed&quot;:7773,&quot;pv&quot;:6,&quot;hit_rate&quot;:0.93,&quot;request_hit_rate&quot;:0.66}}}}</para>
        /// </summary>
        [NameInMap("JsonResult")]
        [Validation(Required=false)]
        public string JsonResult { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C74802AA-C277-5A80-BDF2-072B05F119C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
