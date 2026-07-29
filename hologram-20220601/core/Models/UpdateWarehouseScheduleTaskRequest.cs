// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateWarehouseScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The number of CUs to add. The value must be a multiple of 16, be at least 16, and not exceed the current warehouse size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("elasticCu")]
        [Validation(Required=false)]
        public long? ElasticCu { get; set; }

        /// <summary>
        /// <para>The end time. The time must be in 24-hour HHmm format, on the hour or half-hour. The end time must be later than the start time. For example, <c>0030</c>, <c>0100</c>, and <c>0400</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0400</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The elastic schedule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1980869072412614657</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The start time. The time must be in 24-hour HHmm format, on the hour or half-hour. For example, <c>0030</c>, <c>0100</c>, and <c>0400</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0200</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The warehouse ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("warehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
