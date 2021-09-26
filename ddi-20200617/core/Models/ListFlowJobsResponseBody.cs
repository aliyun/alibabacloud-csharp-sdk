// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowJobsResponseBody : TeaModel {
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

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListFlowJobsResponseBodyJobList JobList { get; set; }
        public class ListFlowJobsResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListFlowJobsResponseBodyJobListJob> Job { get; set; }
            public class ListFlowJobsResponseBodyJobListJob : TeaModel {
                public string Type { get; set; }
                public string FailAct { get; set; }
                public string CustomVariables { get; set; }
                public long? RetryInterval { get; set; }
                public string EnvConf { get; set; }
                public string ParamConf { get; set; }
                public string Mode { get; set; }
                public long? GmtModified { get; set; }
                public string MonitorConf { get; set; }
                public string LastInstanceDetail { get; set; }
                public string RunConf { get; set; }
                public string Params { get; set; }
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public string CategoryId { get; set; }
                public string Adhoc { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public int? MaxRetry { get; set; }
                public string AlertConf { get; set; }
                public ListFlowJobsResponseBodyJobListJobResourceList ResourceList { get; set; }
                public class ListFlowJobsResponseBodyJobListJobResourceList : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<ListFlowJobsResponseBodyJobListJobResourceListResource> Resource { get; set; }
                    public class ListFlowJobsResponseBodyJobListJobResourceListResource : TeaModel {
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                    }

                }
            }
        };

    }

}
