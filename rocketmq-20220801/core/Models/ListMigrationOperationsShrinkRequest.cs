// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMigrationOperationsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The operation business status.</para>
        /// </summary>
        [NameInMap("businessStatus")]
        [Validation(Required=false)]
        public string BusinessStatusShrink { get; set; }

        /// <summary>
        /// <para>The filter condition for the query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Supports filtering by operationKey, which is the topic name.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-zxu37eiqq0x</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The operation status.</para>
        /// </summary>
        [NameInMap("operationStatus")]
        [Validation(Required=false)]
        public string OperationStatusShrink { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIGRATE_MESSAGE</para>
        /// </summary>
        [NameInMap("operationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size, which specifies the maximum number of results to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
