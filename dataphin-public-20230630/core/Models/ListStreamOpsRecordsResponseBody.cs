// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamOpsRecordsResponseBody : TeaModel {
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
        /// <para>The start and stop operation records of real-time tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListStreamOpsRecordsResponseBodyData> Data { get; set; }
        public class ListStreamOpsRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>deploymentId</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac6e5a34bbd44d7f8b7851ef28c90d12</para>
            /// </summary>
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }

            /// <summary>
            /// <para>deploymentInstanceId</para>
            /// 
            /// <b>Example:</b>
            /// <para>7db678957dc449aab0086b931c9f8218</para>
            /// </summary>
            [NameInMap("DeploymentInstanceId")]
            [Validation(Required=false)]
            public string DeploymentInstanceId { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-15 13:46:40</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-15 13:46:26 INFO Starting Flink deployment</para>
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values: START, PAUSE, RESUME, and STOP. Displayed as Start, Pause, Recover, or Stop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>START</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>opsRecordId</para>
            /// 
            /// <b>Example:</b>
            /// <para>646</para>
            /// </summary>
            [NameInMap("OpsRecordId")]
            [Validation(Required=false)]
            public string OpsRecordId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-15 13:46:26</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

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
