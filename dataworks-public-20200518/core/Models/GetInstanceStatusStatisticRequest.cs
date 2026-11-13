// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The business date for which to retrieve the number of instances in each instance status. Specify the date in the yyyy-MM-dd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-01</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>The DAG type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MANUAL: Manual task workflow.</description></item>
        /// <item><description>SMOKE_TEST: Smoke test workflow.</description></item>
        /// <item><description>SUPPLY_DATA: Data backfill.</description></item>
        /// <item><description>BUSINESS_PROCESS_DAG: One-time business process workflow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MANUAL</para>
        /// </summary>
        [NameInMap("DagType")]
        [Validation(Required=false)]
        public string DagType { get; set; }

        /// <summary>
        /// <para>The runtime environment, including PROD (production environment) and DEV (development environment).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Configuration page to obtain the workspace ID.</para>
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
        /// <item><description>MINUTE: Minute.</description></item>
        /// <item><description>HOUR: Hour.</description></item>
        /// <item><description>DAY: Day.</description></item>
        /// <item><description>WEEK: Week.</description></item>
        /// <item><description>MONTH: Month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("SchedulerPeriod")]
        [Validation(Required=false)]
        public string SchedulerPeriod { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Periodic scheduling.</description></item>
        /// <item><description>MANUAL: Manual scheduling.</description></item>
        /// <item><description>PAUSE: Paused scheduling.</description></item>
        /// <item><description>SKIP: Dry run.</description></item>
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
