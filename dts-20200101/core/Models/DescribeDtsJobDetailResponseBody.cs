// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobDetailResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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

        [NameInMap("DatabaseCount")]
        [Validation(Required=false)]
        public int? DatabaseCount { get; set; }

        [NameInMap("DtsJobClass")]
        [Validation(Required=false)]
        public string DtsJobClass { get; set; }

        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DestNetType")]
        [Validation(Required=false)]
        public string DestNetType { get; set; }

        [NameInMap("SubscribeTopic")]
        [Validation(Required=false)]
        public string SubscribeTopic { get; set; }

        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public int? Checkpoint { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("ConsumptionClient")]
        [Validation(Required=false)]
        public string ConsumptionClient { get; set; }

        [NameInMap("DbObject")]
        [Validation(Required=false)]
        public string DbObject { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ConsumptionCheckpoint")]
        [Validation(Required=false)]
        public string ConsumptionCheckpoint { get; set; }

        [NameInMap("EtlCalculator")]
        [Validation(Required=false)]
        public string EtlCalculator { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("BeginTimestamp")]
        [Validation(Required=false)]
        public string BeginTimestamp { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("DtsJobDirection")]
        [Validation(Required=false)]
        public string DtsJobDirection { get; set; }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeDtsJobDetailResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeDtsJobDetailResponseBodySourceEndpoint : TeaModel {
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("SslSolutionEnum")]
            [Validation(Required=false)]
            public string SslSolutionEnum { get; set; }
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeDtsJobDetailResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeDtsJobDetailResponseBodyDestinationEndpoint : TeaModel {
            [NameInMap("SslSolutionEnum")]
            [Validation(Required=false)]
            public string SslSolutionEnum { get; set; }
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
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
        public DescribeDtsJobDetailResponseBodyMigrationMode MigrationMode { get; set; }
        public class DescribeDtsJobDetailResponseBodyMigrationMode : TeaModel {
            [NameInMap("DataExtractTransformLoad")]
            [Validation(Required=false)]
            public bool? DataExtractTransformLoad { get; set; }
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

        [NameInMap("SubscriptionHost")]
        [Validation(Required=false)]
        public DescribeDtsJobDetailResponseBodySubscriptionHost SubscriptionHost { get; set; }
        public class DescribeDtsJobDetailResponseBodySubscriptionHost : TeaModel {
            [NameInMap("VpcHost")]
            [Validation(Required=false)]
            public string VpcHost { get; set; }
            [NameInMap("PublicHost")]
            [Validation(Required=false)]
            public string PublicHost { get; set; }
            [NameInMap("PrivateHost")]
            [Validation(Required=false)]
            public string PrivateHost { get; set; }
        };

        [NameInMap("SubscriptionDataType")]
        [Validation(Required=false)]
        public DescribeDtsJobDetailResponseBodySubscriptionDataType SubscriptionDataType { get; set; }
        public class DescribeDtsJobDetailResponseBodySubscriptionDataType : TeaModel {
            [NameInMap("Dml")]
            [Validation(Required=false)]
            public bool? Dml { get; set; }
            [NameInMap("Ddl")]
            [Validation(Required=false)]
            public bool? Ddl { get; set; }
        };

    }

}
