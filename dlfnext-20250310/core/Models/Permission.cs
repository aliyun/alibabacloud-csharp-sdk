// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Permission : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DROP</para>
        /// </summary>
        [NameInMap("access")]
        [Validation(Required=false)]
        public string Access { get; set; }

        [NameInMap("columns")]
        [Validation(Required=false)]
        public PermissionColumns Columns { get; set; }
        public class PermissionColumns : TeaModel {
            [NameInMap("columnNames")]
            [Validation(Required=false)]
            public List<string> ColumnNames { get; set; }

            [NameInMap("excludedColumnNames")]
            [Validation(Required=false)]
            public List<string> ExcludedColumnNames { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>database_name</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:user/user_name</para>
        /// </summary>
        [NameInMap("principal")]
        [Validation(Required=false)]
        public string Principal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CATALOG</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("rowFilter")]
        [Validation(Required=false)]
        public RowFilter RowFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}
