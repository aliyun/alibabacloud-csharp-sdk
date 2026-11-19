// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamTaskManagersResponseBody : TeaModel {
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
        /// <para>The TaskManager information retrieved in real time. You can use the taskmanagerId to query the logs of the TaskManager.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListStreamTaskManagersResponseBodyData> Data { get; set; }
        public class ListStreamTaskManagersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The communication address or host machine information of the TaskManager returned by the engine. This is not the log download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>akka.tcp://<a href="mailto:flink@10.0.0.12">flink@10.0.0.12</a>:6122/user/rpc/taskmanager_0</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The identifier of the TaskManager. This corresponds to the TaskmanagerId input parameter of ListStreamTaskManagerLogs and GetStreamLogContent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin-session-7db678957dc449aab0086b931c9f8218-taskmanazjkxq</para>
            /// </summary>
            [NameInMap("TaskmanagerId")]
            [Validation(Required=false)]
            public string TaskmanagerId { get; set; }

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
        /// <para>The details of the backend exception.</para>
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
