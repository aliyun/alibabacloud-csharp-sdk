// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribePreloadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The content to prefetch. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://a.com/1.jpg?b=2">http://a.com/1.jpg?b=2</a></para>
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
        /// <para>2023-03-23T06:23:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: <b>1</b> to <b>100000</b>. Default value: <b>1</b>.</para>
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
        /// <para>2023-03-22T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Complete</b>: The task is complete.</description></item>
        /// <item><description><b>Refreshing</b>: The task is running.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
