// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The compute group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze34****-clickhouse</para>
        /// </summary>
        [NameInMap("ComputingGroupId")]
        [Validation(Required=false)]
        public string ComputingGroupId { get; set; }

        /// <summary>
        /// <para>The endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze34****-clickhouse..clickhouseserver.pre.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The prefix of the database endpoint.</para>
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
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Vpc: VPC network.</description></item>
        /// <item><description>Public: public network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Disables specified database ports. You can specify multiple ports separated by commas (,).</description></item>
        /// <item><description>Only clusters with a kernel version of 24.10.1.11098_1 or later support this parameter.<remarks>
        /// <para>Notice: If the cluster was created with a version earlier than 24.10.1.11098_1 and later upgraded to version 24.10.1.11098_1 or later, this parameter is not supported.</notice></para>
        /// </remarks>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
