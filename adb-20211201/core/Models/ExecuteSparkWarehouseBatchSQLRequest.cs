// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ExecuteSparkWarehouseBatchSQLRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Dataworks。</para>
        /// </summary>
        [NameInMap("Agency")]
        [Validation(Required=false)]
        public string Agency { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("ExecuteResultLimit")]
        [Validation(Required=false)]
        public long? ExecuteResultLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
        [NameInMap("ExecuteTimeLimitInSeconds")]
        [Validation(Required=false)]
        public long? ExecuteTimeLimitInSeconds { get; set; }

        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///  &quot;OSSURL&quot;: &quot;oss://testBucketname/&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RuntimeConfig")]
        [Validation(Required=false)]
        public string RuntimeConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

    }

}
