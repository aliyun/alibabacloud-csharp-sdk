// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class MigrateInstanceZoneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target availability zone. Call the <c>ListMigrationZones</c> operation to confirm that the target availability zone meets the migration requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
