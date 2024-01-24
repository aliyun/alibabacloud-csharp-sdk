// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateInstanceAccountRequest : TeaModel {
        /// <summary>
        /// The username of the account you want to create.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbPrivilege")]
        [Validation(Required=false)]
        public List<CreateInstanceAccountRequestDbPrivilege> DbPrivilege { get; set; }
        public class CreateInstanceAccountRequestDbPrivilege : TeaModel {
            /// <summary>
            /// The name of the database that you want to manage by using the account to create.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The permissions that you want to grant to the account to manage the database.
            /// </summary>
            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

        }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance for which you want to create the account.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The password of the account you want to create.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
