// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListDeployOrdersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeployOrdersResponseBodyData> Data { get; set; }
        public class ListDeployOrdersResponseBodyData : TeaModel {
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            [NameInMap("CurrentPartitionNum")]
            [Validation(Required=false)]
            public int? CurrentPartitionNum { get; set; }

            [NameInMap("DeployOrderId")]
            [Validation(Required=false)]
            public long? DeployOrderId { get; set; }

            [NameInMap("DeployPauseType")]
            [Validation(Required=false)]
            public string DeployPauseType { get; set; }

            [NameInMap("DeployPauseTypeName")]
            [Validation(Required=false)]
            public string DeployPauseTypeName { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("DeployTypeName")]
            [Validation(Required=false)]
            public string DeployTypeName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public int? ElapsedTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("FailureRate")]
            [Validation(Required=false)]
            public string FailureRate { get; set; }

            [NameInMap("FinishAppInstanceCt")]
            [Validation(Required=false)]
            public int? FinishAppInstanceCt { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            [NameInMap("PartitionTypeName")]
            [Validation(Required=false)]
            public string PartitionTypeName { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("ResultName")]
            [Validation(Required=false)]
            public string ResultName { get; set; }

            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public long? SchemaId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            [NameInMap("TotalAppInstanceCt")]
            [Validation(Required=false)]
            public int? TotalAppInstanceCt { get; set; }

            [NameInMap("TotalPartitions")]
            [Validation(Required=false)]
            public int? TotalPartitions { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
