// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUrlObservationDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-19T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The create time. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The objects that are returned.</para>
        /// </summary>
        [NameInMap("UrlDetailData")]
        [Validation(Required=false)]
        public List<DescribeUrlObservationDataResponseBodyUrlDetailData> UrlDetailData { get; set; }
        public class DescribeUrlObservationDataResponseBodyUrlDetailData : TeaModel {
            /// <summary>
            /// <para>Measures the maximum layout mutation score for every unexpected layout change that occurs throughout the life of the page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CLS")]
            [Validation(Required=false)]
            public float? CLS { get; set; }

            /// <summary>
            /// <para>The platform of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PC</para>
            /// </summary>
            [NameInMap("ClientPlatform")]
            [Validation(Required=false)]
            public string ClientPlatform { get; set; }

            /// <summary>
            /// <para>The country or region to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>Measures the time between when the page is loaded and when any part of the page\&quot;s content is rendered on the screen. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FCP")]
            [Validation(Required=false)]
            public float? FCP { get; set; }

            /// <summary>
            /// <para>Measures the time between when the user first interacts with the page and when the browser is actually able to start processing an event handler in response to that interaction. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FID")]
            [Validation(Required=false)]
            public float? FID { get; set; }

            /// <summary>
            /// <para>Measures the responsiveness of the page, or how long it takes for the page to respond to user input visibly. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("INP")]
            [Validation(Required=false)]
            public float? INP { get; set; }

            /// <summary>
            /// <para>Reports the rendering time of the largest image or text block visible in the viewport. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("LCP")]
            [Validation(Required=false)]
            public float? LCP { get; set; }

            /// <summary>
            /// <para>This metric measures the time between when a resource initiates a request and when the first byte of the response starts to arrive. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TTFB")]
            [Validation(Required=false)]
            public float? TTFB { get; set; }

            /// <summary>
            /// <para>The URL of the web page to monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/test</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
