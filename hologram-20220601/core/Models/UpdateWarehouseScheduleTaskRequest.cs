// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateWarehouseScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The number of CPU cores to scale out. The value must be a multiple of 16, greater than or equal to 16, and less than or equal to the specifications of the current compute group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("elasticCu")]
        [Validation(Required=false)]
        public long? ElasticCu { get; set; }

        /// <summary>
        /// <para>The end time. The format is HHmm (four digits, 24-hour clock). The time must be on the hour or half hour, such as 0030, 0100, or 0400. The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0400</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The elastic plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1980869072412614657</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The start time. The format is HHmm (four digits, 24-hour clock). The time must be on the hour or half hour, such as 0030, 0100, or 0400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0200</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The compute group ID.</para>
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
