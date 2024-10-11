// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeBpsDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeBpsDataResponseBodyData : TeaModel {
            [NameInMap("BpsModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeBpsDataResponseBodyDataBpsModel> BpsModel { get; set; }
            public class DescribeVodDomainRealTimeBpsDataResponseBodyDataBpsModel : TeaModel {
                /// <summary>
                /// <para>The bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16710625.733333332</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-30T05:41:00Z</para>
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
        /// <para>B49E6DDA-F413-422B-B58E-2FA23F286726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
