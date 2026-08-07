// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of static data masking tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingTasksResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The member accounts to which the destination data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192479427903xxxx</para>
            /// </summary>
            [NameInMap("DstMemberAccount")]
            [Validation(Required=false)]
            public long? DstMemberAccount { get; set; }

            /// <summary>
            /// <para>The destination path.</para>
            /// </summary>
            [NameInMap("DstPath")]
            [Validation(Required=false)]
            public string DstPath { get; set; }

            /// <summary>
            /// <para>The service to which the destination data source belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute.</description></item>
            /// <item><description><b>2</b>: OSS.</description></item>
            /// <item><description><b>3</b>: ADS.</description></item>
            /// <item><description><b>4</b>: OTS.</description></item>
            /// <item><description><b>5</b>: RDS.</description></item>
            /// <item><description><b>6</b>: SELF_DB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The destination service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MaxCompute</b>.</description></item>
            /// <item><description><b>OSS</b>.</description></item>
            /// <item><description><b>ADS</b>.</description></item>
            /// <item><description><b>OTS</b>.</description></item>
            /// <item><description><b>RDS</b>.</description></item>
            /// <item><description><b>SELF_DB</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The creation time. Format: timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is being executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasUnfinishProcess")]
            [Validation(Required=false)]
            public bool? HasUnfinishProcess { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the task masks data in the original table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OriginalTable")]
            [Validation(Required=false)]
            public bool? OriginalTable { get; set; }

            /// <summary>
            /// <para>The task creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>owner</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The number of executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunCount")]
            [Validation(Required=false)]
            public int? RunCount { get; set; }

            /// <summary>
            /// <para>The member accounts to which the source data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192479427903xxxx</para>
            /// </summary>
            [NameInMap("SrcMemberAccount")]
            [Validation(Required=false)]
            public long? SrcMemberAccount { get; set; }

            /// <summary>
            /// <para>The source path.</para>
            /// </summary>
            [NameInMap("SrcPath")]
            [Validation(Required=false)]
            public string SrcPath { get; set; }

            /// <summary>
            /// <para>The source service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute.</description></item>
            /// <item><description><b>2</b>: OSS.</description></item>
            /// <item><description><b>3</b>: ADS.</description></item>
            /// <item><description><b>4</b>: OTS.</description></item>
            /// <item><description><b>5</b>: RDS.</description></item>
            /// <item><description><b>6</b>: SELF_DB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The source service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MaxCompute</b>.</description></item>
            /// <item><description><b>OSS</b>.</description></item>
            /// <item><description><b>ADS</b>.</description></item>
            /// <item><description><b>OTS</b>.</description></item>
            /// <item><description><b>RDS</b>.</description></item>
            /// <item><description><b>SELF_DB</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt4HBgtw1B******</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task name</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Manual.</description></item>
            /// <item><description><b>2</b>: Scheduled.</description></item>
            /// <item><description><b>3</b>: Manual and scheduled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public int? TriggerType { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
