// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GrantDatabasePermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("privileges")]
        [Validation(Required=false)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p4_123444xxx</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
