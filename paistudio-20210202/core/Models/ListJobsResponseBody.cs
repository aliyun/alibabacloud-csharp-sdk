// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>17677*******89598</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EXECUTE_ALL</para>
            /// </summary>
            [NameInMap("ExecuteType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>draft-4x4iv3a9enuxw4vgka</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-mewqhd72nsrqujn1px</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nodeId1</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node-xdfasf8ewxfdaddl</para>
            /// </summary>
            [NameInMap("PaiflowNodeId")]
            [Validation(Required=false)]
            public string PaiflowNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>flow-aayfouai80i980ncvz</para>
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>94436</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
