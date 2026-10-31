// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDirectoryTreeRequest : TeaModel {
        /// <summary>
        /// <para>The directory type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tempCode: Ad hoc query.</description></item>
        /// <item><description>codeManage: Code task.</description></item>
        /// <item><description>offlinePipeline: Offline pipeline.</description></item>
        /// <item><description>offlinePipelineCustomPlugin: Custom pipeline component.</description></item>
        /// <item><description>dataX: Synchronization task.</description></item>
        /// <item><description>streamMeta: Real-time metadata table.</description></item>
        /// <item><description>streamCustomDataSource: Real-time custom source.</description></item>
        /// <item><description>streamTemplate: Real-time computing template.</description></item>
        /// <item><description>resourceManage: Resource management.</description></item>
        /// <item><description>udfResource: Offline function.</description></item>
        /// <item><description>streamFunction: Real-time function.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codeManage</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operating user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7081229106458752</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
