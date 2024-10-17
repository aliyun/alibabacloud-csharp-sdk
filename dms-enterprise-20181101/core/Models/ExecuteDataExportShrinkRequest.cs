// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataExportShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are required to perform the operation:</para>
        /// <pre><code class="language-json">{
        ///    &quot;fileType&quot;: &quot;CSV&quot;, // The format of the exported file.
        ///    &quot;encoding&quot;: &quot;&quot; // The encoding format.
        ///  }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;fileType&quot;: &quot;CSV&quot;,    &quot;encoding&quot;: &quot;&quot;  }</para>
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public string ActionDetailShrink { get; set; }

        /// <summary>
        /// <para>The ID of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>: To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
