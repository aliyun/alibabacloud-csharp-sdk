// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("MigrationJobs")]
        [Validation(Required=false)]
        public DescribeMigrationJobsResponseBodyMigrationJobs MigrationJobs { get; set; }
        public class DescribeMigrationJobsResponseBodyMigrationJobs : TeaModel {
            [NameInMap("MigrationJob")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob> MigrationJob { get; set; }
            public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob : TeaModel {
                public string MigrationJobName { get; set; }
                public string MigrationJobStatus { get; set; }
                public string PayType { get; set; }
                public string MigrationJobClass { get; set; }
                public string InstanceCreateTime { get; set; }
                public string MigrationJobID { get; set; }
                public string JobCreateTime { get; set; }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject MigrationObject { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject : TeaModel {
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }
                        };

                    }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTags Tags { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTagsTag> Tag { get; set; }
                    public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization DataInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization : TeaModel {
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization DataSynchronization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization : TeaModel {
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public string Delay { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint DestinationEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint : TeaModel {
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                }
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
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck Precheck { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint : TeaModel {
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                }
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization StructureInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization : TeaModel {
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                }
            }
        };

    }

}
