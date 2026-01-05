// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFunctionResponseBody : TeaModel {
        /// <summary>
        /// <para>UDF function details</para>
        /// </summary>
        [NameInMap("Function")]
        [Validation(Required=false)]
        public GetFunctionResponseBodyFunction Function { get; set; }
        public class GetFunctionResponseBodyFunction : TeaModel {
            /// <summary>
            /// <para>The time when the UDF was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724505917000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the UDF function.</para>
            /// <remarks>
            /// <para> This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK; parameters are still returned according to the type defined in the SDK. Compilation failures due to the type change may occur only when upgrading the SDK across version 8.0.0, in which case users need to manually correct the data type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>860438872620113XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the UDF was last modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724506661000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the UDF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Function name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the UDF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110755000425XXXX</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace to which the UDF belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The FlowSpec field information about the UDF. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;version&quot;: &quot;1.1.0&quot;,
            ///     &quot;kind&quot;: &quot;Function&quot;,
            ///     &quot;spec&quot;: {
            ///         &quot;functions&quot;: [
            ///             {
            ///                 &quot;name&quot;: &quot;Function_Name&quot;,
            ///                 &quot;id&quot;: &quot;580667964888595XXXX&quot;,
            ///                 &quot;script&quot;: {
            ///                     &quot;content&quot;: &quot;{  \&quot;uuid\&quot;: \&quot;580667964888595XXXX\&quot;,  \&quot;name\&quot;: \&quot;Function_Name\&quot;,  \&quot;datasource\&quot;: {    \&quot;type\&quot;: \&quot;odps\&quot;,    \&quot;name\&quot;: \&quot;odps_first\&quot;  },  \&quot;runtimeResource\&quot;: {    \&quot;resourceGroup\&quot;: \&quot;S_res_group_XXXX_XXXX\&quot;,    \&quot;resourceGroupId\&quot;: 6591XXXX  }}&quot;,
            ///                     &quot;path&quot;: &quot;XXX/OpenAPI/Function/Function_Name&quot;,
            ///                     &quot;runtime&quot;: {
            ///                         &quot;command&quot;: &quot;ODPS_FUNCTION&quot;
            ///                     }
            ///                 },
            ///                 &quot;datasource&quot;: {
            ///                     &quot;name&quot;: &quot;odps_first&quot;,
            ///                     &quot;type&quot;: &quot;odps&quot;
            ///                 },
            ///                 &quot;runtimeResource&quot;: {
            ///                     &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;,
            ///                     &quot;id&quot;: &quot;723932906364267XXXX&quot;,
            ///                     &quot;resourceGroupId&quot;: &quot;6591XXXX&quot;
            ///                 },
            ///                 &quot;metadata&quot;: {
            ///                     &quot;owner&quot;: &quot;110755000425XXXX&quot;
            ///                 }
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF95929-6D12-5A88-8CC3-4B2F4C2EXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
