// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The computing group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze34****-clickhouse</para>
        /// </summary>
        [NameInMap("ComputingGroupId")]
        [Validation(Required=false)]
        public string ComputingGroupId { get; set; }

        /// <summary>
        /// <para>The connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-2ze34****-clickhouse..clickhouseserver.pre.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The connection string prefix.</para>
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
        /// <item><description><para><c>Vpc</c>: VPC</para>
        /// </description></item>
        /// <item><description><para><c>Public</c>: public network</para>
        /// </description></item>
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
        /// <item><description><para>The database ports to disable. You can specify multiple ports, separated by commas.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only for clusters with a kernel version of 24.10.1.11098_1 or later.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is not supported for clusters that were upgraded to kernel version 24.10.1.11098_1 or later from an earlier version.</para>
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
