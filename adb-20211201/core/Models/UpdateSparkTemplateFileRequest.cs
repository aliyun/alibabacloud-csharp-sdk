// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateSparkTemplateFileRequest : TeaModel {
        /// <summary>
        /// <para>The template data to be updated.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the application template is not updated. For information about how to configure a Spark application template, see <a href="https://help.aliyun.com/document_detail/452402.html">Configure a Spark application</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>set spark.driver.resourceSpec=medium;set spark.executor.instances=2;set spark.executor.resourceSpec=medium;set spark.app.name=Spark SQL Test;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-pz5vp4585l466****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The application template ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/456205.html">GetSparkTemplateFullTree</a> operation to query the application template ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>718056</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the job resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
