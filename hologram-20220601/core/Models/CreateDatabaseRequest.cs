// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The permission model of the database.</para>
        /// </summary>
        [NameInMap("permissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

    }

}
