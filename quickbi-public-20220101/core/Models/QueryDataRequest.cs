// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRequest : TeaModel {
        /// <summary>
        /// <para>The API ID in <a href="https://help.aliyun.com/document_detail/144980.html">DataService Studio</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>Filter conditions as a JSON map string. Each key is a request parameter name, and each value is the parameter value.</para>
        /// <para><b>Note:</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the operator of a request parameter is set to <b>Enumeration Filter</b>, the value can contain multiple values. In this case, the value must be in the format of a JSON list. For example: <c>area=[&quot;East China&quot;,&quot;North China&quot;,&quot;South China&quot;]</c></para>
        /// </description></item>
        /// <item><description><para>For dates, use the following formats based on the date type:</para>
        /// <list type="bullet">
        /// <item><description><para>Year: 2019</para>
        /// </description></item>
        /// <item><description><para>Quarter: 2019Q1</para>
        /// </description></item>
        /// <item><description><para>Month: 201901 (with a leading zero)</para>
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
        /// <para>{ &quot;area&quot;: [&quot;test&quot;, &quot;test&quot;],  &quot;shopping_date&quot;: &quot;2019Q1&quot;,  }</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>A JSON array of field names to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

        /// <summary>
        /// <para>The Quick BI user ID. Obtain this value from <a href="https://next.api.aliyun.com/document/quickbi-public/2022-01-01/QueryUserInfoByAccount">QueryUserInfoByAccount</a>.</para>
        /// <remarks>
        /// <para>Specifies the user identity for DataService Studio, used with row-level and column-level permission configurations.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If omitted, empty, or null, defaults to the Quick BI organization owner\&quot;s user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5d8fd9348cc4327****afb604</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
