// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvRequest : TeaModel {
        /// <summary>
        /// <para>The key-value pairs that you want to configure at a time. The total size can be up to 2 MB (2 × 1000 × 1000).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public List<BatchPutKvRequestKvList> KvList { get; set; }
        public class BatchPutKvRequestKvList : TeaModel {
            /// <summary>
            /// <para>The time when the key-value pair expires, which cannot be earlier than the current time. The value is a timestamp in seconds. If you specify both Expiration and ExpirationTtl, only ExpirationTtl takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690081381</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public long? Expiration { get; set; }

            /// <summary>
            /// <para>The relative expiration time. Unit: seconds. If you specify both Expiration and ExpirationTtl, only ExpirationTtl takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("ExpirationTtl")]
            [Validation(Required=false)]
            public long? ExpirationTtl { get; set; }

            /// <summary>
            /// <para>The key name. The name can be up to 512 characters in length and cannot contain spaces or backslashes (\\).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The key content.</para>
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
        /// <para>The name of the namespace that you specify when you call the <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a> operation.</para>
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
