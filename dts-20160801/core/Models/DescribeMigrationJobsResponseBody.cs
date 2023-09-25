// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class DescribeMigrationJobsResponseBody : TeaModel {
        [NameInMap("MigrationJobs")]
        [Validation(Required=false)]
        public DescribeMigrationJobsResponseBodyMigrationJobs MigrationJobs { get; set; }
        public class DescribeMigrationJobsResponseBodyMigrationJobs : TeaModel {
            [NameInMap("MigrationJob")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob> MigrationJob { get; set; }
            public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob : TeaModel {
                [NameInMap("DataInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization DataInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization : TeaModel {
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("DataSynchronization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization DataSynchronization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization : TeaModel {
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public string Delay { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("DestinationEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint DestinationEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint : TeaModel {
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                [NameInMap("MigrationJobClass")]
                [Validation(Required=false)]
                public string MigrationJobClass { get; set; }

                [NameInMap("MigrationJobID")]
                [Validation(Required=false)]
                public string MigrationJobID { get; set; }

                [NameInMap("MigrationJobName")]
                [Validation(Required=false)]
                public string MigrationJobName { get; set; }

                [NameInMap("MigrationJobStatus")]
                [Validation(Required=false)]
                public string MigrationJobStatus { get; set; }

                [NameInMap("MigrationMode")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode MigrationMode { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode : TeaModel {
                    [NameInMap("DataInitialization")]
                    [Validation(Required=false)]
                    public bool? DataInitialization { get; set; }

                    [NameInMap("DataSynchronization")]
                    [Validation(Required=false)]
                    public bool? DataSynchronization { get; set; }

                    [NameInMap("StructureInitialization")]
                    [Validation(Required=false)]
                    public bool? StructureInitialization { get; set; }

                }

                [NameInMap("MigrationObject")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject MigrationObject { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject : TeaModel {
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }

                        }

                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                    }

                }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Precheck")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck Precheck { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck : TeaModel {
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint : TeaModel {
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                [NameInMap("StructureInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization StructureInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization : TeaModel {
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
