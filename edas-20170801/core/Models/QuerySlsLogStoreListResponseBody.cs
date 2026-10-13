// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QuerySlsLogStoreListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d6834ee9-5045-*************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Simple Log Service configuration results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySlsLogStoreListResponseBodyResult> Result { get; set; }
        public class QuerySlsLogStoreListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Simple Log Service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Simple Log Service</para>
            /// </summary>
            [NameInMap("ConsumerSide")]
            [Validation(Required=false)]
            public string ConsumerSide { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18 22:08:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Simple Log Service link.</para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The Logstore name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thisisatestlogstore</para>
            /// </summary>
            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c846f28edbd1d4c6aa9d78c0e********</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The log source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard output: stdout.log.</description></item>
            /// <item><description>File log: the collection path.</description></item>
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
        /// <para>The total number of Simple Log Service configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
