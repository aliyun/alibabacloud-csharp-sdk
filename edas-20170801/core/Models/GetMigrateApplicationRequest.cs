// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetMigrateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The migration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afe9995d-31fd-40ff-a669-c125d76d8267</para>
        /// </summary>
        [NameInMap("migrationId")]
        [Validation(Required=false)]
        public string MigrationId { get; set; }

        /// <summary>
        /// <para>The operation type of the migration task. Valid values: 1: import. 2: export. 3: clone. If this parameter is not specified, all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("migrationType")]
        [Validation(Required=false)]
        public long? MigrationType { get; set; }

        /// <summary>
        /// <para>regionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
