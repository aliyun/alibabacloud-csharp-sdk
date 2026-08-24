// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class DeleteKVCacheStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>KVCacheStore KvcsId</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcs-your-id</para>
        /// </summary>
        [NameInMap("KvcsId")]
        [Validation(Required=false)]
        public string KvcsId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B127704C-ECB1-5B0A-AA9C-8F394A6F179F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
