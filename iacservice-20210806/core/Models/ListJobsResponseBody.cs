// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public ListJobsResponseBodyJobsConfig Config { get; set; }
            public class ListJobsResponseBodyJobsConfig : TeaModel {
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                [NameInMap("moduleDescription")]
                [Validation(Required=false)]
                public string ModuleDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

                [NameInMap("subCommand")]
                [Validation(Required=false)]
                public string SubCommand { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-05T02:13:43Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isPassAssertCheck")]
            [Validation(Required=false)]
            public bool? IsPassAssertCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-433aead756057fff9e4dca57b147c</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobsStatusDetailValue> StatusDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-518855d9a058c1176866c2c3efb</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>882304F9-6DB1-5593-A719-33473D082B9C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
