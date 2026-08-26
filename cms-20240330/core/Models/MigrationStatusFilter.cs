// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MigrationStatusFilter : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter by migration rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only migrated rules (migration_status is not 0 or NULL).</description></item>
        /// <item><description>false: Only native rules (migration_status = 0).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("isMigrated")]
        [Validation(Required=false)]
        public bool? IsMigrated { get; set; }

    }

}
