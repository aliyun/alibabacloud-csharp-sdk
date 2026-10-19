// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return historical tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): Returns current tasks.</description></item>
        /// <item><description><b>1</b>: Returns historical tasks.</description></item>
        /// </list>
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
        /// <para>The page number. The value must be greater than <b>0</b> and cannot exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. The value must be greater than <b>10</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <remarks>
        /// <para>Set this parameter to <b>all</b> to specify all region IDs.</para>
        /// </remarks>
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
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rds_apsaradb_ha</b>: node failover.</description></item>
        /// <item><description><b>rds_apsaradb_transfer</b>: instance migration.</description></item>
        /// <item><description><b>rds_apsaradb_upgrade</b>: minor engine version update.</description></item>
        /// </list>
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
