// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComponentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>568780096083*******</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
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
        ///     &quot;version&quot;: &quot;1.1.2&quot;,
        ///     &quot;spec&quot;: {
        ///         &quot;components&quot;: [
        ///             {
        ///                 &quot;id&quot;: &quot;568780096083*******&quot;,
        ///                 &quot;script&quot;: {
        ///                     &quot;content&quot;: &quot;select \&quot;@@{para1}\&quot;, \&quot;@@{para2}\&quot;&quot;
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
