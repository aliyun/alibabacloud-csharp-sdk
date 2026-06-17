// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHALogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a*************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polardb_mysql_rw</b>: read-write instance.</description></item>
        /// <item><description><b>polardb_mysql_ro</b>: read-only instance.</description></item>
        /// <item><description><b>polardb_mysql_standby</b>: standby instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql_rw</para>
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// <para>The list of primary/secondary 这里 AI 机翻使用了 failover，但代码里用了 switch，建议保持一致，都改为 swichover logs.</para>
        /// </summary>
        [NameInMap("HaLogItems")]
        [Validation(Required=false)]
        public List<DescribeHALogsResponseBodyHaLogItems> HaLogItems { get; set; }
        public class DescribeHALogsResponseBodyHaLogItems : TeaModel {
            /// <summary>
            /// <para>The cause code of the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.AuroraService.ManualOperations</para>
            /// </summary>
            [NameInMap("SwitchCauseCode")]
            [Validation(Required=false)]
            public string SwitchCauseCode { get; set; }

            /// <summary>
            /// <para>The cause of the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.ManuallyTriggered</para>
            /// </summary>
            [NameInMap("SwitchCauseDetail")]
            [Validation(Required=false)]
            public string SwitchCauseDetail { get; set; }

            /// <summary>
            /// <para>The end time of the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:56Z</para>
            /// </summary>
            [NameInMap("SwitchFinishTime")]
            [Validation(Required=false)]
            public string SwitchFinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the primary/secondary switchover log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e571f897-9b3c-4012-9470-88333832dec4</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The start time of the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:45Z</para>
            /// </summary>
            [NameInMap("SwitchStartTime")]
            [Validation(Required=false)]
            public string SwitchStartTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether primary/secondary switchover records exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: No</description></item>
        /// <item><description><b>0</b>: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HaStatus")]
        [Validation(Required=false)]
        public int? HaStatus { get; set; }

        /// <summary>
        /// <para>The number of items in the log list on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// <para>The page number. The value is greater than 0 and does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: 30 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
