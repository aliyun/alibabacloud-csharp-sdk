// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeQpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeVodDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                /// <summary>
                /// <para>The number of queries per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1851.25</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data. The time follows the ISO 8601 standard. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-02T11:25:00Z</para>
                /// </summary>
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
