// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyAccountAuthorityRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The databases to which you want to grant permissions. Separate databases with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public string AllowDatabases { get; set; }

        /// <summary>
        /// The dictionaries to which you want to grant permissions. Separate dictionaries with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public string AllowDictionaries { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to grant DDL permissions to the database account. Valid values:
        /// 
        /// *   **true**: grants DDL permissions to the database account.
        /// *   **false**: does not grant DDL permissions to the database account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        /// <summary>
        /// Specifies whether to grant DML permissions to the database account. Valid values:
        /// 
        /// *   **all**
        /// *   **readonly,modify**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/170875.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// All databases. Separate databases with commas (,).
        /// </summary>
        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public string TotalDatabases { get; set; }

        /// <summary>
        /// All dictionaries. Separate dictionaries with commas (,).
        /// </summary>
        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public string TotalDictionaries { get; set; }

    }

}
