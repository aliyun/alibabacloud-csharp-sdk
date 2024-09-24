// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkTemplateFileContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkTemplateFileContentResponseBodyData Data { get; set; }
        public class GetSparkTemplateFileContentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SQL</b></description></item>
            /// <item><description><b>STREAMING</b></description></item>
            /// <item><description><b>BATCH</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The content of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set spark.driver.resourceSpec=medium;set spark.executor.instances=2;set spark.executor.resourceSpec=medium;set spark.app.name=Spark SQL Test;</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The application template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>725204</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The file type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>folder</b></description></item>
            /// <item><description><b>file</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
