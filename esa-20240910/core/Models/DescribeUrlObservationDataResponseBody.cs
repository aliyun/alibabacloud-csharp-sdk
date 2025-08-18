// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUrlObservationDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-19T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UrlDetailData")]
        [Validation(Required=false)]
        public List<DescribeUrlObservationDataResponseBodyUrlDetailData> UrlDetailData { get; set; }
        public class DescribeUrlObservationDataResponseBodyUrlDetailData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CLS")]
            [Validation(Required=false)]
            public float? CLS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PC</para>
            /// </summary>
            [NameInMap("ClientPlatform")]
            [Validation(Required=false)]
            public string ClientPlatform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FCP")]
            [Validation(Required=false)]
            public float? FCP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FID")]
            [Validation(Required=false)]
            public float? FID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("INP")]
            [Validation(Required=false)]
            public float? INP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("LCP")]
            [Validation(Required=false)]
            public float? LCP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TTFB")]
            [Validation(Required=false)]
            public float? TTFB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com/test</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
