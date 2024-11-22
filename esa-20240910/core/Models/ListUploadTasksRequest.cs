// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUploadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The time when the task ends. Specify the time in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-06T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The time when the task starts. Specify the time in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
        /// <item><description><b>file</b>: purges the cache by file URL.</description></item>
        /// <item><description><b>preload</b>: prefetches files.</description></item>
        /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
        /// <item><description><b>ignoreparams</b>: purges the cache by URL with specified parameters ignored.</description></item>
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
