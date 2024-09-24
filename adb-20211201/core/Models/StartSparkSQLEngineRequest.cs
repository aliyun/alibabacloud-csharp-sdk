// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StartSparkSQLEngineRequest : TeaModel {
        /// <summary>
        /// <para>The configuration that is required to start the Spark SQL engine. Specify this value in the JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/471203.html">Conf configuration parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;spark.shuffle.timeout&quot;: &quot;:0s&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-abcd****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) paths of third-party JAR packages that are required to start the Spark SQL engine. Separate multiple OSS paths with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://testBuckname/test.jar,oss://testBuckname/test2.jar</para>
        /// </summary>
        [NameInMap("Jars")]
        [Validation(Required=false)]
        public string Jars { get; set; }

        /// <summary>
        /// <para>The maximum number of executors that are required to execute SQL statements. Valid values: 1 to 2000. If this value exceeds the total number of executes that are supported by the resource group, the Spark SQL engine fails to be started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxExecutor")]
        [Validation(Required=false)]
        public long? MaxExecutor { get; set; }

        /// <summary>
        /// <para>The minimum number of executors that are required to execute SQL statements. Valid values: 0 to 2000. A value of 0 indicates that no executors are permanent if no SQL statements are executed. If this value exceeds the total number of executors that are supported by the resource group, the Spark SQL engine fails to be started. The value must be less than the value of MaxExecutor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinExecutor")]
        [Validation(Required=false)]
        public long? MinExecutor { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark-rg-name</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The maximum number of slots that are required to maintain Spark sessions for executing SQL statements. Valid values: 1 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SlotNum")]
        [Validation(Required=false)]
        public long? SlotNum { get; set; }

    }

}
