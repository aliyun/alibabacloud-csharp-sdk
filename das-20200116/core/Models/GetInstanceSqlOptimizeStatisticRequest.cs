// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceSqlOptimizeStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1662518540764</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter instances for which DAS Enterprise Edition is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>true</b>, only database instances for which DAS Enterprise Edition is disabled are queried. If you set this parameter to <b>false</b>, all database instances are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterEnable")]
        [Validation(Required=false)]
        public string FilterEnable { get; set; }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <remarks>
        /// <para> The database instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz90h9560rvdz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> For ApsaraDB RDS for MySQL Cluster Edition instances or PolarDB for MySQL clusters, you must specify the node ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp12v7243x012****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661308902060</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The duration threshold for automatic SQL optimization events. After this parameter is specified, the system collects statistics on automatic SQL optimization events whose duration does not exceed the specified threshold.</para>
        /// <remarks>
        /// <para> This parameter is a reserved parameter and does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge automatic SQL optimization events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: merges automatic SQL optimization events.</description></item>
        /// <item><description><b>false</b>: does not merge automatic SQL optimization events.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is a reserved parameter and does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseMerging")]
        [Validation(Required=false)]
        public string UseMerging { get; set; }

    }

}
