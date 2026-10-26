// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceRequest : TeaModel {
        /// <summary>
        /// <para>The API ID in the data service. For more information, see <a href="https://help.aliyun.com/document_detail/144980.html">Data Service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The query conditions for the data service, passed in as Key-Value pairs. This is a map-type string. Here, Key is the name of the request parameter, and Value is the value of the request parameter. Keys and Values must appear in pairs.</para>
        /// <para><b>Note:</b></para>
        /// <list type="bullet">
        /// <item><description><para>When the operator of the request parameter is set to <b>enumeration filter</b>, the value can contain multiple values. In this case, the format of the value is a JSON list. For example: <c>area=[&quot;East China&quot;,&quot;North China&quot;,&quot;South China&quot;]</c>     </para>
        /// </description></item>
        /// <item><description><para>For dates, different formats are provided based on the type:</para>
        /// <list type="bullet">
        /// <item><description><para>Year: 2019</para>
        /// </description></item>
        /// <item><description><para>Quarter: 2019Q1</para>
        /// </description></item>
        /// <item><description><para>Month: 201901 (with leading zero)</para>
        /// </description></item>
        /// <item><description><para>Week: 2019-52</para>
        /// </description></item>
        /// <item><description><para>Day: 20190101</para>
        /// </description></item>
        /// <item><description><para>Hour: 14:00:00 (minutes and seconds are 00)</para>
        /// </description></item>
        /// <item><description><para>Minute: 14:12:00 (seconds are 00)</para>
        /// </description></item>
        /// <item><description><para>Second: 14:34:34</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;area&quot;: [&quot;asdf&quot;, &quot;west&quot;],  &quot;shopping_date&quot;: &quot;2019Q1&quot;,  }</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>A list of parameter names to be returned, as a List-type string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

    }

}
