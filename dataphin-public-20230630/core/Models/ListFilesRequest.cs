// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListFilesRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListFilesRequestListQuery ListQuery { get; set; }
        public class ListFilesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The menu tree category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>tempCode: Ad hoc query.</description></item>
            /// <item><description>codeManage: Code task.</description></item>
            /// <item><description>offlinePipeline: Offline pipeline.</description></item>
            /// <item><description>offlinePipelineCustomPlugin: Custom pipeline component.</description></item>
            /// <item><description>dataX: Synchronization task.</description></item>
            /// <item><description>streamMeta: Real-time metatable.</description></item>
            /// <item><description>streamCustomDataSource: Real-time custom data source.</description></item>
            /// <item><description>streamTemplate: Real-time computing template.</description></item>
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
            /// <para>The file directory.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/xx/x</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The environment identifier. Valid values:</para>
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
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11112311</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Specifies whether to recursively traverse and query the directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes. Returns all nodes under the directory.</description></item>
            /// <item><description>false: No. Returns only the first-level nodes under the directory.</description></item>
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
