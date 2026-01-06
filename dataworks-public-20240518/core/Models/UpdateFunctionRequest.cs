// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateFunctionRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the UDF.</para>
        /// <remarks>
        /// <para> This field is of the Long type in SDK versions prior to 8.0.0, and of the String type in SDK versions 8.0.0 and later. This change does not affect normal SDK usage; the parameter will still be returned according to the type defined in the SDK.. However, compilation failures may occur due to the type change only when upgrading the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>463497880880954XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the UDF.</para>
        /// <remarks>
        /// <para> Prior to SDK version 8.0.0, this field is of type Long. In SDK version 8.0.0 and later, it is of type String. This change does not affect the normal use of the SDK. The parameter is returned based on the type defined in the SDK. Compilation failures caused by the type change may occur only when you upgrade the SDK across version 8.0.0. In this case, you must manually update the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;version&quot;: &quot;1.1.0&quot;,
        ///     &quot;kind&quot;: &quot;Function&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;functions&quot;: [
        ///             {
        ///                 &quot;name&quot;: &quot;FunctionName&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;content&quot;: &quot;{\&quot;name\&quot;: \&quot;FunctionName\&quot;, \&quot;datasource\&quot;: {\&quot;type\&quot;: \&quot;odps\&quot;, \&quot;name\&quot;: \&quot;odps_first\&quot;}, \&quot;runtimeResource\&quot;: {\&quot;resourceGroup\&quot;: \&quot;S_res_group_XXXX_XXXX\&quot;}}&quot;,
        ///                     &quot;path&quot;: &quot;XXX/OpenAPI/Function/FunctionName&quot;,
        ///                     &quot;runtime&quot;: {
        ///                         &quot;command&quot;: &quot;ODPS_FUNCTION&quot;
        ///                     }
        ///                 },
        ///                 &quot;datasource&quot;: {
        ///                     &quot;name&quot;: &quot;odps_first&quot;,
        ///                     &quot;type&quot;: &quot;odps&quot;
        ///                 },
        ///                 &quot;runtimeResource&quot;: {
        ///                     &quot;resourceGroup&quot;: &quot;S_res_group_XXXX_XXXX&quot;
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

}
