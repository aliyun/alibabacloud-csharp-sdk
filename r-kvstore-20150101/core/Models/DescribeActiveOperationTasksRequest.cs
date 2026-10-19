// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the event can be canceled. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all events.</description></item>
        /// <item><description><b>0</b>: returns only O&amp;M events that cannot be canceled.</description></item>
        /// <item><description><b>1</b>: returns only O&amp;M events that can be canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the event time can be modified. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all events.</description></item>
        /// <item><description><b>0</b>: returns only O&amp;M events whose time cannot be modified.</description></item>
        /// <item><description><b>1</b>: returns only O&amp;M events whose time can be modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The change level. Default value: all. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all levels including exception recovery and system O&amp;M.</description></item>
        /// <item><description><b>S0</b>: exception recovery.</description></item>
        /// <item><description><b>S1</b>: system O&amp;M.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Set this parameter to <b>redis</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The instance name. This parameter is optional. If specified, only one instance name is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-wz96fzmpvpr2qnqnlb</para>
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 25. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product name. Valid values: RDS, POLARDB, MongoDB, and Redis. For Redis instances, set this parameter to Redis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query available region IDs.</para>
        /// <remarks>
        /// <para>Set this parameter to <b>all</b> to query events in all regions.</para>
        /// </remarks>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The status of the O&amp;M event. This parameter is used to filter the returned events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all events.</description></item>
        /// <item><description><b>3</b>: pending events.</description></item>
        /// <item><description><b>4</b>: events being processed.</description></item>
        /// <item><description><b>5</b>: events that ended successfully.</description></item>
        /// <item><description><b>6</b>: events that ended with failures.</description></item>
        /// <item><description><b>7</b>: canceled events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The event type of the O&amp;M event. If this parameter is left empty, all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_apsradb_transfer</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
