// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9B3C4E7-BEC7-1E2C-86A3-EA985B4FFD73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryLinkResponseBodyResultContent ResultContent { get; set; }
        public class QueryLinkResponseBodyResultContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///             &quot;Modified&quot;: &quot;2024-04-29 16:35:55&quot;,
            ///             &quot;NeedRenderEvent&quot;: false,
            ///             &quot;WorkspaceId&quot;: &quot;default&quot;,
            ///             &quot;Cors&quot;: false,
            ///             &quot;Url&quot;: &quot;<a href="https://xxx/xxx">https://xxx/xxx</a>&quot;,
            ///             &quot;Created&quot;: &quot;2024-04-29 16:35:55&quot;,
            ///             &quot;LastModified&quot;: &quot;2024-04-29 16:35:55&quot;,
            ///             &quot;Target&quot;: &quot;<a href="http://xxx/test.html">http://xxx/test.html</a>&quot;,
            ///             &quot;Dynamictarget&quot;: &quot;&quot;,
            ///             &quot;AppId&quot;: &quot;BB5953C300957&quot;,
            ///             &quot;Version&quot;: 0,
            ///             &quot;Traceid&quot;: &quot;f6c95f06891a19ff2d896ea309581883&quot;,
            ///             &quot;Domain&quot;: &quot;u.aliyuncs.com&quot;
            ///         }</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public object Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx/xxx/xxx">https://xxx/xxx/xxx</a></para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
