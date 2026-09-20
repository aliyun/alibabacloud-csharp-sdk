// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class XpackRelateDBRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the current Spark instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-bp1qtz9rcbbt3****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance ID of the cluster to associate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16o0pd52e3****</para>
        /// </summary>
        [NameInMap("DbClusterIds")]
        [Validation(Required=false)]
        public string DbClusterIds { get; set; }

        /// <summary>
        /// <para>The type of database to associate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hdfs</b></description></item>
        /// <item><description><b>hbase</b></description></item>
        /// <item><description><b>mongodb</b></description></item>
        /// <item><description><b>mysql</b></description></item>
        /// <item><description><b>polardb_mysql</b></description></item>
        /// <item><description><b>redis</b></description></item>
        /// <item><description><b>geomesa</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("RelateDbType")]
        [Validation(Required=false)]
        public string RelateDbType { get; set; }

    }

}
