// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListOfflineTaskErrorLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-2-3-4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of log request bodies, log responses, retry counts, and timestamps.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListOfflineTaskErrorLogsResponseBodyResult> Result { get; set; }
        public class ListOfflineTaskErrorLogsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para><b>The log request body.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;instance&quot;:&quot;123&quot;,&quot;user&quot;:&quot;xuanzhen&quot;}</para>
            /// </summary>
            [NameInMap("request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            /// <summary>
            /// <para><b>The log response.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;error&quot;:{&quot;reason&quot;:&quot;unable to authenticate user [elastic] for REST request [/_bulk]&quot;,&quot;header&quot;:{&quot;WWW-Authenticate&quot;:[&quot;Basic realm=\&quot;security\&quot;, charset=\&quot;UTF-8\&quot;&quot;,&quot;ApiKey&quot;]},&quot;type&quot;:&quot;security_exception&quot;,&quot;root_cause&quot;:[{&quot;reason&quot;:&quot;unable to authenticate user [elastic] for REST request [/_bulk]&quot;,&quot;header&quot;:{&quot;WWW-Authenticate&quot;:[&quot;Basic realm=\&quot;security\&quot;, charset=\&quot;UTF-8\&quot;&quot;,&quot;ApiKey&quot;]},&quot;type&quot;:&quot;security_exception&quot;}]},&quot;status&quot;:401}]</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para><b>The number of retries.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retry")]
            [Validation(Required=false)]
            public string Retry { get; set; }

            /// <summary>
            /// <para><b>The timestamp.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>1770272507085</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
