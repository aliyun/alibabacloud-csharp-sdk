// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAccountAuthorityResponseBody : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Databases to which permissions have been granted.
        /// </summary>
        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public List<string> AllowDatabases { get; set; }

        /// <summary>
        /// Dictionaries to which permissions have been granted.
        /// </summary>
        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public List<string> AllowDictionaries { get; set; }

        /// <summary>
        /// Indicates whether the database account has DDL permissions. Valid values:
        /// 
        /// *   **true**: has DDL permissions.
        /// *   **false**: does not have DDL permissions.
        /// </summary>
        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        /// <summary>
        /// Indicates whether the database account has DML permissions. Valid values:
        /// 
        /// *   **all**
        /// *   **readOnly,modify**
        /// </summary>
        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// All databases.
        /// </summary>
        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public List<string> TotalDatabases { get; set; }

        /// <summary>
        /// All dictionaries.
        /// </summary>
        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public List<string> TotalDictionaries { get; set; }

    }

}
