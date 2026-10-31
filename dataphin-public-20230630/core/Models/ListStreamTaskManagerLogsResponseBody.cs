// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStreamTaskManagerLogsResponseBody : TeaModel {
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
        /// <para>The list of log files for the specified TaskManager.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListStreamTaskManagerLogsResponseBodyData> Data { get; set; }
        public class ListStreamTaskManagerLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The log file name. This name can be used as the logName input parameter for the logContent operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flink--standalonesession-0-dataphin-session-7db678957dc449aab0086b931c9f8218-jobmanager.log</para>
            /// </summary>
            [NameInMap("LogName")]
            [Validation(Required=false)]
            public string LogName { get; set; }

            /// <summary>
            /// <para>The last modified time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792033500000</para>
            /// </summary>
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }

            /// <summary>
            /// <para>The file size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

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
        /// <para>The backend exception details.</para>
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
