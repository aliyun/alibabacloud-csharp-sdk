// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display the response history of the asynchronous API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: displays the current response and response history of the asynchronous API operation.</description></item>
        /// <item><description>false: displays only the current response of the asynchronous API operation. If no tasks are running, <c>[]</c> is returned.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para> If you specify the TaskId parameter, the Archived parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Valid values: 1 to 999.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the following asynchronous API operations to obtain the task ID.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/87100.html">CreateCluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/200345.html">StartCluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/200346.html">StopCluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87110.html">DeleteCluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87147.html">AddNodes</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87159.html">StartNodes</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87158.html">ResetNodes</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87160.html">StopNodes</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/87155.html">DeleteNodes</a></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
