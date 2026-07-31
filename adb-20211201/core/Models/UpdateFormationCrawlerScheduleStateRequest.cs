// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateFormationCrawlerScheduleStateRequest : TeaModel {
        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>247</para>
        /// </summary>
        [NameInMap("CrawlerTaskId")]
        [Validation(Required=false)]
        public long? CrawlerTaskId { get; set; }

        /// <summary>
        /// <para>The name of the crawler task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-crawler-dbname</para>
        /// </summary>
        [NameInMap("CrawlerTaskName")]
        [Validation(Required=false)]
        public string CrawlerTaskName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1565u55p32****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the region ID of the cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scheduling state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL: resume.</para>
        /// </description></item>
        /// <item><description><para>DISABLED: pause.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISABLED</para>
        /// </summary>
        [NameInMap("ScheduleState")]
        [Validation(Required=false)]
        public string ScheduleState { get; set; }

    }

}
