// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateScheduledBackupConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("dataKeepQuantity")]
        [Validation(Required=false)]
        public int? DataKeepQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("dstRegion")]
        [Validation(Required=false)]
        public string DstRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("hour")]
        [Validation(Required=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hgprecn-cn-zvp25ysxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("manualDataKeepQuantity")]
        [Validation(Required=false)]
        public int? ManualDataKeepQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>remote</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1,3,5</para>
        /// </summary>
        [NameInMap("week")]
        [Validation(Required=false)]
        public string Week { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
