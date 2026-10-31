// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamInstanceRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The historical running instance records of the real-time task. You can use the deploymentInstanceId to query the logs of a specific run.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListStreamInstanceRecordsResponseBodyData> Data { get; set; }
        public class ListStreamInstanceRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deployment ID of the task. A single deployment can be associated with multiple running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac6e5a34bbd44d7f8b7851ef28c90d12</para>
            /// </summary>
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }

            /// <summary>
            /// <para>The instance ID of the deployment running instance. This value corresponds to the DeploymentInstanceId request parameter in the log and TaskManager query operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7db678957dc449aab0086b931c9f8218</para>
            /// </summary>
            [NameInMap("DeploymentInstanceId")]
            [Validation(Required=false)]
            public string DeploymentInstanceId { get; set; }

            /// <summary>
            /// <para>The relative path for dirty data storage in this run, excluding the storage service domain name. A value of null indicates that no dirty data path exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dirty-data/7333610201479808/7db678957dc449aab0086b931c9f8218/error.log</para>
            /// </summary>
            [NameInMap("ErrorDataPath")]
            [Validation(Required=false)]
            public string ErrorDataPath { get; set; }

            /// <summary>
            /// <para>The start time of this run. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-15 13:46:26</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The running instance status returned by the engine, such as RUNNING, FINISHED, and TRANSITIONING. This status uses a different enumeration from the TaskStatusEnum returned by the GetStreamTask operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend response exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
