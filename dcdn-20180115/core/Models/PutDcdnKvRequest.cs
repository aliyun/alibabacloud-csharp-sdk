// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PutDcdnKvRequest : TeaModel {
        /// <summary>
        /// <para>The time when the key expires.Example: &quot;1690081381&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690081381</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// <para>The time when the key expires.Example: &quot;3600&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("ExpirationTtl")]
        [Validation(Required=false)]
        public long? ExpirationTtl { get; set; }

        /// <summary>
        /// <para>The key. The key can be up to 512 characters in length, and cannot contain spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The value of the key. The maximum size is 2 MB (2 x 1000 x 1000 bytes).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
