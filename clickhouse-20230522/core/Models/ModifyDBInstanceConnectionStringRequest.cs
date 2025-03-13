// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze34****-clickhouse..clickhouseserver.pre.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The prefix of the endpoint that is used to connect to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-****-clickhouse</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-xxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The database port that you want to disable. If you need to specify multiple database ports, separate the database ports with commas (,).</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only in clusters whose engine version is 24.10.1.11098_1 or later.</para>
        /// <para>**</para>
        /// <para><b>Note</b> If you create a cluster whose version is earlier than 24.10.1.11098_1, the cluster does not support this parameter even after being upgraded to 24.10.1.11098_1 or later.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9001,8123</para>
        /// </summary>
        [NameInMap("DisablePorts")]
        [Validation(Required=false)]
        public string DisablePorts { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
