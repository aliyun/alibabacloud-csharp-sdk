// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ConfigBackupTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("BackupHourInDay")]
        [Validation(Required=false)]
        public long? BackupHourInDay { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-173620705****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public long? BackupPeriod { get; set; }

        [NameInMap("Manual2PeriodicList")]
        [Validation(Required=false)]
        public List<string> Manual2PeriodicList { get; set; }

        [NameInMap("Periodic2ManualList")]
        [Validation(Required=false)]
        public List<string> Periodic2ManualList { get; set; }

    }

}
