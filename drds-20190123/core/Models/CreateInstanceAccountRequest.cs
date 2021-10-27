// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateInstanceAccountRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbPrivilege")]
        [Validation(Required=false)]
        public List<CreateInstanceAccountRequestDbPrivilege> DbPrivilege { get; set; }
        public class CreateInstanceAccountRequestDbPrivilege : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

        }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
