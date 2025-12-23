// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListScheduledTasksRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scheduled task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>wipe: data cleaning.</description></item>
        /// <item><description>fork: reindexing.</description></item>
        /// <item><description>check-status: application status check.</description></item>
        /// <item><description>index: reindexing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wipe</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
