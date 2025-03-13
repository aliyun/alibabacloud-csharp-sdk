// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataExportRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are required to perform the operation. Sample code:</para>
        /// <pre><code class="language-json">{
        ///   &quot;mode&quot; : &quot;FAST&quot;,   // The mode in which data is exported. Default value: FAST. A value of NORMAL specifies that the export task can be terminated during the export.  &quot;encoding&quot; : &quot;UTF8&quot;,  // The encoding format.  &quot;startTime&quot; : &quot;2022-12-22 00:00:00&quot;,  // The point in time at which data export starts.  &quot;transaction&quot; : false,    // Specifies whether to enable transactions.  &quot;fileType&quot; : &quot;SQL&quot;    // The format of the exported file.}
        /// </c></pre>
        /// <remarks>
        /// <para> You can also set mode, encoding, and fileType to the following values:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>mode: NORMAL</para>
        /// </description></item>
        /// <item><description><para>encoding: UTF8MB4, GB2312, ISO_8859_1, GBK, LATAIN1, or CP1252</para>
        /// </description></item>
        /// <item><description><para>fileType: XLSX, CSV, JSON, or TXT</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;fileType&quot;: &quot;CSV&quot;,    &quot;encoding&quot;: &quot;&quot;  }</para>
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> ActionDetail { get; set; }

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

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to call the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21400447956867****</para>
        /// </summary>
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
