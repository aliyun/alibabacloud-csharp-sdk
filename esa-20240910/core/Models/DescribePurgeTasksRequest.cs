// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribePurgeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The content to purge. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://a.com/1.jpg?b=1">http://a.com/1.jpg?b=1</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-18T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-16T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Complete</b>: The task is complete.</description></item>
        /// <item><description><b>Refreshing</b>: The task is in progress.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): purges the cache by file.</description></item>
        /// <item><description><b>cachetag</b>: purges the cache by cache tag.</description></item>
        /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
        /// <item><description><b>ignoreParams</b>: purges the cache by URL with specified parameters ignored.</description></item>
        /// <item><description><b>hostname</b>: purges the cache by hostname.</description></item>
        /// <item><description><b>purgeall</b>: purges all cache.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
