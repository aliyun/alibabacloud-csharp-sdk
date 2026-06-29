// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateResourceRequestCreateCommand CreateCommand { get; set; }
        public class CreateResourceRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The commit remarks.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx 测试</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The compute engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE</description></item>
            /// <item><description>HADOOP</description></item>
            /// <item><description>NONE.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("ComputeEngineType")]
            [Validation(Required=false)]
            public string ComputeEngineType { get; set; }

            /// <summary>
            /// <para>The description of the resource file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx 测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The folder in which the resource file is stored.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udf_sleep.jar</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>711833</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The type of the resource file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FILE: common file.</description></item>
            /// <item><description>JAR: JAR file.</description></item>
            /// <item><description>PYTHON: Python file.</description></item>
            /// <item><description>OTHERS: other type of file.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JAR</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The storage address of the resource file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300011448/711833/cdcd1c44-f1ee-46bb-b318-1d123dbabf6c</para>
            /// </summary>
            [NameInMap("StorageAddress")]
            [Validation(Required=false)]
            public string StorageAddress { get; set; }

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
