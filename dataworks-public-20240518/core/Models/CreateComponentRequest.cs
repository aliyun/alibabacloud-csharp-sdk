// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateComponentRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/2852607.html">ListProjects</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The FlowSpec information for this UDF function. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;kind&quot;: &quot;Component&quot;,
        ///     &quot;name&quot;: &quot;com1&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;components&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;test11&quot;,
        ///                 &quot;id&quot;: &quot;1234&quot;,
        ///                 &quot;owner&quot;: &quot;1234456&quot;,
        ///                 &quot;description&quot;: &quot;&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;language&quot;: &quot;odps-sql&quot;,
        ///                     &quot;path&quot;: &quot;test11&quot;,
        ///                     &quot;content&quot;: &quot;select \&quot;@@{bizdate}\&quot;, \&quot;@@{my_input_table}\&quot;&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;SQL_COMPONENT&quot;
        ///                     }
        ///                 },
        ///                 &quot;inputs&quot;: [
        ///                     {
        ///                         &quot;name&quot;: &quot;bizdate&quot;,
        ///                         &quot;type&quot;: &quot;string&quot;
        ///                     },
        ///                     {
        ///                         &quot;name&quot;: &quot;my_input_table&quot;,
        ///                         &quot;type&quot;: &quot;string&quot;
        ///                     }
        ///                 ],
        ///                 &quot;outputs&quot;: [
        ///                     {
        ///                         &quot;name&quot;: &quot;my_output_table1&quot;,
        ///                         &quot;type&quot;: &quot;string&quot;
        ///                     }
        ///                 ]
        ///             }
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
