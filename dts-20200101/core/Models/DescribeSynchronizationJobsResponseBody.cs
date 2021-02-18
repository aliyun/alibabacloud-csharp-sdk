// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobsResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("SynchronizationInstances")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobsResponseBodySynchronizationInstances> SynchronizationInstances { get; set; }
        public class DescribeSynchronizationJobsResponseBodySynchronizationInstances : TeaModel {
            [NameInMap("SynchronizationJobName")]
            [Validation(Required=false)]
            public string SynchronizationJobName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DataInitialization")]
            [Validation(Required=false)]
            public string DataInitialization { get; set; }

            [NameInMap("Performance")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesPerformance Performance { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPerformance : TeaModel {
                [NameInMap("FLOW")]
                [Validation(Required=false)]
                public string FLOW { get; set; }
                [NameInMap("RPS")]
                [Validation(Required=false)]
                public string RPS { get; set; }
            };

            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatus PrecheckStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatusDetail> Detail { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatusDetail : TeaModel {
                    public string CheckStatus { get; set; }
                    public string ErrorMessage { get; set; }
                    public string ItemName { get; set; }
                    public string RepairMethod { get; set; }
                }
            };

            [NameInMap("StructureInitializationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesStructureInitializationStatus StructureInitializationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesStructureInitializationStatus : TeaModel {
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

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("SynchronizationObjects")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjects> SynchronizationObjects { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjects : TeaModel {
                [NameInMap("NewSchemaName")]
                [Validation(Required=false)]
                public string NewSchemaName { get; set; }

                [NameInMap("TableIncludes")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableIncludes> TableIncludes { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableIncludes : TeaModel {
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                [NameInMap("TableExcludes")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableExcludes> TableExcludes { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableExcludes : TeaModel {
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("StructureInitialization")]
            [Validation(Required=false)]
            public string StructureInitialization { get; set; }

            [NameInMap("SynchronizationJobClass")]
            [Validation(Required=false)]
            public string SynchronizationJobClass { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesTags> Tags { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DataInitializationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataInitializationStatus DataInitializationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataInitializationStatus : TeaModel {
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
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDestinationEndpoint DestinationEndpoint { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDestinationEndpoint : TeaModel {
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
                [NameInMap("EngineName")]
                [Validation(Required=false)]
                public string EngineName { get; set; }
            };

            [NameInMap("DataSynchronizationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataSynchronizationStatus DataSynchronizationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataSynchronizationStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public string Delay { get; set; }
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }
            };

            [NameInMap("SourceEndpoint")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesSourceEndpoint SourceEndpoint { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSourceEndpoint : TeaModel {
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
                [NameInMap("EngineName")]
                [Validation(Required=false)]
                public string EngineName { get; set; }
            };

            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            [NameInMap("SynchronizationDirection")]
            [Validation(Required=false)]
            public string SynchronizationDirection { get; set; }

        }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
