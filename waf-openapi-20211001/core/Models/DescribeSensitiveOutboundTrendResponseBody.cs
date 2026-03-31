// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveOutboundTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The information records involved in cross-border data transfer.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveOutboundTrendResponseBodyData> Data { get; set; }
        public class DescribeSensitiveOutboundTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of personal information records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>672</para>
            /// </summary>
            [NameInMap("InfoCount")]
            [Validation(Required=false)]
            public long? InfoCount { get; set; }

            /// <summary>
            /// <para>The total number of personal information records involved in cross-border data transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>541</para>
            /// </summary>
            [NameInMap("InfoOutboundCount")]
            [Validation(Required=false)]
            public long? InfoOutboundCount { get; set; }

            /// <summary>
            /// <para>The total number of sensitive information records involved in cross-border data transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>378</para>
            /// </summary>
            [NameInMap("SensitiveOutboundCount")]
            [Validation(Required=false)]
            public long? SensitiveOutboundCount { get; set; }

            /// <summary>
            /// <para>The time of cross-border data transfer. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672502400</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1823E96-EF4B-5BD2-9E02-1D18****3ED8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
