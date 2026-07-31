// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSemanticJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details returned by the executor. Used to determine the run status and view the actual runtime configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSemanticJobDetailResponseBodyData Data { get; set; }
        public class GetSemanticJobDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The advanced runtime settings returned by the executor.</para>
            /// </summary>
            [NameInMap("AdvanceSettings")]
            [Validation(Required=false)]
            public Dictionary<string, object> AdvanceSettings { get; set; }

            /// <summary>
            /// <para>The code parameter information returned by the executor. Used for troubleshooting the runtime configuration of this run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--limit 100</para>
            /// </summary>
            [NameInMap("CodeParameters")]
            [Validation(Required=false)]
            public string CodeParameters { get; set; }

            /// <summary>
            /// <para>The index of the SQL fragment currently being processed by the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentSqlIndex")]
            [Validation(Required=false)]
            public int? CurrentSqlIndex { get; set; }

            /// <summary>
            /// <para>The customer identifier of the executor job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>meta_semantic</para>
            /// </summary>
            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <para>The data source identifier used by the executor job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("Datasource")]
            [Validation(Required=false)]
            public string Datasource { get; set; }

            /// <summary>
            /// <para>The runtime environment identifier returned by the executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The list of execution type codes returned by the executor.</para>
            /// </summary>
            [NameInMap("ExecTypes")]
            [Validation(Required=false)]
            public List<int?> ExecTypes { get; set; }

            /// <summary>
            /// <para>The executor job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-job-demo</para>
            /// </summary>
            [NameInMap("ExecutorJobId")]
            [Validation(Required=false)]
            public string ExecutorJobId { get; set; }

            /// <summary>
            /// <para>The node type code of the executor. Semantic jobs use Shell node code 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID associated with the executor job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group that actually executed the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-demo</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of resource URLs associated with the executor job.</para>
            /// </summary>
            [NameInMap("ResourceUrls")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ResourceUrls { get; set; }

            /// <summary>
            /// <para>The list of status codes returned by the executor. Used to determine the current or final status of the job.</para>
            /// </summary>
            [NameInMap("Statuses")]
            [Validation(Required=false)]
            public List<int?> Statuses { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
