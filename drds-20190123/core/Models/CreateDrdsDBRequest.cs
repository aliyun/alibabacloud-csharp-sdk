// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsDBRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        [NameInMap("DbInstanceIsCreating")]
        [Validation(Required=false)]
        public bool? DbInstanceIsCreating { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        [NameInMap("InstDbName")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestInstDbName> InstDbName { get; set; }
        public class CreateDrdsDBRequestInstDbName : TeaModel {
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("ShardDbName")]
            [Validation(Required=false)]
            public List<string> ShardDbName { get; set; }

        }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RdsInstance")]
        [Validation(Required=false)]
        public List<string> RdsInstance { get; set; }

        [NameInMap("RdsSuperAccount")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestRdsSuperAccount> RdsSuperAccount { get; set; }
        public class CreateDrdsDBRequestRdsSuperAccount : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
