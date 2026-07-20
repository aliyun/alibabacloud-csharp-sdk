// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUrlObservationDataRequest : TeaModel {
        /// <summary>
        /// <para>The device platform. If this parameter is left empty, data for all platforms is queried.</para>
        /// <list type="bullet">
        /// <item><description><para>PC</para>
        /// </description></item>
        /// <item><description><para>Mobile</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("ClientPlatform")]
        [Validation(Required=false)]
        public string ClientPlatform { get; set; }

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
        /// <para>The metric to query.</para>
        /// <list type="bullet">
        /// <item><description>TTFB: Measures the time from when a resource request is initiated to when the first byte of the response begins to arrive.</description></item>
        /// <item><description>FCP: Measures the time from when the page starts loading to when any part of the page content is rendered on the screen.</description></item>
        /// <item><description>LCP: Reports the render time of the largest image or text block visible within the viewport.</description></item>
        /// <item><description>CLS: A metric that measures the largest burst of layout shift scores for every unexpected layout shift that occurs throughout the entire lifecycle of a page.</description></item>
        /// <item><description>INP: Measures the responsiveness of a page, specifically how long it takes for the page to visibly respond to user input.</description></item>
        /// <item><description>FID: Measures the time from when a user first interacts with a page to when the browser is actually able to begin processing event handlers in response to that interaction.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TTFB</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The start time for the data query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

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
