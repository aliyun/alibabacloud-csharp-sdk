// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ExecuteSparkWarehouseBatchSQLRequest : TeaModel {
        /// <summary>
        /// <para>The name of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataWorks</para>
        /// </summary>
        [NameInMap("Agency")]
        [Validation(Required=false)]
        public string Agency { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The maximum amount of execution result data that can be written to Object Storage Service (OSS). Unit: MB. Default value: 4096. The size of compressed objects is difficult to estimate. The data that is actually written to OSS is smaller than the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("ExecuteResultLimit")]
        [Validation(Required=false)]
        public long? ExecuteResultLimit { get; set; }

        /// <summary>
        /// <para>The maximum execution duration. Unit: seconds. If a set of SQL statements fail to be executed for the specified period of time after submission, they are marked as a timeout error. The default value is 360000 seconds, which is equivalent to 100 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
        [NameInMap("ExecuteTimeLimitInSeconds")]
        [Validation(Required=false)]
        public long? ExecuteTimeLimitInSeconds { get; set; }

        /// <summary>
        /// <para>The SQL statements that you want to execute in batches. Separate multiple SQL statements with semicolons (;). The execution engine executes the SQL statements in sequence in the same session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE TABLE user(id INT, name STRING);
        /// INSERT INTO t VALUE(1, \&quot;Bob\&quot;);
        /// SELECT * FROM t;</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The additional runtime parameter. Specify the parameter in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///  &quot;OSSURL&quot;: &quot;oss://testBucketname/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RuntimeConfig")]
        [Validation(Required=false)]
        public string RuntimeConfig { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

    }

}
