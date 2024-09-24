// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The policy tasks.</para>
        /// </summary>
        [NameInMap("SoarStrategyTasks")]
        [Validation(Required=false)]
        public List<DescribeSoarStrategyTasksResponseBodySoarStrategyTasks> SoarStrategyTasks { get; set; }
        public class DescribeSoarStrategyTasksResponseBodySoarStrategyTasks : TeaModel {
            /// <summary>
            /// <para>The number of execution failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("FailedNum")]
            [Validation(Required=false)]
            public int? FailedNum { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy task was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1708481235000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy task was complete. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586739841000</para>
            /// </summary>
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public long? GmtFinish { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy task was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669869436000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the policy task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5374</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the policy task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>strategy_name01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>runmode_TRIGGER_BY_USER: manually executed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>runmode_TRIGGER_BY_USER</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>The status of the policy task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>\-1: waiting</description></item>
            /// <item><description>0: starting</description></item>
            /// <item><description>1: running</description></item>
            /// <item><description>2: finished</description></item>
            /// <item><description>3: schedule</description></item>
            /// <item><description>4: pause</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The number of successful executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SuccessNum")]
            [Validation(Required=false)]
            public int? SuccessNum { get; set; }

            /// <summary>
            /// <para>The total number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
