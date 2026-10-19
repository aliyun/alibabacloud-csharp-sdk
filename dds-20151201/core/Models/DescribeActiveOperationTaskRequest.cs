// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return historical tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: returns current tasks. This is the default value.</description></item>
        /// <item><description>1: returns historical tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>The page number. The value must be greater than 0 and not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. The value must be greater than 10. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the pending events belong. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query region IDs. If you set this parameter to all, all tasks under the current account are queried, and the TaskType parameter must also be set to all.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rds_apsaradb_ha: primary/secondary node switch.</description></item>
        /// <item><description>rds_apsaradb_transfer: instance migration.</description></item>
        /// <item><description>rds_apsaradb_upgrade: minor version update.</description></item>
        /// </list>
        /// <para>You can obtain the valid values from the <a href="https://help.aliyun.com/document_detail/2639186.html">DescribeHistoryTasks</a> operation.</para>
        /// <para>If you set this parameter to all, all tasks under the current account are queried, and the Region parameter must also be set to all.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_apsaradb_ha</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
