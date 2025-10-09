// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetComponentResponseBody : TeaModel {
        [NameInMap("Component")]
        [Validation(Required=false)]
        public GetComponentResponseBodyComponent Component { get; set; }
        public class GetComponentResponseBodyComponent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>43cd873b-235c-44f8-be07-e4d4cf7e73b0</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-04-27T05:37:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-26T07:44:21Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dim_whse_epet_warehouse_jz_storage_stock_lot_relation_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>207316543660665792</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64623</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;kind&quot;: &quot;Component&quot;,
            ///     &quot;name&quot;: &quot;com1&quot;,
            ///     &quot;spec&quot;: {
            ///         &quot;components&quot;: [
            ///             {
            ///                 &quot;name&quot;: &quot;test11&quot;,
            ///                 &quot;id&quot;: &quot;8196828925037*****&quot;,
            ///                 &quot;owner&quot;: &quot;054664&quot;,
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
