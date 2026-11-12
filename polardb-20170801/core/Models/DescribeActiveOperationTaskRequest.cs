// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActiveOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return historical tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Returns current tasks.</description></item>
        /// <item><description><b>1</b>: Returns historical tasks.</description></item>
        /// </list>
        /// <para>Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsHistory")]
        [Validation(Required=false)]
        public int? IsHistory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The commodity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the regions and zones supported by PolarDB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can enter <b>all</b> to view all pending tasks under your account.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When <c>Region</c> is set to <b>all</b>, <c>TaskType</c> must also be set to <b>all</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task type. You can call the <a href="%E8%BF%98%E6%9C%AA%E7%94%9F%E6%88%90ID">DescribeActiveOperationTaskType</a> operation to query the task types of pending tasks.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can also enter <b>all</b> to view all pending tasks under your account.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When <c>TaskType</c> is set to <b>all</b>, <c>Region</c> must also be set to <b>all</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
