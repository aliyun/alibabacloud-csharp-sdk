// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateSparkTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The templatetype of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SQL</b>: SQL application</description></item>
        /// <item><description><b>STREAMING</b>: streaming application</description></item>
        /// <item><description><b>BATCH</b>: batch application</description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to configure this parameter when the application template type is folder.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the application template. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batchfile</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the folder to which the application template belongs.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/456218.html">GetSparkTemplateFolderTree</a> operation to query the folder ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The templatetype of the application template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>folder</b>: folder</description></item>
        /// <item><description><b>file</b>: application</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
