// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateWarehouseScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>A description of the warehouse schedule task.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of elastic compute units.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("elasticCu")]
        [Validation(Required=false)]
        public long? ElasticCu { get; set; }

        /// <summary>
        /// <para>The UTC end time of the task, in ISO 8601 format.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The UTC start time of the task, in ISO 8601 format.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the warehouse.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("warehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
