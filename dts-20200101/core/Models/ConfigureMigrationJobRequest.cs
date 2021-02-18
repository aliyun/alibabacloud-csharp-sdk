/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureMigrationJobRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureMigrationJobRequestSourceEndpoint : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
        };

        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureMigrationJobRequestDestinationEndpoint : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
        };

        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestMigrationMode MigrationMode { get; set; }
        public class ConfigureMigrationJobRequestMigrationMode : TeaModel {
            [NameInMap("StructureIntialization")]
            [Validation(Required=false)]
            public bool? StructureIntialization { get; set; }
            [NameInMap("DataIntialization")]
            [Validation(Required=false)]
            public bool? DataIntialization { get; set; }
            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }
        };

        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
