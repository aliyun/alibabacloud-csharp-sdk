// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvRequest : TeaModel {
        /// <summary>
        /// <para>The list of key-value pairs to set. The total size cannot exceed 2 MB (2 × 1,000 × 1,000).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public List<BatchPutKvRequestKvList> KvList { get; set; }
        public class BatchPutKvRequestKvList : TeaModel {
            /// <summary>
            /// <para>The expiration time. This is a UNIX timestamp in seconds and cannot be earlier than the current time. If you set both Expiration and ExpirationTtl, ExpirationTtl takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690081381</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public long? Expiration { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL). This is a relative time in seconds. If you set both Expiration and ExpirationTtl, ExpirationTtl takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("ExpirationTtl")]
            [Validation(Required=false)]
            public long? ExpirationTtl { get; set; }

            /// <summary>
            /// <para>The name of the key. The key can be up to 512 characters long and cannot contain spaces or backslashes (/).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name specified when you call <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
