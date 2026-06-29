// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Environment identifier</para>
        /// <list type="bullet">
        /// <item><description>DEV: Development environment</description></item>
        /// <item><description>PROD (default): Production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>Query Request</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListInstancesRequestListQuery ListQuery { get; set; }
        public class ListInstancesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Business Type</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT: Script Instance</description></item>
            /// <item><description>LOGICAL_TABLE: Logical Table</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>Business unit ID. Required when querying summary logical tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6232322111</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>Workflow ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>End business date and time. The time format must conform to the partition format specified by the business unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-31</para>
            /// </summary>
            [NameInMap("MaxBizDate")]
            [Validation(Required=false)]
            public string MaxBizDate { get; set; }

            /// <summary>
            /// <para>Maximum instance run time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-31</para>
            /// </summary>
            [NameInMap("MaxRunDate")]
            [Validation(Required=false)]
            public string MaxRunDate { get; set; }

            /// <summary>
            /// <para>Start business date and time. The time format must conform to the partition format specified by the business unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30</para>
            /// </summary>
            [NameInMap("MinBizDate")]
            [Validation(Required=false)]
            public string MinBizDate { get; set; }

            /// <summary>
            /// <para>Minimum instance run time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30</para>
            /// </summary>
            [NameInMap("MinRunDate")]
            [Validation(Required=false)]
            public string MinRunDate { get; set; }

            /// <summary>
            /// <para>Node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_23131</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Node Owner</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>Page Number</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Page Size</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Priority</para>
            /// <list type="bullet">
            /// <item><description>HIGHEST</description></item>
            /// <item><description>HIGH</description></item>
            /// <item><description>MIDDLE</description></item>
            /// <item><description>LOW</description></item>
            /// <item><description>LOWEST</description></item>
            /// </list>
            /// </summary>
            [NameInMap("PriorityList")]
            [Validation(Required=false)]
            public List<string> PriorityList { get; set; }

            /// <summary>
            /// <para>Project ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131311111321</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Running status</para>
            /// <list type="bullet">
            /// <item><description>INIT: Initialized</description></item>
            /// <item><description>WAIT_SUBMISSION: Waiting for Submission</description></item>
            /// <item><description>WAIT_SCHEDULE: Waiting for Schedule Time</description></item>
            /// <item><description>DISPATCH_BLOCKED: Throttled</description></item>
            /// <item><description>WAIT_RESOURCE: Waiting for Scheduling Resources</description></item>
            /// <item><description>RUNNING: Running</description></item>
            /// <item><description>SUCCESS: Succeeded</description></item>
            /// <item><description>FAILED: Failed</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RunStatusList")]
            [Validation(Required=false)]
            public List<string> RunStatusList { get; set; }

            /// <summary>
            /// <para>Whether scheduling is paused</para>
            /// </summary>
            [NameInMap("SchedulePaused")]
            [Validation(Required=false)]
            public bool? SchedulePaused { get; set; }

            /// <summary>
            /// <para>Schedule Period</para>
            /// <list type="bullet">
            /// <item><description>YEARLY</description></item>
            /// <item><description>MONTHLY</description></item>
            /// <item><description>WEEKLY</description></item>
            /// <item><description>DAILY</description></item>
            /// <item><description>HOURLY</description></item>
            /// <item><description>MINUTELY</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SchedulePeriodList")]
            [Validation(Required=false)]
            public List<string> SchedulePeriodList { get; set; }

            /// <summary>
            /// <para>Instance schedule type</para>
            /// <list type="bullet">
            /// <item><description>NORMAL (Periodic Instance)</description></item>
            /// <item><description>MANUAL (Manual Instance)</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>Fuzzy match by node name or exact match by node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("SearchText")]
            [Validation(Required=false)]
            public string SearchText { get; set; }

            /// <summary>
            /// <para>Sub-business Type</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SubBizTypeList")]
            [Validation(Required=false)]
            public List<string> SubBizTypeList { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
