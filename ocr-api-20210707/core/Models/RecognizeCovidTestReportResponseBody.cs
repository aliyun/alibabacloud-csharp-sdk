// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeCovidTestReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>noPermission</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;data&quot;: {&quot;name&quot;: &quot;张德周&quot;, &quot;idNumber&quot;: &quot;612401<b><b><b><b>22010&quot;, &quot;samplingDate&quot;: &quot;2022-03-30&quot;, &quot;samplingTime&quot;: &quot;330&quot;, &quot;testOrganization&quot;: &quot;&quot;, &quot;testItem&quot;: &quot;&quot;, &quot;testResult&quot;: &quot;&quot;}, &quot;ftype&quot;: 0, &quot;height&quot;: 991, &quot;orgHeight&quot;: 998, &quot;orgWidth&quot;: 1076, &quot;prism_keyValueInfo&quot;: [{&quot;key&quot;: &quot;name&quot;, &quot;keyProb&quot;: 100, &quot;value&quot;: &quot;张德周&quot;, &quot;valuePos&quot;: [{&quot;x&quot;: 291, &quot;y&quot;: 465}, {&quot;x&quot;: 473, &quot;y&quot;: 463}, {&quot;x&quot;: 474, &quot;y&quot;: 526}, {&quot;x&quot;: 291, &quot;y&quot;: 527}], &quot;valueProb&quot;: 100}, {&quot;key&quot;: &quot;idNumber&quot;, &quot;keyProb&quot;: 91, &quot;value&quot;: &quot;612401</b></b></b></b>22010&quot;, &quot;valuePos&quot;: [{&quot;x&quot;: 791, &quot;y&quot;: 180}, {&quot;x&quot;: 791, &quot;y&quot;: 227}, {&quot;x&quot;: 300, &quot;y&quot;: 226}, {&quot;x&quot;: 300, &quot;y&quot;: 179}], &quot;valueProb&quot;: 91}, {&quot;key&quot;: &quot;samplingDate&quot;, &quot;keyProb&quot;: 100, &quot;value&quot;: &quot;2022-03-30&quot;, &quot;valuePos&quot;: [{&quot;x&quot;: 597, &quot;y&quot;: 775}, {&quot;x&quot;: 597, &quot;y&quot;: 826}, {&quot;x&quot;: 296, &quot;y&quot;: 826}, {&quot;x&quot;: 296, &quot;y&quot;: 775}], &quot;valueProb&quot;: 100}, {&quot;key&quot;: &quot;samplingTime&quot;, &quot;keyProb&quot;: 100, &quot;value&quot;: &quot;330&quot;, &quot;valuePos&quot;: [{&quot;x&quot;: 412, &quot;y&quot;: 684}, {&quot;x&quot;: 413, &quot;y&quot;: 741}, {&quot;x&quot;: 268, &quot;y&quot;: 742}, {&quot;x&quot;: 268, &quot;y&quot;: 686}], &quot;valueProb&quot;: 100}, {&quot;key&quot;: &quot;testOrganization&quot;, &quot;keyProb&quot;: 100, &quot;value&quot;: &quot;&quot;, &quot;valueProb&quot;: 100}, {&quot;key&quot;: &quot;testItem&quot;, &quot;keyProb&quot;: 100, &quot;value&quot;: &quot;&quot;, &quot;valueProb&quot;: 100}, {&quot;key&quot;: &quot;testResult&quot;, &quot;keyProb&quot;: 28, &quot;value&quot;: &quot;&quot;, &quot;valuePos&quot;: [{&quot;x&quot;: 417, &quot;y&quot;: 873}, {&quot;x&quot;: 417, &quot;y&quot;: 941}, {&quot;x&quot;: 298, &quot;y&quot;: 941}, {&quot;x&quot;: 298, &quot;y&quot;: 873}], &quot;valueProb&quot;: 28}], &quot;sliceRect&quot;: {&quot;x0&quot;: 0, &quot;y0&quot;: 10, &quot;x1&quot;: 1076, &quot;y1&quot;: 6, &quot;x2&quot;: 1076, &quot;y2&quot;: 995, &quot;x3&quot;: 0, &quot;y3&quot;: 996}, &quot;width&quot;: 1076}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
