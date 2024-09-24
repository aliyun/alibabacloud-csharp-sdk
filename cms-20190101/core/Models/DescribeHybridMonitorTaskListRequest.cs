// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the returned result includes metric import tasks for Alibaba Cloud services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): The returned result includes metric import tasks for Alibaba Cloud services.</description></item>
        /// <item><description>false: The returned result excludes metric import tasks for Alibaba Cloud services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeAliyunTask")]
        [Validation(Required=false)]
        public bool? IncludeAliyunTask { get; set; }

        /// <summary>
        /// <para>The keyword that is used for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>For information about how to obtain the name of a namespace, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Pages start from page 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member account.</para>
        /// <remarks>
        /// <para>This parameter is required only if you use a management account to call this operation to delete the metric import tasks that belong to a member in a resource directory. In this case, the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// <para>The ID of the metric import task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the metric import task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliyun_fc: metric import tasks for Alibaba Cloud services</description></item>
        /// <item><description>aliyun_sls: metrics for logs imported from Log Service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_fc</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
