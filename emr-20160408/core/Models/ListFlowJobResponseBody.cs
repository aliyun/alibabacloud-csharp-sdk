// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowJobResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListFlowJobResponseBodyJobList JobList { get; set; }
        public class ListFlowJobResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListFlowJobResponseBodyJobListJob> Job { get; set; }
            public class ListFlowJobResponseBodyJobListJob : TeaModel {
                public string Adhoc { get; set; }
                public string AlertConf { get; set; }
                public string CategoryId { get; set; }
                public string CustomVariables { get; set; }
                public string Description { get; set; }
                public string EnvConf { get; set; }
                public string FailAct { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Id { get; set; }
                public string LastInstanceDetail { get; set; }
                public int? MaxRetry { get; set; }
                public string MonitorConf { get; set; }
                public string Name { get; set; }
                public string ParamConf { get; set; }
                public string Params { get; set; }
                public ListFlowJobResponseBodyJobListJobResourceList ResourceList { get; set; }
                public class ListFlowJobResponseBodyJobListJobResourceList : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<ListFlowJobResponseBodyJobListJobResourceListResource> Resource { get; set; }
                    public class ListFlowJobResponseBodyJobListJobResourceListResource : TeaModel {
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }
                public long? RetryInterval { get; set; }
                public string RunConf { get; set; }
                public string Type { get; set; }
                public string Mode { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
