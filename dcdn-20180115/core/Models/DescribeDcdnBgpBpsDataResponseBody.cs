// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBgpBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The BGP bandwidth data that is collected for each interval.</para>
        /// </summary>
        [NameInMap("BgpDataInterval")]
        [Validation(Required=false)]
        public List<DescribeDcdnBgpBpsDataResponseBodyBgpDataInterval> BgpDataInterval { get; set; }
        public class DescribeDcdnBgpBpsDataResponseBodyBgpDataInterval : TeaModel {
            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>318</para>
            /// </summary>
            [NameInMap("In")]
            [Validation(Required=false)]
            public float? In { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183</para>
            /// </summary>
            [NameInMap("Out")]
            [Validation(Required=false)]
            public float? Out { get; set; }

            /// <summary>
            /// <para>The timestamp of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-29T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-11-30T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9D3257A-1B7C-414C-90C1-8D07AC47BCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-11-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
