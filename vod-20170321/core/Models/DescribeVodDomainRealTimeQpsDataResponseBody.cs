// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeQpsDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DC9806-E9F9-4490-BBDC-B3A9E32FCC1D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
