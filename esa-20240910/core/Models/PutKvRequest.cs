// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PutKvRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the content of the key is Base64-encoded. Set this parameter to true if you want to store the key content in binary format. When this parameter is set to true, the Value parameter must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Base64")]
        [Validation(Required=false)]
        public bool? Base64 { get; set; }

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
        /// <para>The name of the namespace that you specify when you call the <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The content of the key, which can be up to 2 MB (2 × 1000 × 1000). If the content is larger than 2 MB, call <a href="https://help.aliyun.com/document_detail/2850486.html">PutKvWithHighCapacity</a>.</para>
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
