// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PutKvRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the Value parameter uses Base64 encoding. Set this to true when storing a binary value. If this parameter is true, Value must be a valid Base64-encoded string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Base64")]
        [Validation(Required=false)]
        public bool? Base64 { get; set; }

        /// <summary>
        /// <para>The expiration time for the key-value pair, as a Unix timestamp in seconds. This value cannot be earlier than the current time. If you specify both Expiration and ExpirationTtl, ExpirationTtl takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690081381</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) for the key-value pair, in seconds. If you specify both Expiration and ExpirationTtl, ExpirationTtl takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("ExpirationTtl")]
        [Validation(Required=false)]
        public long? ExpirationTtl { get; set; }

        /// <summary>
        /// <para>The key can be up to 512 bytes long and cannot contain spaces or forward slashes (/).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The name of the namespace. You specify this name when you call the <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The value to associate with the key. The maximum size is 2 MB (2,000,000 bytes). For values that exceed this limit, use the <a href="https://help.aliyun.com/document_detail/2850486.html">PutKvWithHighCapacity</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
