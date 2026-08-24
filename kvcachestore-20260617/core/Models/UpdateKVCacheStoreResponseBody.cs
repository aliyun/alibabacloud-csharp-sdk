// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class UpdateKVCacheStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the modified KVCacheStore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvs-xxxxx</para>
        /// </summary>
        [NameInMap("KvcsId")]
        [Validation(Required=false)]
        public string KvcsId { get; set; }

        /// <summary>
        /// <para>The specification change order ID. Returned only when Capacity is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-xxxxx</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID. The request ID is returned regardless of whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AA27F1A-A62C-59C3-BCC7-D1DFA4E7EEA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
