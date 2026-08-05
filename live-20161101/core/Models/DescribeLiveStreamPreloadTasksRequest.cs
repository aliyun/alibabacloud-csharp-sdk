// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamPreloadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time in ISO 8601 format in UTC. Format: yyyy-MM-ddTHH:mm:ssZ. The interval between EndTime and StartTime cannot exceed 3 days.</para>
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
        /// <para>The page number to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Valid values: any integer from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The live streaming URL. You can specify multiple URLs separated by commas (,), up to 100.</para>
        /// </summary>
        [NameInMap("PlayUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time in ISO 8601 format in UTC. Format: yyyy-MM-ddTHH:mm:ssZ. The start time must be within the last 3 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>complete: completed.</description></item>
        /// <item><description>pending: waiting for preload.</description></item>
        /// <item><description>preloading: preloading in progress.</description></item>
        /// <item><description>failed: preload failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. You can obtain the preload task ID by calling the <a href="https://help.aliyun.com/document_detail/2519938.html">SetLiveStreamPreloadTasks</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
