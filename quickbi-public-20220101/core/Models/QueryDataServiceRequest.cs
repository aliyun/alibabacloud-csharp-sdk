// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceRequest : TeaModel {
        /// <summary>
        /// <para>Call an API that is created in DataService Studio.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <h1>Prerequisites</h1>
        /// <para>You can use the Quick BI data service to create an API for the data service. For more information, see <a href="https://help.aliyun.com/document_detail/144980.html">Data service</a>.</para>
        /// <h1>Limits</h1>
        /// <list type="bullet">
        /// <item><description>The Data Service feature is available only to Professional customers.</description></item>
        /// <item><description>The timeout period for API calls is 60s. The QPS of a single API is 10 times per second.</description></item>
        /// <item><description>If row-level permissions are enabled for datasets that are referenced by a Data Service API, the API may be blocked by row-level permission policies.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>For more information about API IDs in DataService, see <a href="https://help.aliyun.com/document_detail/144980.html">Data Service</a>.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The query conditions of the data service. The query conditions are specified in the form of keys and values. A string of the map type. Key is the name of the request parameters parameter, and Value is the value of the request parameters parameter. Key and Value must appear in pairs.</para>
        /// <para><b>Note:</b></para>
        /// <list type="bullet">
        /// <item><description><para>If a value contains multiple values, the value is a List in the JSON format. Example: <c>area=[&quot;East China&quot;,&quot;North China&quot;,&quot;South China&quot;]</c></para>
        /// </description></item>
        /// <item><description><para>For dates, different input parameter formats are provided based on different types:</para>
        /// <list type="bullet">
        /// <item><description>Year: 2019</description></item>
        /// <item><description>Season: 2019Q1</description></item>
        /// <item><description>Month: 201901 (carry 0)</description></item>
        /// <item><description>Week: 2019-52</description></item>
        /// <item><description>Day: 20190101</description></item>
        /// <item><description>Hours: 14:00:00 (minutes and seconds are 00)</description></item>
        /// <item><description>Minutes: 14:12:00 (seconds are 00)</description></item>
        /// <item><description>Seconds: 14:34:34</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

    }

}
