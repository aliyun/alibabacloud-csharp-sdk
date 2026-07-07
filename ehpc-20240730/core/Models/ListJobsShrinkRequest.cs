// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListJobsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-csbua72***</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The job filter information.</para>
        /// </summary>
        [NameInMap("JobFilter")]
        [Validation(Required=false)]
        public string JobFilterShrink { get; set; }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page when using paged query. Paging is applied to the results.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 50.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
