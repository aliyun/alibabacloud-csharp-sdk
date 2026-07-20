// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUrlObservationDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time for the data query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
        /// <para>The start time. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("UrlDetailData")]
        [Validation(Required=false)]
        public List<DescribeUrlObservationDataResponseBodyUrlDetailData> UrlDetailData { get; set; }
        public class DescribeUrlObservationDataResponseBodyUrlDetailData : TeaModel {
            /// <summary>
            /// <para>The metric that measures the largest burst of layout shift scores for every unexpected layout shift that occurs throughout the entire lifecycle of a page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CLS")]
            [Validation(Required=false)]
            public float? CLS { get; set; }

            /// <summary>
            /// <para>The device platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PC</para>
            /// </summary>
            [NameInMap("ClientPlatform")]
            [Validation(Required=false)]
            public string ClientPlatform { get; set; }

            /// <summary>
            /// <para>The country.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The time from when the page starts loading to when any part of the page content is rendered on the screen. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FCP")]
            [Validation(Required=false)]
            public float? FCP { get; set; }

            /// <summary>
            /// <para>The time from when a user first interacts with a page to when the browser is actually able to begin processing event handlers in response to that interaction. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FID")]
            [Validation(Required=false)]
            public float? FID { get; set; }

            /// <summary>
            /// <para>The responsiveness of a page, specifically how long it takes for the page to visibly respond to user input. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("INP")]
            [Validation(Required=false)]
            public float? INP { get; set; }

            /// <summary>
            /// <para>The render time of the largest image or text block visible within the viewport. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("LCP")]
            [Validation(Required=false)]
            public float? LCP { get; set; }

            /// <summary>
            /// <para>The time from when a resource request is initiated to when the first byte of the response begins to arrive. Unit: ms.</para>
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
