// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobsResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DtsJobList")]
        [Validation(Required=false)]
        public List<DescribeDtsJobsResponseBodyDtsJobList> DtsJobList { get; set; }
        public class DescribeDtsJobsResponseBodyDtsJobList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Reserved")]
            [Validation(Required=false)]
            public string Reserved { get; set; }

            [NameInMap("ConsumptionClient")]
            [Validation(Required=false)]
            public string ConsumptionClient { get; set; }

            [NameInMap("DbObject")]
            [Validation(Required=false)]
            public string DbObject { get; set; }

            [NameInMap("DtsJobClass")]
            [Validation(Required=false)]
            public string DtsJobClass { get; set; }

            [NameInMap("ConsumptionCheckpoint")]
            [Validation(Required=false)]
            public string ConsumptionCheckpoint { get; set; }

            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public string EndTimestamp { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("BeginTimestamp")]
            [Validation(Required=false)]
            public string BeginTimestamp { get; set; }

            [NameInMap("DtsInstanceID")]
            [Validation(Required=false)]
            public string DtsInstanceID { get; set; }

            [NameInMap("DtsJobDirection")]
            [Validation(Required=false)]
            public string DtsJobDirection { get; set; }

            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeDtsJobsResponseBodyDtsJobListTagList> TagList { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListTagList : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("DataInitializationStatus")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListDataInitializationStatus DataInitializationStatus { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListDataInitializationStatus : TeaModel {
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
            public DescribeDtsJobsResponseBodyDtsJobListDataSynchronizationStatus DataSynchronizationStatus { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListDataSynchronizationStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("NeedUpgrade")]
                [Validation(Required=false)]
                public bool? NeedUpgrade { get; set; }
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
            };

            [NameInMap("DataEtlStatus")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListDataEtlStatus DataEtlStatus { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListDataEtlStatus : TeaModel {
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

            [NameInMap("DestinationEndpoint")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListDestinationEndpoint DestinationEndpoint { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListDestinationEndpoint : TeaModel {
                [NameInMap("SslSolutionEnum")]
                [Validation(Required=false)]
                public string SslSolutionEnum { get; set; }
                [NameInMap("OracleSID")]
                [Validation(Required=false)]
                public string OracleSID { get; set; }
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }
                [NameInMap("EngineName")]
                [Validation(Required=false)]
                public string EngineName { get; set; }
            };

            [NameInMap("MigrationMode")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListMigrationMode MigrationMode { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListMigrationMode : TeaModel {
                [NameInMap("DataInitialization")]
                [Validation(Required=false)]
                public bool? DataInitialization { get; set; }
                [NameInMap("DataSynchronization")]
                [Validation(Required=false)]
                public bool? DataSynchronization { get; set; }
                [NameInMap("StructureInitialization")]
                [Validation(Required=false)]
                public bool? StructureInitialization { get; set; }
            };

            [NameInMap("Performance")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListPerformance Performance { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListPerformance : TeaModel {
                [NameInMap("Rps")]
                [Validation(Required=false)]
                public string Rps { get; set; }
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }
            };

            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListPrecheckStatus PrecheckStatus { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListPrecheckStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<DescribeDtsJobsResponseBodyDtsJobListPrecheckStatusDetail> Detail { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListPrecheckStatusDetail : TeaModel {
                    public string CheckResult { get; set; }
                    public string CheckItemDescription { get; set; }
                    public string CheckItem { get; set; }
                    public string RepairMethod { get; set; }
                    public string FailedReason { get; set; }
                }
            };

            [NameInMap("ReverseJob")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListReverseJob ReverseJob { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListReverseJob : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("DtsJobName")]
                [Validation(Required=false)]
                public string DtsJobName { get; set; }
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }
                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public string Reserved { get; set; }
                [NameInMap("DbObject")]
                [Validation(Required=false)]
                public string DbObject { get; set; }
                [NameInMap("DtsJobClass")]
                [Validation(Required=false)]
                public string DtsJobClass { get; set; }
                [NameInMap("DtsInstanceID")]
                [Validation(Required=false)]
                public string DtsInstanceID { get; set; }
                [NameInMap("DtsJobDirection")]
                [Validation(Required=false)]
                public string DtsJobDirection { get; set; }
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }
                [NameInMap("DataInitializationStatus")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobDataInitializationStatus DataInitializationStatus { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobDataInitializationStatus : TeaModel {
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

                }
                [NameInMap("DataSynchronizationStatus")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobDataSynchronizationStatus DataSynchronizationStatus { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobDataSynchronizationStatus : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("NeedUpgrade")]
                    [Validation(Required=false)]
                    public bool? NeedUpgrade { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }
                [NameInMap("DestinationEndpoint")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobDestinationEndpoint DestinationEndpoint { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobDestinationEndpoint : TeaModel {
                    [NameInMap("SslSolutionEnum")]
                    [Validation(Required=false)]
                    public string SslSolutionEnum { get; set; }

                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

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
                [NameInMap("MigrationMode")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobMigrationMode MigrationMode { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobMigrationMode : TeaModel {
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
                [NameInMap("Performance")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobPerformance Performance { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobPerformance : TeaModel {
                    [NameInMap("Rps")]
                    [Validation(Required=false)]
                    public string Rps { get; set; }

                    [NameInMap("Flow")]
                    [Validation(Required=false)]
                    public string Flow { get; set; }

                }
                [NameInMap("PrecheckStatus")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobPrecheckStatus PrecheckStatus { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobPrecheckStatus : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public List<DescribeDtsJobsResponseBodyDtsJobListReverseJobPrecheckStatusDetail> Detail { get; set; }
                    public class DescribeDtsJobsResponseBodyDtsJobListReverseJobPrecheckStatusDetail : TeaModel {
                        [NameInMap("CheckResult")]
                        [Validation(Required=false)]
                        public string CheckResult { get; set; }

                        [NameInMap("CheckItemDescription")]
                        [Validation(Required=false)]
                        public string CheckItemDescription { get; set; }

                        [NameInMap("CheckItem")]
                        [Validation(Required=false)]
                        public string CheckItem { get; set; }

                        [NameInMap("RepairMethod")]
                        [Validation(Required=false)]
                        public string RepairMethod { get; set; }

                        [NameInMap("FailedReason")]
                        [Validation(Required=false)]
                        public string FailedReason { get; set; }

                    }

                }
                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobSourceEndpoint : TeaModel {
                    [NameInMap("SslSolutionEnum")]
                    [Validation(Required=false)]
                    public string SslSolutionEnum { get; set; }

                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

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
                [NameInMap("StructureInitializationStatus")]
                [Validation(Required=false)]
                public DescribeDtsJobsResponseBodyDtsJobListReverseJobStructureInitializationStatus StructureInitializationStatus { get; set; }
                public class DescribeDtsJobsResponseBodyDtsJobListReverseJobStructureInitializationStatus : TeaModel {
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

                }
            };

            [NameInMap("SourceEndpoint")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListSourceEndpoint SourceEndpoint { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListSourceEndpoint : TeaModel {
                [NameInMap("SslSolutionEnum")]
                [Validation(Required=false)]
                public string SslSolutionEnum { get; set; }
                [NameInMap("OracleSID")]
                [Validation(Required=false)]
                public string OracleSID { get; set; }
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }
                [NameInMap("EngineName")]
                [Validation(Required=false)]
                public string EngineName { get; set; }
            };

            [NameInMap("StructureInitializationStatus")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListStructureInitializationStatus StructureInitializationStatus { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListStructureInitializationStatus : TeaModel {
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

            [NameInMap("RetryState")]
            [Validation(Required=false)]
            public DescribeDtsJobsResponseBodyDtsJobListRetryState RetryState { get; set; }
            public class DescribeDtsJobsResponseBodyDtsJobListRetryState : TeaModel {
                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public int? RetryCount { get; set; }
                [NameInMap("MaxRetryTime")]
                [Validation(Required=false)]
                public int? MaxRetryTime { get; set; }
                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }
                [NameInMap("RetryTarget")]
                [Validation(Required=false)]
                public string RetryTarget { get; set; }
                [NameInMap("RetryTime")]
                [Validation(Required=false)]
                public int? RetryTime { get; set; }
            };

        }

    }

}
