// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutonomousNotifyEventsInRangeRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568265711221</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("EventContext")]
        [Validation(Required=false)]
        public string EventContext { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-18ff4a195d****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The urgency level of the events. If you specify this parameter, the MinLevel parameter does not take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Notice</b>: events for which the system sends notifications.</description></item>
        /// <item><description><b>Optimization</b>: events that need to be optimized.</description></item>
        /// <item><description><b>Warn</b>: events for which the system sends warnings.</description></item>
        /// <item><description><b>Critical</b>: critical events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Warn</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The minimum urgency level of the events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Notice</b>: events for which the system sends notifications.</description></item>
        /// <item><description><b>Optimization</b>: events that need to be optimized.</description></item>
        /// <item><description><b>Warn</b>: events for which the system sends warnings.</description></item>
        /// <item><description><b>Critical</b>: critical events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Notice</para>
        /// </summary>
        [NameInMap("MinLevel")]
        [Validation(Required=false)]
        public string MinLevel { get; set; }

        /// <summary>
        /// <para>The ID of the node in a PolarDB for MySQL cluster. You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the node ID returned by the DBNodeId response parameter.</para>
        /// <remarks>
        /// <para> You must specify the node ID if your database instance is a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-x****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageOffset")]
        [Validation(Required=false)]
        public string PageOffset { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568269711000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}
