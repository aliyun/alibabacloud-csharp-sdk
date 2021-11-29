// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeFlowNodeInstanceResponseBody : TeaModel {
        [NameInMap("Adhoc")]
        [Validation(Required=false)]
        public bool? Adhoc { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConf { get; set; }

        [NameInMap("ExternalChildIds")]
        [Validation(Required=false)]
        public string ExternalChildIds { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("ExternalInfo")]
        [Validation(Required=false)]
        public string ExternalInfo { get; set; }

        [NameInMap("ExternalStatus")]
        [Validation(Required=false)]
        public string ExternalStatus { get; set; }

        [NameInMap("ExternalSubId")]
        [Validation(Required=false)]
        public string ExternalSubId { get; set; }

        [NameInMap("FailAct")]
        [Validation(Required=false)]
        public string FailAct { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("FlowInstanceId")]
        [Validation(Required=false)]
        public string FlowInstanceId { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("MaxRetry")]
        [Validation(Required=false)]
        public string MaxRetry { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConf { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("ParamConf")]
        [Validation(Required=false)]
        public string ParamConf { get; set; }

        [NameInMap("Pending")]
        [Validation(Required=false)]
        public bool? Pending { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Retries")]
        [Validation(Required=false)]
        public int? Retries { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public string RetryInterval { get; set; }

        [NameInMap("RetryPolicy")]
        [Validation(Required=false)]
        public string RetryPolicy { get; set; }

        [NameInMap("RunConf")]
        [Validation(Required=false)]
        public string RunConf { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
