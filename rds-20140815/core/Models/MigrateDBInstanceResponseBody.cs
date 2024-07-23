// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The serial number of the task in the migration task queue. When the serial number becomes 0, the system starts the migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224****</para>
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public int? MigrationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498AE8CA-8C81-4A01-AF37-2B902014ED30</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10824****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
