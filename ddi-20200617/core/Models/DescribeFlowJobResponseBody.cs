// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeFlowJobResponseBody : TeaModel {
        [NameInMap("Adhoc")]
        [Validation(Required=false)]
        public string Adhoc { get; set; }

        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        [NameInMap("CustomVariables")]
        [Validation(Required=false)]
        public string CustomVariables { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EditLockDetail")]
        [Validation(Required=false)]
        public string EditLockDetail { get; set; }

        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConf { get; set; }

        [NameInMap("FailAct")]
        [Validation(Required=false)]
        public string FailAct { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("KnoxPassword")]
        [Validation(Required=false)]
        public string KnoxPassword { get; set; }

        [NameInMap("KnoxUser")]
        [Validation(Required=false)]
        public string KnoxUser { get; set; }

        [NameInMap("LastInstanceId")]
        [Validation(Required=false)]
        public string LastInstanceId { get; set; }

        [NameInMap("MaxRetry")]
        [Validation(Required=false)]
        public int? MaxRetry { get; set; }

        [NameInMap("MaxRunningTimeSec")]
        [Validation(Required=false)]
        public long? MaxRunningTimeSec { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConf { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParamConf")]
        [Validation(Required=false)]
        public string ParamConf { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public DescribeFlowJobResponseBodyResourceList ResourceList { get; set; }
        public class DescribeFlowJobResponseBodyResourceList : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeFlowJobResponseBodyResourceListResource> Resource { get; set; }
            public class DescribeFlowJobResponseBodyResourceListResource : TeaModel {
                public string Alias { get; set; }
                public string Path { get; set; }
            }
        };

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public long? RetryInterval { get; set; }

        [NameInMap("RetryPolicy")]
        [Validation(Required=false)]
        public string RetryPolicy { get; set; }

        [NameInMap("RunConf")]
        [Validation(Required=false)]
        public string RunConf { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
