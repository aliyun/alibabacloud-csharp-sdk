// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of data masking tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingTasksResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The member account that the data masking destination belongs to.</para>
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
            /// <para>The product that the destination data source belongs to. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The type of the destination product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>ADS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OTS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasUnfinishProcess")]
            [Validation(Required=false)]
            public bool? HasUnfinishProcess { get; set; }

            /// <summary>
            /// <para>The numerical ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the source table is masked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OriginalTable")]
            [Validation(Required=false)]
            public bool? OriginalTable { get; set; }

            /// <summary>
            /// <para>The creator of the task.</para>
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
            /// <para>The member account that the data masking source belongs to.</para>
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
            /// <para>The type of the source product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The type of the source product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>ADS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OTS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The string ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt4HBgtw1B******</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task name</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The execution method of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Manual.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Scheduled.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Manual and scheduled.</para>
            /// </description></item>
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
