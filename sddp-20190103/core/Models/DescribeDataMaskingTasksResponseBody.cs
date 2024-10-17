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
        /// <para>A list of de-identification tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingTasksResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The member account to which the desensitization target belongs.</para>
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
            /// <para>The service to which the data to be de-identified belongs. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The type of the service to which the de-identified data belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the de-identification task is created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Indicates whether the de-identification task is running.</para>
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
            /// <para>Indicates whether the source table is de-identified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OriginalTable")]
            [Validation(Required=false)]
            public bool? OriginalTable { get; set; }

            /// <summary>
            /// <para>The user who created the de-identification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>owner</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The number of times that the de-identification task is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunCount")]
            [Validation(Required=false)]
            public int? RunCount { get; set; }

            /// <summary>
            /// <para>The member account to which the desensitization source belongs.</para>
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
            /// <para>The type of the service to which the data to be de-identified belongs. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The type of the service to which the data to be de-identified belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
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
            /// <para>The mode in which the de-identification task is run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: manual</description></item>
            /// <item><description><b>2</b>: scheduled</description></item>
            /// <item><description><b>3</b>: manual and scheduled</description></item>
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
