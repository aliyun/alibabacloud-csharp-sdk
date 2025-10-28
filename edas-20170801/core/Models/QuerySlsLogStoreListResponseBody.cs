// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QuerySlsLogStoreListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d6834ee9-5045-*************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of Log Service for the application.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySlsLogStoreListResponseBodyResult> Result { get; set; }
        public class QuerySlsLogStoreListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The type of the logging service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Log Service</para>
            /// </summary>
            [NameInMap("ConsumerSide")]
            [Validation(Required=false)]
            public string ConsumerSide { get; set; }

            /// <summary>
            /// <para>The time when the logging service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18 22:08:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The URL of the logging service.</para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thisisatestlogstore</para>
            /// </summary>
            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c846f28edbd1d4c6aa9d78c0e********</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The source of logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard output: stdout.log</description></item>
            /// <item><description>File log: the directory that stores logs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/var/log/*</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The number of log sources configured for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
