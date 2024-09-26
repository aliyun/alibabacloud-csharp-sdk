// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The date on which the numbers of instances in different states are obtained. Specify the date in the yyyy-MM-dd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-01</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>The type of the directed acyclic graph (DAG). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MANUAL: DAG for a manually triggered workflow</description></item>
        /// <item><description>SMOKE_TEST: DAG for a smoke testing workflow</description></item>
        /// <item><description>SUPPLY_DATA: DAG for a data backfill instance</description></item>
        /// <item><description>BUSINESS_PROCESS_DAG: DAG for a one-time workflow</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description>DAILY</description></item>
        /// <item><description>MANUAL</description></item>
        /// <item><description>SMOKE_TEST</description></item>
        /// <item><description>SUPPLY_DATA</description></item>
        /// <item><description>BUSINESS_PROCESS_DAG</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MANUAL</para>
        /// </summary>
        [NameInMap("DagType")]
        [Validation(Required=false)]
        public string DagType { get; set; }

        /// <summary>
        /// <para>The runtime environment. Valid values: PROD and DEV.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scheduling cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MINUTE</description></item>
        /// <item><description>HOUR</description></item>
        /// <item><description>DAY</description></item>
        /// <item><description>WEEK</description></item>
        /// <item><description>MONTH</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("SchedulerPeriod")]
        [Validation(Required=false)]
        public string SchedulerPeriod { get; set; }

        /// <summary>
        /// <para>The scheduling type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: auto triggered node</description></item>
        /// <item><description>MANUAL: manually triggered node</description></item>
        /// <item><description>PAUSE: paused node</description></item>
        /// <item><description>SKIP: dry-run node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

    }

}
