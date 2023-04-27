// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUserPermissionsRequest : TeaModel {
        /// <summary>
        /// The keyword used in the query. For example, if you want to query permissions on an instance, you can specify the endpoint of the instance, such as rm-bp144d5ky4l4r****.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The ID of the database.
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The time when the permissions were granted.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// This parameter is reserved.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListUserPermissions**.
        /// </summary>
        [NameInMap("PermType")]
        [Validation(Required=false)]
        public string PermType { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   true: The database is a logical database.
        /// *   false: The database is a physical database.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The nickname of the user.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The ID of the authorization record.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
