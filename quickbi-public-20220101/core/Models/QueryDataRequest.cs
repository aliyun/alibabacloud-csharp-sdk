// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API in Data Service. For more information, see <a href="https://help.aliyun.com/document_detail/144980.html">Data Service</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The query conditions for Data Service. Specify the conditions as key-value pairs in a map-type string. The key is the request parameter name, and the value is the request parameter value. Keys and values must appear in pairs.</para>
        /// <para><b>Note:</b></para>
        /// <list type="bullet">
        /// <item><description><para>When the operator of the request parameter is set to <b>enumeration filter</b>, the value can contain multiple values. In this case, the value must be a JSON-formatted list. Example: <c>area=[&quot;East China&quot;,&quot;North China&quot;,&quot;South China&quot;]</c>     </para>
        /// </description></item>
        /// <item><description><para>For dates, different input formats are provided based on the type:</para>
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
        /// <para>The list of names of the return parameters, which is a list-type string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

        /// <summary>
        /// <para>The user ID in Quick BI. For information about how to obtain the user ID, see <a href="https://next.api.aliyun.com/document/quickbi-public/2022-01-01/QueryUserInfoByAccount">Query user information by account</a>.</para>
        /// <remarks>
        /// <para>This parameter specifies the identity of the user who uses Data Service. It can be used in combination with the row-level and column-level permission configurations of the dataset.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: If this parameter is not specified, is left empty, or is set to null, the user ID of the owner of the current Quick BI organization is used by default.</notice></para>
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
