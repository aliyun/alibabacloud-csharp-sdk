// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLogFilesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the node in the PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-*************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        /// <summary>
        /// <para>The mode to query simulation records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Queries the simulation records of a logical instance. You can specify the simulation ID.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Queries the simulation records of a physical instance based on a specified <c>SimulateListId</c>.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Queries the records of the most recent simulation in progress.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DescribeSimulateSwitchMode")]
        [Validation(Required=false)]
        public string DescribeSimulateSwitchMode { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HaSwitchLogList</b>: A list of failover logs.</para>
        /// </description></item>
        /// <item><description><para><b>HaSwitchLogInfo</b>: Details of a failover log.</para>
        /// </description></item>
        /// <item><description><para><b>SimulateSwitchLogs</b>: Failover simulation logs.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HaSwitchLogList</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 5 to 50. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of a logical instance simulation record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;95&quot;</para>
        /// </summary>
        [NameInMap("SimulateListId")]
        [Validation(Required=false)]
        public string SimulateListId { get; set; }

        /// <summary>
        /// <para>Filters the results by one or more simulation modes. Specify multiple modes as a comma-separated string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Fault is injected into the primary availability zone.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Fault is injected into the DB instance.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Fault is injected into the disaster recovery data center.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0,1,2</para>
        /// </summary>
        [NameInMap("SimulateModeList")]
        [Validation(Required=false)]
        public string SimulateModeList { get; set; }

        /// <summary>
        /// <para>Filters the results by one or more simulation statuses. Specify multiple statuses as a comma-separated string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Waiting for scheduling</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Succeeded</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Running</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Failed</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Interrupted</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Waiting for switchback</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Canceled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0,1,2,3,4,5&quot;</para>
        /// </summary>
        [NameInMap("SimulateStatusList")]
        [Validation(Required=false)]
        public string SimulateStatusList { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
