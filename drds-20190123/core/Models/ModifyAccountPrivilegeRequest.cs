// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyAccountPrivilegeRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbPrivilege")]
        [Validation(Required=false)]
        public List<ModifyAccountPrivilegeRequestDbPrivilege> DbPrivilege { get; set; }
        public class ModifyAccountPrivilegeRequestDbPrivilege : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
