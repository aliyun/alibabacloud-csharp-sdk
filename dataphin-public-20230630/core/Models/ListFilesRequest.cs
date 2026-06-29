// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListFilesRequest : TeaModel {
        /// <summary>
        /// <para>Query conditions</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListFilesRequestListQuery ListQuery { get; set; }
        public class ListFilesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Menu tree category</para>
            /// <list type="bullet">
            /// <item><description>Ad hoc query: tempCode</description></item>
            /// <item><description>Code task: codeManage</description></item>
            /// <item><description>Offline pipeline: offlinePipeline</description></item>
            /// <item><description>Pipeline custom component: offlinePipelineCustomPlugin</description></item>
            /// <item><description>Sync task: dataX</description></item>
            /// <item><description>Real-time meta table: streamMeta</description></item>
            /// <item><description>Real-time custom source: streamCustomDataSource</description></item>
            /// <item><description>Real-time computing template: streamTemplate</description></item>
            /// <item><description>Resource management: resourceManage</description></item>
            /// <item><description>Offline function: udfResource</description></item>
            /// <item><description>Real-time function: streamFunction</description></item>
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
            /// <para>File directory</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/xx/x</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>Environment identifier</para>
            /// <list type="bullet">
            /// <item><description>DEV</description></item>
            /// <item><description>PROD</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Project ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11112311</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Whether to recursively traverse and query</para>
            /// <list type="bullet">
            /// <item><description>true: Yes, returns all nodes under the directory</description></item>
            /// <item><description>false: No, returns only the first-level nodes under the directory</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Recursive")]
            [Validation(Required=false)]
            public bool? Recursive { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID</para>
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
