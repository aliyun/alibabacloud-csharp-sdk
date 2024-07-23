// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpDBDeleteJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The jobs of deleting a media fingerprint library. For more information, see the &quot;FpDBDeleteJob&quot; section of the <a href="https://www.alibabacloud.com/help/en/apsaravideo-for-media-processing/latest/datatypes">Data types</a> topic.</para>
        /// </summary>
        [NameInMap("FpDBDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList FpDBDeleteJobList { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList : TeaModel {
            [NameInMap("FpDBDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob> FpDBDeleteJob { get; set; }
            public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob : TeaModel {
                /// <summary>
                /// <para>The error code returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ServiceUnavailable</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The time when the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-30T00:33:18Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The type of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Purge</para>
                /// </summary>
                [NameInMap("DelType")]
                [Validation(Required=false)]
                public string DelType { get; set; }

                /// <summary>
                /// <para>The time when the job was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-30T00:34:02Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the media fingerprint library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e47098a5b665e2a12****</para>
                /// </summary>
                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                /// <summary>
                /// <para>The ID of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25bacf2824614bcf9273dc0744db****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The request has failed due to a temporary failure of the server.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb712a6890464059b1b2ea7c8647****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The status of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Queuing</b>: The job is waiting in the queue.</description></item>
                /// <item><description><b>Analysing</b>: The job is in progress.</description></item>
                /// <item><description><b>Success</b>: The job is successful.</description></item>
                /// <item><description><b>Fail</b>: The job fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The user-defined data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example data</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the jobs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4247B23C-26DE-529F-8D9F-FD6811AE979B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
