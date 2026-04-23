// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserAvgResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C7F90B2-BDA4-4FAC-****-A38A121DFE19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserPlayStatisAvgs")]
        [Validation(Required=false)]
        public DescribePlayUserAvgResponseBodyUserPlayStatisAvgs UserPlayStatisAvgs { get; set; }
        public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgs : TeaModel {
            [NameInMap("UserPlayStatisAvg")]
            [Validation(Required=false)]
            public List<DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg> UserPlayStatisAvg { get; set; }
            public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg : TeaModel {
                [NameInMap("AvgPlayCount")]
                [Validation(Required=false)]
                public string AvgPlayCount { get; set; }

                [NameInMap("AvgPlayDuration")]
                [Validation(Required=false)]
                public string AvgPlayDuration { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

            }

        }

    }

}
