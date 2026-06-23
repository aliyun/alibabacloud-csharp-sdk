// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUploadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end time in ISO 8601 format (for example, 2024-01-01T00:00:00+Z).</para>
        /// <remarks>
        /// <para>Notice: StartTime and EndTime must be provided together to define the query time window. An error is returned if either one is missing..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-06T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain this value by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required when you call the ListUploadTasks operation..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The start time in ISO 8601 format (for example, 2024-01-01T00:00:00+Z).</para>
        /// <remarks>
        /// <para>Notice: StartTime and EndTime must be provided together to define the query time window. An error is returned if either one is missing..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-11-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b>: URL file purge.</description></item>
        /// <item><description><b>preload</b>: resource prefetch.</description></item>
        /// <item><description><b>directory</b>: directory purge.</description></item>
        /// <item><description><b>ignoreparams</b>: purge with parameters ignored.</description></item>
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
