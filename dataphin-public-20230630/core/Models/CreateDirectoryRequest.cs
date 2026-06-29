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
            /// <item><description>tempCode: custom query</description></item>
            /// <item><description>codeManage: code node</description></item>
            /// <item><description>offlinePipeline: offline pipeline</description></item>
            /// <item><description>offlinePipelineCustomPlugin: pipeline custom component</description></item>
            /// <item><description>dataX: synchronization task</description></item>
            /// <item><description>streamMeta: real-time meta table</description></item>
            /// <item><description>streamCustomDataSource: real-time custom source</description></item>
            /// <item><description>streamTemplate: real-time compute template</description></item>
            /// <item><description>resourceManage: resource management</description></item>
            /// <item><description>udfResource: offline function</description></item>
            /// <item><description>streamFunction: real-time function.</description></item>
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
            /// <para>The parent directory of the new file directory.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The name of the new file directory.</para>
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

    }

}
