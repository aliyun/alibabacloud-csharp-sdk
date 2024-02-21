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

                [NameInMap("LastInstanceDetail")]
                [Validation(Required=false)]
                public string LastInstanceDetail { get; set; }

                [NameInMap("MaxRetry")]
                [Validation(Required=false)]
                public int? MaxRetry { get; set; }

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

                [NameInMap("ResourceList")]
                [Validation(Required=false)]
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

                [NameInMap("RetryInterval")]
                [Validation(Required=false)]
                public long? RetryInterval { get; set; }

                [NameInMap("RunConf")]
                [Validation(Required=false)]
                public string RunConf { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

        }

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
