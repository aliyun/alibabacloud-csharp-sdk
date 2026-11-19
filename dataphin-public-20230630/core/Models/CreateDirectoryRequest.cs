// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDirectoryRequestCreateCommand CreateCommand { get; set; }
        public class CreateDirectoryRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The menu tree category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>tempCode: Ad hoc query.</description></item>
            /// <item><description>codeManage: Code task.</description></item>
            /// <item><description>offlinePipeline: Offline pipeline.</description></item>
            /// <item><description>offlinePipelineCustomPlugin: Custom pipeline component.</description></item>
            /// <item><description>dataX: Synchronization task.</description></item>
            /// <item><description>streamMeta: Real-time meta table.</description></item>
            /// <item><description>streamCustomDataSource: Real-time custom data source.</description></item>
            /// <item><description>streamTemplate: Real-time compute template.</description></item>
            /// <item><description>resourceManage: Resource management.</description></item>
            /// <item><description>udfResource: Offline function.</description></item>
            /// <item><description>streamFunction: Real-time function.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tempCode</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The parent directory of the new directory.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The name of the new directory.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_xx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1212344</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
