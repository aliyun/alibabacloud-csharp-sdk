// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeQueryExplainRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbtest01</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// <remarks>
        /// <para>For PolarDB for MySQL instances, if you specify a node ID, the system queries the execution plan on that node. Otherwise, it queries the execution plan on a secondary node.For high availability ApsaraDB RDS for MySQL instances, if you specify an instance ID, the system queries the execution plan on that node. Otherwise, it queries the execution plan on a secondary node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp1v203xzzh0a****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>Schema information. This is a reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The SQL statement for which you want to get the execution plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test where name = \&quot;mockUser\&quot;</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
