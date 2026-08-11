// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigFileResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>10D5E615-69F7-5F49-B850-00169ADE513C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAdvanceConfigFileResponseBodyResult Result { get; set; }
        public class GetAdvanceConfigFileResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The file content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;url\&quot;:\&quot;<a href="http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar%5C%5C%22%7D">http://xxxxxx.aliyuncs.com/outnet_hz/packages/xxxxx/opensearch_offline_plugins_xxxxx.tar\\&quot;}</a></para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
