// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudBenchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The end time of the query task must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993001</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. The value must be greater than 0 and cannot exceed the maximum value of the Integer data type. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The running status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SUCCESS</b>: Successful.</description></item>
        /// <item><description><b>IGNORED</b>: Ignored.</description></item>
        /// <item><description><b>RUNNING</b>: Running.</description></item>
        /// <item><description><b>EXCEPTION</b>: Exception.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the stress testing task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pressure test</b> (default): intelligent stress testing. Traffic captured from the target instance is replayed on the destination instance at the maximum speed supported by the destination instance specifications.</description></item>
        /// <item><description><b>smart pressure test</b>: generated stress testing. By analyzing and learning from traffic captured from the target instance within a short period, traffic that is consistent with the business model and traffic distribution of the original traffic is generated for continuous stress testing. This reduces the time required to collect data from the target instance and lowers storage costs and performance overhead.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pressure test</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
