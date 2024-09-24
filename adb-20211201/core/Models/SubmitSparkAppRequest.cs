// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SubmitSparkAppRequest : TeaModel {
        /// <summary>
        /// <para>The type of the client. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSOLE</para>
        /// </summary>
        [NameInMap("AgentSource")]
        [Validation(Required=false)]
        public string AgentSource { get; set; }

        /// <summary>
        /// <para>The version of the client. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.091</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The name of the application. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SQL</b></description></item>
        /// <item><description><b>STREAMING</b></description></item>
        /// <item><description><b>BATCH</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The data of the application template.</para>
        /// <remarks>
        /// <para>For information about the application template configuration, see <a href="https://help.aliyun.com/document_detail/452402.html">Spark application configuration guide</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conf spark.driver.resourceSpec=small; conf spark.executor.instances=1; conf spark.executor.resourceSpec=small; conf spark.app.name=TestApp;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The name of the job resource group.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612410.html">DescribeDBResourceGroup</a> operation to query the name of a resource group within a cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the application template.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/456205.html">GetSparkTemplateFullTree</a> operation to query the application template ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TemplateFileId")]
        [Validation(Required=false)]
        public long? TemplateFileId { get; set; }

    }

}
