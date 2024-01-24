// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// The username of the account that you want to modify.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbPrivilege")]
        [Validation(Required=false)]
        public List<ModifyAccountPrivilegeRequestDbPrivilege> DbPrivilege { get; set; }
        public class ModifyAccountPrivilegeRequestDbPrivilege : TeaModel {
            /// <summary>
            /// The name of the database that you want to manage by using the account to modify.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The permissions that you want to grant to the account.
            /// </summary>
            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

        }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the PolarDB-X 1.0 instance is located.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
