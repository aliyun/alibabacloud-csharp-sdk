// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobStatusResponseBody : TeaModel {
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("MigrationJobStatus")]
        [Validation(Required=false)]
        public string MigrationJobStatus { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyMigrationMode MigrationMode { get; set; }
        public class DescribeMigrationJobStatusResponseBodyMigrationMode : TeaModel {
            [NameInMap("dataInitialization")]
            [Validation(Required=false)]
            public bool? DataInitialization { get; set; }
            [NameInMap("structureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }
            [NameInMap("dataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }
        };

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyPrecheckStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail Detail { get; set; }
            public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public List<DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem> CheckItem { get; set; }
                public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("RepairMethod")]
                    [Validation(Required=false)]
                    public string RepairMethod { get; set; }

                }

            }
        };

        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDestinationEndpoint : TeaModel {
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }
        };

        [NameInMap("MigrationJobClass")]
        [Validation(Required=false)]
        public string MigrationJobClass { get; set; }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodySourceEndpoint : TeaModel {
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }
        };

        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }
        };

    }

}
