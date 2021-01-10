// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateCasDatabaseRequest : TeaModel {
        [NameInMap("DatabaseSchemaJsonStr")]
        [Validation(Required=false)]
        public string DatabaseSchemaJsonStr { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public string SpecId { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("AppIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppIdsRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServiceIdsRepeatList { get; set; }

        [NameInMap("DatabaseAccounts")]
        [Validation(Required=false)]
        public List<CreateCasDatabaseRequestDatabaseAccounts> DatabaseAccounts { get; set; }
        public class CreateCasDatabaseRequestDatabaseAccounts : TeaModel {
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
