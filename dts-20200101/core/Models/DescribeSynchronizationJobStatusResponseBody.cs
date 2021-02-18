// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusResponseBody : TeaModel {
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus : TeaModel {
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

        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjects> SynchronizationObjects { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjects : TeaModel {
            [NameInMap("NewSchemaName")]
            [Validation(Required=false)]
            public string NewSchemaName { get; set; }

            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes> TableIncludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes : TeaModel {
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TableExcludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes> TableExcludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes : TeaModel {
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

        }

        [NameInMap("Delay")]
        [Validation(Required=false)]
        public string Delay { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("DelayMillis")]
        [Validation(Required=false)]
        public long? DelayMillis { get; set; }

        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public string DataInitialization { get; set; }

        [NameInMap("SynchronizationJobClass")]
        [Validation(Required=false)]
        public string SynchronizationJobClass { get; set; }

        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
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
            [NameInMap("DelayMillis")]
            [Validation(Required=false)]
            public long? DelayMillis { get; set; }
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
                public string CheckStatus { get; set; }
                public string ErrorMessage { get; set; }
                public string ItemName { get; set; }
                public string RepairMethod { get; set; }
            }
        };

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint : TeaModel {
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

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySourceEndpoint : TeaModel {
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

        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public string StructureInitialization { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("Performance")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPerformance Performance { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPerformance : TeaModel {
            [NameInMap("FLOW")]
            [Validation(Required=false)]
            public string FLOW { get; set; }
            [NameInMap("RPS")]
            [Validation(Required=false)]
            public string RPS { get; set; }
        };

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
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

    }

}
