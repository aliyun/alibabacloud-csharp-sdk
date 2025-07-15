// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamPreloadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-06-30T19:00:00Z. The interval between the start time and end time cannot exceed three days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The streaming URL. You can specify up to 100 streaming URLs in a request. Separate multiple streaming URLs with commas (,).</para>
        /// </summary>
        [NameInMap("PlayUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-06-29T19:00:00Z. You can query only data in the previous three days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the prefetch task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>complete</description></item>
        /// <item><description>pending</description></item>
        /// <item><description>preloading</description></item>
        /// <item><description>failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the prefetch task. The task ID is returned when you call the <a href="https://help.aliyun.com/document_detail/2519938.html">SetLiveStreamPreloadTasks</a> operation to configure the prefetch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
