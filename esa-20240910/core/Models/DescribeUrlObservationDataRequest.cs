// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeUrlObservationDataRequest : TeaModel {
        /// <summary>
        /// <para>The platform of the device. If the parameter is left empty, all devices are queried.</para>
        /// <list type="bullet">
        /// <item><description>PC</description></item>
        /// <item><description>Mobile</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("ClientPlatform")]
        [Validation(Required=false)]
        public string ClientPlatform { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-19T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric data that is detected.</para>
        /// <list type="bullet">
        /// <item><description>TTFB: Measures the time between when a resource initiates a request and when the first byte of the response starts to arrive.</description></item>
        /// <item><description>FCP: Measures the time between when the page is loaded and when any part of the page\&quot;s content is rendered on the screen.</description></item>
        /// <item><description>LCP: Reports the rendering time of the largest image or text block visible in the viewport.</description></item>
        /// <item><description>CLS: A metric that measures the maximum layout mutation score for every unexpected layout change that occurs throughout the life of the page.</description></item>
        /// <item><description>INP: Measures the responsiveness of the page, or how long it takes for the page to respond to user input in a visible way.</description></item>
        /// <item><description>FID: Measures the time between when the user first interacts with the page and when the browser is actually able to start processing the event handler in response to that interaction.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TTFB</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
