// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudBenchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993001</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The value must be a positive integer. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SUCCESS</b>: The task is successful.</para>
        /// </description></item>
        /// <item><description><para><b>IGNORED</b>: The task is ignored.</para>
        /// </description></item>
        /// <item><description><para><b>RUNNING</b>: The task is running.</para>
        /// </description></item>
        /// <item><description><para><b>EXCEPTION</b>: The task is abnormal.</para>
        /// </description></item>
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
        /// <item><description><para><b>pressure test</b> (default): A stress testing task that replays the traffic captured from the source instance on the destination instance at the maximum playback rate that is supported by the destination instance.</para>
        /// </description></item>
        /// <item><description><para><b>smart pressure test</b>: A stress testing task that is generated to perform continuous stress testing. The task analyzes the traffic that is captured from a source instance in a short period of time and generates traffic that is similar to the traffic on the source instance in terms of business model and traffic distribution. This reduces the time that is required to collect data from the source instance and lowers the costs of storage and performance.</para>
        /// </description></item>
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
