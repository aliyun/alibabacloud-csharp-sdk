// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateFunctionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the UDF.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>463497880880954XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The FlowSpec field information about the UDF. For more information, see <a href="https://github.com/aliyun/dataworks-spec/blob/master/README_zh_CN.md">FlowSpec</a>.</para>
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
