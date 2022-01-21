// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowJobsResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListFlowJobsResponseBodyJobList JobList { get; set; }
        public class ListFlowJobsResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListFlowJobsResponseBodyJobListJob> Job { get; set; }
            public class ListFlowJobsResponseBodyJobListJob : TeaModel {
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
                public string Mode { get; set; }
                public string MonitorConf { get; set; }
                public string Name { get; set; }
                public string ParamConf { get; set; }
                public string Params { get; set; }
                public ListFlowJobsResponseBodyJobListJobResourceList ResourceList { get; set; }
                public class ListFlowJobsResponseBodyJobListJobResourceList : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<ListFlowJobsResponseBodyJobListJobResourceListResource> Resource { get; set; }
                    public class ListFlowJobsResponseBodyJobListJobResourceListResource : TeaModel {
                        /// <summary>
                        /// 保留参数。
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// 保留参数。
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }
                public long? RetryInterval { get; set; }
                public string RunConf { get; set; }
                public string Type { get; set; }
            }
        };

        /// <summary>
        /// 当前页数。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页的作业数量。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 作业数量。
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
