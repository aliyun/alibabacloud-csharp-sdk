// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTasksRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name in each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-01T12:13:20Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The path of the object. The path is used as a condition for exact matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/examplefile.txt">http://example.com/examplefile.txt</a></para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// <para>The type of the task.</para>
        /// <list type="bullet">
        /// <item><description><b>file</b>: URL-based refresh</description></item>
        /// <item><description><b>directory</b>: directory-based refresh</description></item>
        /// <item><description><b>preload</b>: URL-based prefetch</description></item>
        /// </list>
        /// <para>If you set <b>DomainName</b> or <b>Status</b>, you must also set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Valid values: <b>1</b> to <b>100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>. Maximum value: <b>50</b>. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-01T12:12:20Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
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
        /// <para>The ID of the task. A task ID is assigned when you create a refresh or prefetch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>704225667</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
