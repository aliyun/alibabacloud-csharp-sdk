// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public List<BatchPutKvRequestKvList> KvList { get; set; }
        public class BatchPutKvRequestKvList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1690081381</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public long? Expiration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("ExpirationTtl")]
            [Validation(Required=false)]
            public long? ExpirationTtl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
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
