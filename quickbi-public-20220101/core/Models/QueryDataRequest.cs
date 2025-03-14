// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRequest : TeaModel {
        /// <summary>
        /// <para>The API ID in the data service. For more information, see: <a href="https://help.aliyun.com/document_detail/144980.html">Data Service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The query conditions for the data service, passed in as Key and Value pairs. A map-type string. Here, Key is the name of the request parameter, and Value is the value of the request parameter. Key and Value must appear in pairs.</para>
        /// <para><b>Note:</b></para>
        /// <list type="bullet">
        /// <item><description><para>When the operator of the request parameter is set to <b>enumeration filtering</b>, the value can contain multiple values, and the format of the value should be a JSON-formatted List. For example: <c>area=[&quot;East China&quot;,&quot;North China&quot;,&quot;South China&quot;]</c></para>
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
        /// <para>{ &quot;area&quot;: [&quot;华东&quot;, &quot;华北&quot;],  &quot;shopping_date&quot;: &quot;2019Q1&quot;,  }</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>A list of return parameter names, in a List-type string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

        /// <summary>
        /// <para>The userId in Quick BI. For how to obtain the userId, see: <a href="https://next.api.aliyun.com/document/quickbi-public/2022-01-01/QueryUserInfoByAccount">Query User Information by Account Interface</a></para>
        /// <remarks>
        /// <para>This parameter is used to specify the identity of the person using the data service, which can be used in conjunction with the row and column permission configurations of the dataset.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: If the parameter is not passed, an empty string is passed, or null is passed, the default userId will be the owner of the current Quick BI organization.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b5d8fd9348cc4327****afb604</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
